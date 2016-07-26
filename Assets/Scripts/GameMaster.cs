using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class GameMaster : MonoBehaviour {

    List<Unit> AllUnits = new List<Unit>();
    public GameObject monsterPrefab;
    public List<GameObject> PlayerUnitsSpritePositions = new List<GameObject>();
    public List<GameObject> PlayerUnitsSprite = new List<GameObject>();
    public List<GameObject> MonstersUnitsSpritePositions = new List<GameObject>();
    public List<GameObject> MonstersUnitsSprite = new List<GameObject>();
    public List<GameObject> OptionButtons = new List<GameObject>();
    public List<GameObject> PlayerButtons = new List<GameObject>();
    public GameObject Announcer;
    bool AutoMode = false;

    // Use this for initialization
    void Start () {


        // 0. setup playing field
        OptionButtons[0].GetComponentInChildren<Text>().text = "Auto";
        OptionButtons[1].GetComponentInChildren<Text>().text = "Tactics";
        OptionButtons[2].GetComponentInChildren<Text>().text = "Options";

        Debug.Log("GameStarted");
        Debug.Log("Loading Fight Data");
        // 1. load fight data
        // load player data
        var dataManager = DataManager.instance;
        foreach (var playerChar in dataManager.listOfTeams[dataManager.selectedTeam].GetListOfCharacters())
        {
            Unit u = new Unit();
            u.character = new Character();
            u.character.playerStats = playerChar;
            u.character.playerStats.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == playerChar.ID);
            u.IsEnemyUnit = false;
            AllUnits.Add(u);
        }

        // load enemy data
        //var Map = Google2u.LevelData.Instance.Rows.Find(x => x._ID == dataManager.selectedMap);
        var Map = Google2u.LevelData.Instance.Rows.Find(x => x._ID == 1);
        string[] MobsToSpawn = Map._Battle1.Split(',');

        for (int i = 0; i < MobsToSpawn.Length; i++)
        {
            var item = MobsToSpawn[i];
            var MobsID = int.Parse(item);
            var Mob = Google2u.MobData.Instance.Rows.Find(x => x._ID == MobsID);
            Unit u = new Unit();
            u.character = new Character();
            u.character.monsterStats = Mob;
            u.IsEnemyUnit = true;
            string skillString = u.character.monsterStats._Skills;
            string[] mobSkills = skillString.Split(',');
            foreach (var skillPair in mobSkills)
            {
                string[] skillParts = skillPair.Split(':');
                int logic = int.Parse(skillParts[0]);
                int skill = int.Parse(skillParts[1]);
                u.aiActions.Add(Gambits.AllGambits[logic].Clone());
                u.aiSkills.Add(new Skill(skill));
            }
            
            AllUnits.Add(u);

            GameObject go = Instantiate(monsterPrefab) as GameObject;
            go.transform.SetParent(MonstersUnitsSpritePositions[i].transform);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            go.name = Mob._SpriteIdle;
            go.GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(Mob._SpriteIdle);
            MonstersUnitsSprite.Add(go);
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
    bool animationLock = false;
    public void ReleaseAnimationLock()
    {
        animationLock = false;
    }

    int UnitOrderCounter = 0;
	// Update is called once per frame
	void Update ()
    {
        // if waiting for animation or user input..
        if (animationLock)
        {
            return;
        }

        // grab first person in que.
        Unit currentUnit = AllUnits[UnitOrderCounter % AllUnits.Count];
        if (currentUnit != null)
        {
            //Debug.Log("Evalulating:" + UnitOrderCounter.ToString() + "");
            ++UnitOrderCounter;
            
            if (currentUnit.IsEnemyUnit)
            {
                for (int i = 0; i < 10; i++)
                {
                    
                }
                // logic is wrong, need to re-work how to pass data to the ai unit
                // currentUnit.aiBase.refAIUnit.GoThroughAILogics();
            }
            else
            {
                if (AutoMode)
                {
                    //evaulate gambits
                    // logic is wrong, need to re-work how to pass data to the ai unit
                    //currentUnit.aiBase.refAIUnit.GoThroughAILogics();
                }
                else
                {
                    // wait for user input - have a que system so that we can "bot" user commands
                }
            }
            
            // start the effects show.

        } // endif currentUnit != null

    } // end update
}
