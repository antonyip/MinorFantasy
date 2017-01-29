using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using DG.Tweening;

public class GameMaster : MonoBehaviour {

    public static GameMaster instance;
    List<Unit> AllUnits = new List<Unit>();
    List<Unit> PlayerUnits = new List<Unit>();
    public GameObject monsterPrefab;
    public List<GameObject> PlayerUnitsSpritePositions = new List<GameObject>();
    public List<GameObject> PlayerUnitsSprite = new List<GameObject>();
    public List<GameObject> MonstersUnitsSpritePositions = new List<GameObject>();
    public List<GameObject> AttackSpritePositions = new List<GameObject>();
    public List<GameObject> MonstersUnitsSprite = new List<GameObject>();
    public List<GameObject> OptionButtons = new List<GameObject>();
    public List<GameObject> PlayerButtons = new List<GameObject>();

    public Text TopText;

    public SpriteRenderer BattleBackground;

    // gamelists
    public GameObject Announcer;
    public GameObject StartGamePopup;
    public GameObject VictoryPopup;
    public GameObject OptionsPopup;
    public GameObject SelectChoices;

    public GameObject ItemDropPrefab;

    public List<Item> ListOfItemsThatDropped = new List<Item>();

    public bool AutoMode = true;

    int currentWave = 0;
    int experienceEarnedThisMap = 0;
    static float MAPBONUSMULTIPLIER = 1.0f;

    void Awake()
    {
        instance = this;
    }

    public void UpdateTopText(string TextToUpdate)
    {
        TopText.text = TextToUpdate;
    }

    void ResetMapDetails()
    {
        currentWave = 0;
        experienceEarnedThisMap = 0;

        BattleBackground.sprite = Resources.Load<Sprite>("Backgrounds/" + AntTool.LevelData.instance.Rows.Find(x => x._ID == DataManager.instance.selectedMapLevel)._BackgroundSprite);
    }

    int NumPlayerSpawn = 0;
    // Use this for initialization
    void Start () {

        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);
        AutoMode = DataManager.instance.userData.AutoMode;
        ResetMapDetails();

        // 0. setup playing field
        OptionButtons[0].GetComponent<GameOptionsButton>().Setup(0);
        OptionButtons[1].GetComponent<GameOptionsButton>().Setup(1);
        OptionButtons[2].GetComponent<GameOptionsButton>().Setup(2);

        Debug.Log("GameStarted");
        Debug.Log("Loading Fight Data");

        // 1. load fight data
        // load player data
        var dataManager = DataManager.instance;
        Debug.Assert(dataManager != null);
        Debug.Assert(dataManager.userData.listOfTeams != null);
        Debug.Assert(dataManager.userData.listOfTeams[dataManager.selectedTeam] != null);


        NumPlayerSpawn = 0;
        for (int i = 0; i < dataManager.userData.listOfTeams[dataManager.selectedTeam].GetListOfCharacters().Count; i++)
        {
            for (int j = 0; j < DataManager.MAXUNITPERTEAM; j++)
            {
                PlayerButtons[j].GetComponent<BattleButtonScript>().Setup(j);
            }

            var playerChar = dataManager.userData.listOfTeams[dataManager.selectedTeam].GetListOfCharacters()[i];
            Unit u = new Unit();
            if (playerChar != null)
            {
                
                u.character = new Character();
                u.character.playerStats = playerChar;
                u.character.playerStats.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == playerChar.ID);
                u.IsEnemyUnit = false;
                u.Start();
                u.ID = i;

                for (int j = 0; j < playerChar.LimitGambits.Count; j++)
                {
                    // make sure the combination is legit
                    if (playerChar.LimitGambits[j] == true && playerChar.CurrentGambits[j] != -1 && playerChar.CurrentSkills[j] != -1)
                    {
                        u.aiActions.Add(Gambits.GetGambit(playerChar.CurrentGambits[j]));
                        u.aiSkills.Add(new Skill(playerChar.CurrentSkills[j]));
                    }
                }

                //GameObject go = Instantiate(monsterPrefab) as GameObject;
                string modelName = u.character.playerStats.databaseChar._SpriteIdle;
                Debug.Log("attempting to load" +  modelName);
                GameObject go = Instantiate(Resources.Load("HeroPrefabs/" + modelName)) as GameObject;
                go.transform.SetParent(PlayerUnitsSpritePositions[i].transform);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = Vector3.zero;

                Sequence seq = DOTween.Sequence();
                seq.AppendInterval(DataManager.NORMALANIMATION * i);
                seq.Append(go.transform.DOScale(Vector3.one, DataManager.LONGANIMATION));
                seq.Play().OnComplete(ButtonStartGameClicked);
                //used for animation
                ++NumPlayerSpawn;

                go.name = u.character.playerStats.databaseChar._SpriteIdle;
                go.GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(go.name);

                u.sprite = go;
                PlayerUnitsSprite.Add(go);
                AllUnits.Add(u);
            }
            

