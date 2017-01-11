using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using DG.Tweening;

public class GameMaster : MonoBehaviour {

    public static GameMaster instance;
    List<Unit> AllUnits = new List<Unit>();
    public GameObject monsterPrefab;
    public List<GameObject> PlayerUnitsSpritePositions = new List<GameObject>();
    public List<GameObject> PlayerUnitsSprite = new List<GameObject>();
    public List<GameObject> MonstersUnitsSpritePositions = new List<GameObject>();
    public List<GameObject> MonstersUnitsSprite = new List<GameObject>();
    public List<GameObject> OptionButtons = new List<GameObject>();
    public List<GameObject> PlayerButtons = new List<GameObject>();

    // gamelists
    public GameObject Announcer;
    public GameObject StartGamePopup;
    public GameObject VictoryPopup;
    bool AutoMode = true;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {

        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);

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

        for (int i = 0; i < dataManager.userData.listOfTeams[dataManager.selectedTeam].GetListOfCharacters().Count; i++)
        {
            var playerChar = dataManager.userData.listOfTeams[dataManager.selectedTeam].GetListOfCharacters()[i];

            // skip id 0 as it is an empty spot
            if (playerChar.ID == 0)
                continue;
            
            Unit u = new Unit();
            u.character = new Character();
            u.character.playerStats = playerChar;
            u.character.playerStats.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == playerChar.ID);
            u.IsEnemyUnit = false;
            u.Start();

            u.aiActions.Add(Gambits.GetGambit(1));
            u.aiSkills.Add(new Skill(1));

            GameObject go = Instantiate(monsterPrefab) as GameObject;
            go.transform.SetParent(PlayerUnitsSpritePositions[i].transform);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            go.name = u.character.playerStats.databaseChar._SpriteIdle;
            go.GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(go.name);

            u.sprite = go;
            PlayerUnitsSprite.Add(go);

            AllUnits.Add(u);
        }

        // load enemy data
        var Map = Google2u.LevelData.Instance.Rows.Find(x => x._ID == dataManager.selectedMapLevel);
        List<string> MobsToSpawn = new List<string>();

        if (Map._Battle1.Contains(','))
            MobsToSpawn = Map._Battle1.Split(',').ToList();
        else
            MobsToSpawn.Add(Map._Battle1);

        for (int i = 0; i < MobsToSpawn.Count; i++)
        {
            var item = MobsToSpawn[i];
            var MobsID = int.Parse(item);
            var Mob = Google2u.MobData.Instance.Rows.Find(x => x._ID == MobsID);
            Unit u = new Unit();
            u.character = new Character();
            u.character.monsterStats = Mob;
            u.IsEnemyUnit = true;
            u.Start();
            string skillString = u.character.monsterStats._Skills;
            string[] mobSkills = skillString.Split(',');
            foreach (var skillPair in mobSkills)
            {
                string[] skillParts = skillPair.Split(':');
                int logic = int.Parse(skillParts[0]);
                int skill = int.Parse(skillParts[1]);
                u.aiActions.Add(Gambits.GetGambit(logic));
                u.aiSkills.Add(new Skill(skill));
            }

            string modelName = "DustBunny";
            GameObject go = Instantiate(Resources.Load("EnemyPrefabs/" + modelName)) as GameObject;
            //GameObject go = Instantiate(monsterPrefab) as GameObject;
            go.transform.SetParent(MonstersUnitsSpritePositions[i].transform);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one * 100;
            go.name = Mob._SpriteIdle; 
            //go.GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(Mob._SpriteIdle);

            u.sprite = go;
            MonstersUnitsSprite.Add(go);

            AllUnits.Add(u);
        }

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
    public void ButtonStartGameClicked()
    {
        GameNotStarted = false;
        StartGamePopup.SetActive(false);
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
            Debug.Log("You won!");
            VictoryPopup.SetActive(true);
            return;
        }
        
        var PlayerUnits = AllUnits.FindAll(x => x.IsEnemyUnit == false && !x.isDead);

        if (PlayerUnits.Count == 0)
        {
            HasLost = true;
            Debug.Log("You lost!");
            VictoryPopup.SetActive(true);
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

    private void ExecuteGambits(ref Unit currentUnit)
    {
        //evaulate gambits
        for (int i = 0; i < 10; i++)
        {
            if (i >= currentUnit.aiActions.Count)
                return;

            List<Unit> unitsAffected = currentUnit.aiActions[i].EvaluateThis(ref currentUnit, ref AllUnits);
            if (unitsAffected != null && unitsAffected.Count > 0)
            {
                // to do - change this to the proper animation
                currentUnit.sprite.GetComponentInChildren<SpriteAnimation>().LoadEnemyAttack("Swordman_Casting");
                Debug.Log("Execute Gambit");
                foreach (var unit in unitsAffected)
                {
                    var ounit = unit;
                    ounit.sprite.transform.DOPunchPosition(new Vector3(Random.Range(-25,25), Random.Range(15, 15), 0), DataManager.LONGANIMATION);
                    AnimationLock = currentUnit.aiSkills[i].EvaluateSkillEffect(ref currentUnit, ref ounit);
                }
                return;
            }
        }
    }
}
