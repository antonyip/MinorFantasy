using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;

public class PreBattleSceneManagerScript : MonoBehaviour {

    public List<GameObject> CurrentTeam;
    public List<GameObject> TeamButtons;
    public GameObject MainTeamContainer;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < TeamButtons.Count; i++)
        {
            TeamButtons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
        }

        var dataManager = DataManager.instance;
        for (int i = 0; i < dataManager.listOfTeams[dataManager.selectedTeam].GetListOfCharacters().Count; i++)
        {
            var playerChar = dataManager.listOfTeams[dataManager.selectedTeam].GetListOfCharacters()[i];

            // skip id 0 as it is an empty spot
            if (playerChar.ID == 0)
                continue;

            // todo change face
            // todo handle swapping mechanics of teams
            // remember to handle different team members
            // IDEA handle energy in teams?
        }
	}

    public void SelectTeam(int i)
    {
        Debug.Log(i + " team selected!");
        DataManager.instance.selectedTeam = i;
        MainTeamContainer.transform.transform.DOLocalMoveX(i * -1550, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToBattleScene()
    {
        SceneManager.instance.NextSceneName = "BattleScene";
    }
}
