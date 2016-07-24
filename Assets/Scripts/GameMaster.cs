using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMaster : MonoBehaviour {

    List<Unit> AllUnits = new List<Unit>();
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
            AllUnits.Add(u);
        }
        
        // load enemy data

        Debug.Log("Determining Speed Que");
        // 2. start fight
        // determine order of attacks by all not null players
        // place them in a que
        // start the que


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