            PlayerUnits.Add(u);

        }
        
        SpawnWave(currentWave);
        UpdatePlayerControls();
    } //end start


    int monsterToSpawnCounter = 0;
    void SpawnWave(int waveIndexToSpawn)
    {
        SpawnLock = true;
        // clean up old waves
        AllUnits = AllUnits.FindAll(x => x.character.IsPlayer()).ToList();

        // load enemy data
        DataManager dataManager = DataManager.instance;
        var Map = AntTool.LevelData.instance.Rows.Find(x => x._ID == dataManager.selectedMapLevel);
        List<string> MobsToSpawn = new List<string>();

        // figure out the wave string 


        string WaveString = "";
        switch (waveIndexToSpawn)
        {
            case 0:
                WaveString = Map._Battle1;
                break;
            case 1:
                WaveString = Map._Battle2;
                break;
            case 2:
                WaveString = Map._Battle3;
                break;
            case 3:
                WaveString = Map._Battle4;
                break;
            case 4:
                WaveString = Map._Battle5;
                break;
            case 5:
                WaveString = "";
                break;
            default:
                break;

        }

        HasWon = false;

        if (WaveString == "")
        {
            HasWon = true;
            Debug.Log("You won this level!");
            VictoryPopup.SetActive(true);
            VictoryPopup.GetComponent<VictoryScript>().SpreadExpPoints(experienceEarnedThisMap);
            VictoryPopup.GetComponent<VictoryScript>().DisplayLoots(ListOfItemsThatDropped);
            VictoryPopup.GetComponent<VictoryScript>().HandleVictory();
            return;
        }

        if (WaveString.Contains(','))
            MobsToSpawn = WaveString.Split(',').ToList();
        else
            MobsToSpawn.Add(WaveString);


        monsterToSpawnCounter = 0;
        for (int i = 0; i < MobsToSpawn.Count; i++)
        {
            if (MobsToSpawn[i].Trim() != "-1")
            {
                var item = MobsToSpawn[i];
                var MobsID = int.Parse(item);
                var Mob = AntTool.MobData.instance.Rows.Find(x => x._ID == MobsID);
                Unit u = new Unit();
                u.ID = DataManager.MAXUNITPERTEAM + i;
                u.character = new Character();
                u.character.monsterStats = new MonsterCharacter();
                u.character.monsterStats.ID = MobsID;
                u.character.monsterStats.monsterStats = Mob;
                u.character.monsterStats.CurrentLevel = u.character.monsterStats.monsterStats._Level;
                u.IsEnemyUnit = true;
                u.Start();
                string skillString = u.character.monsterStats.monsterStats._Skills;
                string[] mobSkills = skillString.Split(',');
                foreach (var skillPair in mobSkills)
                {
                    string[] skillParts = skillPair.Split('=');
                    int logic = int.Parse(skillParts[0]);
                    int skill = int.Parse(skillParts[1]);
                    u.aiActions.Add(Gambits.GetGambit(logic));
                    u.aiSkills.Add(new Skill(skill));
                }

                string modelName = Mob._SpriteIdle;
                GameObject go = Instantiate(Resources.Load("EnemyPrefabs/" + modelName)) as GameObject;
                go.transform.SetParent(MonstersUnitsSpritePositions[i].transform);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = Vector3.zero;
                go.name = Mob._SpriteIdle;
                go.GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(Mob._SpriteIdle);

                Sequence seq = DOTween.Sequence();
                seq.AppendInterval(DataManager.NORMALANIMATION * i);
                seq.Append(go.transform.DOScale(Vector3.one, DataManager.LONGANIMATION));
                seq.Play().OnComplete(MonsterSpawnComplete);
                ++monsterToSpawnCounter;
                u.sprite = go;
                MonstersUnitsSprite.Add(go);

                AllUnits.Add(u);
            }
        }


        Debug.Log("Determining Speed Que");
        AllUnits = AllUnits.OrderBy(x => x.character.GetSpeed()).ToList();

        for (int i = 0; i < AllUnits.Count; i++)
        {
            Debug.Log(i.ToString() + ". " + AllUnits[i].GetUnitName());
        }

        UnitOrderCounter = 0;
    }

    void UpdatePlayerControls()
    {
        //List<PlayerCharacter> playerCharacters = DataManager.instance.userData.listOfTeams[DataManager.instance.selectedTeam].GetListOfCharacters();
        for (int i = 0; i < DataManager.MAXUNITPERTEAM; i++)
        {           
            PlayerButtons[i].GetComponent<BattleButtonScript>().UpdateGUI(PlayerUnits[i]);
        }
    }

    public bool BypassAnimationLock = false;
    bool AnimationLock = false;
    bool ItemLock = false;
    bool SpawnLock = false;

    public void ReleaseAnimationLock()
    {
        AnimationLock = false;
    }

    public void ReleaseItemLock()
    {
        ItemLock = false;
    }

    /// <summary>
    /// called by invoke
    /// </summary>
    public void ReleaseSpawnLock()
    {
        SpawnLock = false;
    }

    public void BackToMenu()
    {
        SceneManager.instance.NextSceneName = "MainMenu";
    }

    // start Game button clicked from UI
    int counter = 0;
    void ButtonStartGameClicked()
    {
        ++counter;
        if (NumPlayerSpawn == counter)
        { 
            GameNotStarted = false;
            StartGamePopup.SetActive(false);
            UpdatePlayerControls();
        }
    }

    int monsterCounter = 0;
    void MonsterSpawnComplete()
    {
        ++monsterCounter;
        if (monsterCounter == monsterToSpawnCounter)
        {
            monsterCounter = 0;
            Invoke("ReleaseSpawnLock", DataManager.LONGANIMATION);
        }
    }



    int UnitOrderCounter = 0;
    bool HasWon = false;
    bool HasLost = false;
    bool GameNotStarted = true;
    bool FirstTimeUserOnThisTurn = true;

    // Update is called once per frame
    void FixedUpdate ()
    {
        // if waiting for animation or user input..
        if ((AnimationLock && !BypassAnimationLock) || HasWon || HasLost || GameNotStarted || ItemLock || SpawnLock)
        {
            return;
        }

        // Check for gameover
        var EnemyUnits = AllUnits.FindAll(x => x.IsEnemyUnit == true && !x.isDead);

        if (EnemyUnits.Count == 0)
        {
            HasWon = true;
            Debug.Log("You won this wave!");
            ++currentWave;         
            SpawnWave(currentWave);
            return;
        }

        var PlayerUnits = AllUnits.FindAll(x => x.IsEnemyUnit == false && !x.isDead);

        if (PlayerUnits.Count == 0)
        {
            HasLost = true;
            Debug.Log("You lost!");
            VictoryPopup.SetActive(true);
            VictoryPopup.GetComponent<VictoryScript>().DisplayLoots(ListOfItemsThatDropped);
            VictoryPopup.GetComponent<VictoryScript>().HandleLost();
            return;
        }

        // grab first person in que.
        Unit currentUnit = AllUnits[UnitOrderCounter % AllUnits.Count];
        if (currentUnit != null)
        {
            

            if (currentUnit.IsEnemyUnit)
            {
                Debug.Log("Turn:" + UnitOrderCounter.ToString());
                ExecuteGambits(currentUnit, new List<Unit>());
                ++UnitOrderCounter;
            }
            else
            {
                if (AutoMode)
                {
                    Debug.Log("Turn:" + UnitOrderCounter.ToString());
                    ExecuteGambits(currentUnit, new List<Unit>());
                    ++UnitOrderCounter;
                }
                else
                {
                    // wait for user input - have a que system so that we can "bot" user commands
                    if (!FirstTimeUserOnThisTurn)
                        return;

                    if (currentUnit.isDead)
                    {
                        ++UnitOrderCounter;
                        return;
                    }

                    Debug.Log("Turn:" + UnitOrderCounter.ToString());
                    UserCurrentUnit = currentUnit;

                    PlayerButtons[currentUnit.ID].GetComponentInChildren<DOTweenVisualManager>().enabled = true;

                    FirstTimeUserOnThisTurn = false;
                }
            }
            
            // start the effects show.

        } // endif currentUnit != null

    } // end update

    

    void RollForLoot(Unit killer, Unit deadUnit)
    {
        Debug.Log("rolling for loot");
        Item ItemThatDropped = deadUnit.character.GetLoot(deadUnit, 0,0,0,0);
        if (ItemThatDropped != null)
        {
            // do some animation with the dropped item like spawning it
            GameObject go = Instantiate(ItemDropPrefab);
            go.transform.SetParent(deadUnit.sprite.transform.parent);
            go.transform.localScale = Vector3.zero;
            go.transform.localPosition = Vector3.zero;
            go.SetActive(true);
            ItemLock = true;
            go.GetComponent<ItemDropScript>().SetupItem(ItemThatDropped);

            ItemThatDropped.sprite = go;
            ListOfItemsThatDropped.Add(ItemThatDropped);
            Debug.Log("LegitItem");
        }
        
    }

    public void ShowOptions()
    {
        OptionsPopup.SetActive(true);
        OptionsPopup.transform.localScale = Vector3.zero;
        OptionsPopup.transform.DOScale(Vector3.one, DataManager.NORMALANIMATION);
    }

    public void HideOptions()
    {
        OptionsPopup.transform.localScale = Vector3.one;
        OptionsPopup.transform.DOScale(Vector3.zero, DataManager.NORMALANIMATION).OnComplete(HideOptionsVisible);
    }

    void HideOptionsVisible()
    {
        OptionsPopup.SetActive(false);
    }

    public void GUIButtonPressed(int buttonID)
    {
        Debug.Log(buttonID);
        PlayerButtons[buttonID].GetComponentInChildren<DOTweenVisualManager>().enabled = false;
        SelectChoices.SetActive(true);
        SelectChoices.GetComponent<SelectChoicesScript>().Setup(PlayerUnits.Find(x => x.ID == buttonID));
    }

    Unit UserCurrentUnit;
    int UserSkillID;
    public void SkillButtonPressed(AntTool.SkillDataRow skill, int buttonID)
    {
        Debug.Log(skill._Name);
        UserSkillID = buttonID;
        TARGETTYPE tt = TARGETTYPE.ALL;
        switch (skill._TargetType)
        {
            default:
                tt = TARGETTYPE.ALL;
                break;
        }
        SelectChoices.GetComponent<SelectChoicesScript>().SetupTarget(tt, AllUnits);
    }

    public void TargetButtonPressed(int ButtonID)
    {
        SelectChoices.SetActive(false);
        ExecuteGambits(UserCurrentUnit, AllUnits, UserSkillID);
        FirstTimeUserOnThisTurn = true;
    }

    private void ExecuteGambits(Unit currentUnit, List<Unit> unitsAffected)
    {
        ExecuteGambits(currentUnit, unitsAffected, -1);
    }

    private void ExecuteGambits(Unit currentUnit, List<Unit> unitsAffected, int skillID)
    {
        if (currentUnit.isDead)
            return;

        //evaulate gambits
        //int selectedSkillGambit = -1;
        Skill selectedSkill = null;
        if (!(unitsAffected != null && unitsAffected.Count > 0))
        {
            for (int i = 0; i < DataManager.MAXGAMBITCOUNT; i++)
            {
                if (i >= currentUnit.aiActions.Count)
                    return;

                unitsAffected = currentUnit.aiActions[i].EvaluateThis(ref currentUnit, ref AllUnits);

                if (unitsAffected != null && unitsAffected.Count > 0)
                {
                    //selectedSkillGambit = i;
                    selectedSkill = currentUnit.aiSkills[i];
                    break;
                }

            }
        }
        else
        {
            selectedSkill = new Skill(currentUnit.character.playerStats.AvailableSkills()[skillID]);
        }

        // handle animations
        if (unitsAffected != null && unitsAffected.Count > 0)
        {
            Debug.Log("Execute Gambit");
            bool isMelee = false;
            Unit MeleeAnimationTarget = null;
            for (int j = 0; j < unitsAffected.Count; j++)
            {
                Unit ounit = unitsAffected[j];
                MeleeAnimationTarget = unitsAffected[j];

                ounit.sprite.transform.DOPunchPosition(new Vector3(Random.Range(-15, 15), Random.Range(-15, 15), 0), DataManager.LONGANIMATION);
                //isMelee = currentUnit.aiSkills[selectedSkillGambit].EvaluateSkillEffect(ref currentUnit, ref ounit);
                isMelee = selectedSkill.EvaluateSkillEffect(ref currentUnit, ref ounit);
                
                AnimationLock = isMelee;
                if (ounit.isDead)
                {
                    Sequence seq = DOTween.Sequence();
                    seq.AppendInterval(DataManager.LONGANIMATION);
                    seq.Append(ounit.sprite.transform.DOScale(Vector3.zero, DataManager.LONGANIMATION));
                    seq.Play();
                    experienceEarnedThisMap += Mathf.CeilToInt(1.0f * ounit.character.GetExperience() * MAPBONUSMULTIPLIER * DataManager.instance.userData.MAPBONUSMULTIPLIER);
                    RollForLoot(currentUnit, ounit);
                }
            }



            if (isMelee)
            {
                originalSprite = currentUnit.sprite;
                orignalPos = currentUnit.sprite.transform.position;
                AnimationName = selectedSkill.dataBaseSkill._Name;
                //Vector3 attackPos = MeleeAnimationTarget.sprite.transform.position;
                Vector3 attackPos = AttackSpritePositions[MeleeAnimationTarget.ID].transform.position;
                currentUnit.sprite.transform.DOMove(attackPos, DataManager.NORMALANIMATION).OnComplete(AttackWithCurrentUnit);
            }
            else
            {
                currentUnit.sprite.GetComponentInChildren<SpriteAnimation>().LoadEnemyAttack(selectedSkill.dataBaseSkill._Name);
            }

            // reset the skill
            UserSkillID = -1;
            UpdatePlayerControls();
        }
    }

    GameObject originalSprite;
    Vector3 orignalPos;
    string AnimationName;

    void AttackWithCurrentUnit()
    {
        originalSprite.GetComponentInChildren<SpriteAnimation>().LoadEnemyAttack(AnimationName);
        originalSprite.transform.DOScale(Vector3.one, DataManager.NORMALANIMATION).OnComplete(MoveBackCurrentUnit);
    }

    void MoveBackCurrentUnit()
    {
        originalSprite.transform.DOMove(orignalPos, DataManager.NORMALANIMATION).OnComplete(ReleaseAnimationLock);
    }
}
