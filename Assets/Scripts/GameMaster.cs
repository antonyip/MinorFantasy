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
    public List<GameObject> MonstersUnitsSprite = new List<GameObject>();
    public List<GameObject> OptionButtons = new List<GameObject>();
    public List<GameObject> PlayerButtons = new List<GameObject>();

    public Text TopText;

    // gamelists
    public GameObject Announcer;
    public GameObject StartGamePopup;
    public GameObject VictoryPopup;

    public GameObject ItemDropPrefab;

    public List<Item> ListOfItemsThatDropped = new List<Item>();

    bool AutoMode = true;

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
    }
    int NumPlayerSpawn = 0;
    // Use this for initialization
    void Start () {

        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);

        ResetMapDetails();

        // 0. setup playing field
        OptionButtons[0].GetComponentInChildren<Text>().text = "Auto";
        OptionButtons[1].GetComponentInChildren<Text>().text = "Tactics";
        OptionButtons[2].GetComponentInChildren<Text>().text = "Options";

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
            var playerChar = dataManager.userData.listOfTeams[dataManager.selectedTeam].GetListOfCharacters()[i];
            Unit u = new Unit();
            if (playerChar != null)
            {
                
                u.character = new Character();
                u.character.playerStats = playerChar;
                u.character.playerStats.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == playerChar.ID);
                u.IsEnemyUnit = false;
                u.Start();

                u.aiActions.Add(Gambits.GetGambit(1));
                u.aiSkills.Add(new Skill(1));

                //GameObject go = Instantiate(monsterPrefab) as GameObject;
                string modelName = u.character.playerStats.databaseChar._SpriteIdle;
                Debug.Log("attempting to load" +  modelName);
                GameObject go = Instantiate(Resources.Load("EnemyPrefabs/" + modelName)) as GameObject;
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

        Debug.Log("Determining Speed Que");
        AllUnits = AllUnits.OrderBy(x => x.character.GetSpeed()).ToList();

        for (int i = 0; i < AllUnits.Count; i++)
        {
            Debug.Log(i.ToString() + ". " + AllUnits[i].GetUnitName());
        }

        // 2. start fight
        // determine order of attacks by all not null players
        // place them in a que
        // start the que

    } //end start

    void SpawnWave(int waveIndexToSpawn)
    {
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

        for (int i = 0; i < MobsToSpawn.Count; i++)
        {
            var item = MobsToSpawn[i];
            var MobsID = int.Parse(item);
            var Mob = AntTool.MobData.instance.Rows.Find(x => x._ID == MobsID);
            Unit u = new Unit();
            u.character = new Character();
            u.character.monsterStats = new MonsterCharacter();
            u.character.monsterStats.ID = MobsID;
            u.character.monsterStats.monsterStats = Mob;
            // set the hardness here for now HACK
            u.character.monsterStats.CurrentLevel = 10;
            u.IsEnemyUnit = true;
            u.Start();
            string skillString = u.character.monsterStats.monsterStats._Skills;
            string[] mobSkills = skillString.Split(',');
            foreach (var skillPair in mobSkills)
            {
                string[] skillParts = skillPair.Split(':');
                int logic = int.Parse(skillParts[0]);
                int skill = int.Parse(skillParts[1]);
                u.aiActions.Add(Gambits.GetGambit(logic));
                u.aiSkills.Add(new Skill(skill));
            }

            string modelName = Mob._SpriteIdle;
            GameObject go = Instantiate(Resources.Load("EnemyPrefabs/" + modelName)) as GameObject;
            go.transform.SetParent(MonstersUnitsSpritePositions[i].transform);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one * 100;
            go.name = Mob._SpriteIdle; 
            go.GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(Mob._SpriteIdle);

            u.sprite = go;
            MonstersUnitsSprite.Add(go);

            AllUnits.Add(u);
        }
    }

    void UpdatePlayerControls()
    {
        List<PlayerCharacter> playerCharacters = DataManager.instance.userData.listOfTeams[DataManager.instance.selectedTeam].GetListOfCharacters();
        for (int i = 0; i < DataManager.MAXUNITPERTEAM; i++)
        {           
            PlayerButtons[i].GetComponent<BattleButtonScript>().UpdateGUI(PlayerUnits[i]);
        }
    }

    public bool BypassAnimationLock = false;
    public bool AnimationLock = false;

    public void ReleaseAnimationLock()
    {
        AnimationLock = false;
    }

    public void BackToMenu()
    {
        SceneManager.instance.NextSceneName = "MainMenu";
    }

    // start Game button clicked from UI
    int counter = 0;
    public void ButtonStartGameClicked()
    {
        ++counter;
        if (NumPlayerSpawn == counter)
        { 
            GameNotStarted = false;
            StartGamePopup.SetActive(false);
        }
    }

    int UnitOrderCounter = 0;
    bool HasWon = false;
    bool HasLost = false;
    bool GameNotStarted = true;
    // Update is called once per frame
    void Update ()
    {
        // if waiting for animation or user input..
        if ((AnimationLock && !BypassAnimationLock) || HasWon || HasLost || GameNotStarted)
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
            Debug.Log("Turn:" + UnitOrderCounter.ToString());
            
            if (currentUnit.IsEnemyUnit)
            {
                ExecuteGambits(ref currentUnit);
                ++UnitOrderCounter;
            }
            else
            {
                if (AutoMode)
                {
                    ExecuteGambits(ref currentUnit);
                    ++UnitOrderCounter;
                }
                else
                {
                    // wait for user input - have a que system so that we can "bot" user commands
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
            go.GetComponent<ItemDropScript>().SetupItem(ItemThatDropped);

            ItemThatDropped.sprite = go;
            ListOfItemsThatDropped.Add(ItemThatDropped);
            Debug.Log("LegitItem");
        }
        
    }

    private void ExecuteGambits(ref Unit currentUnit)
    {
        if (currentUnit.isDead)
            return;
        
        //evaulate gambits
        for (int i = 0; i < DataManager.MAXGAMBITCOUNT; i++)
        {
            if (i >= currentUnit.aiActions.Count)
                return;

            List<Unit> unitsAffected = currentUnit.aiActions[i].EvaluateThis(ref currentUnit, ref AllUnits);
            if (unitsAffected != null && unitsAffected.Count > 0)
            {
                // to do - change this to the proper animation
                currentUnit.sprite.GetComponentInChildren<SpriteAnimation>().LoadEnemyAttack("Swordman_Casting");
                Debug.Log("Execute Gambit");
                for (int j = 0; j < unitsAffected.Count; j++)
                {
                    Unit ounit = unitsAffected[j];
                    ounit.sprite.transform.DOPunchPosition(new Vector3(Random.Range(-15, 15), Random.Range(-15, 15), 0), DataManager.LONGANIMATION);
                    AnimationLock = currentUnit.aiSkills[i].EvaluateSkillEffect(ref currentUnit, ref ounit);

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
                UpdatePlayerControls();
                return;
            }
        }
    }


}
