using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMaster : MonoBehaviour {

    List<Unit> AllUnits = new List<Unit>();
    public List<GameObject> MonstersUnitsSprite = new List<GameObject>();
    bool AutoMode = false;

    // Use this for initialization
    void Start () {

        Debug.Log("GameStarted");
        Debug.Log("Loading Fight Data");
        // 1. load fight data
        // load player data
        var dataManager = DataManager.instance;
        foreach (var character in dataManager.listOfTeams[dataManager.selectedTeam].GetListOfCharacters())
        {
            Unit u = new Unit();
            u.character = character;
            u.IsEnemyUnit = false;
            AllUnits.Add(u);
        }

        // load enemy data
        for (int i = 0; i < dataManager.MonsterForThisRound.Count; i++)
        {
            Unit u = new Unit();
            u.character = dataManager.MonsterForThisRound[i];
            u.IsEnemyUnit = true;
            AllUnits.Add(u);
        }

        Debug.Log("Determining Speed Que");
        // 2. start fight
        // determine order of attacks by all not null players
        // place them in a que
        // start the que


    } //end start
	
	// Update is called once per frame
	void Update ()
    {
        // if waiting for animation or user input..
        if (false)
        {
            return;
        }

        // grab first person in que.
        Unit currentUnit = null;
        if (currentUnit != null)
        {
            if (currentUnit.IsEnemyUnit)
            {
                // logic is wrong, need to re-work how to pass data to the ai unit
                currentUnit.aiBase.refAIUnit.GoThroughAILogics(); 
            }
            else
            {
                if (AutoMode)
                {
                    //evaulate gambits
                    // logic is wrong, need to re-work how to pass data to the ai unit
                    currentUnit.aiBase.refAIUnit.GoThroughAILogics();
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
