using UnityEngine;
using System.Collections;

public class ReserveHeroButtonScript : MonoBehaviour {

    public int ID;
    public int POS;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetupGUI(int pos)
    {
        Debug.Log("setting up reserve: " + pos);
        POS = pos;
        ID = DataManager.instance.userData.listOfPlayerCharacters[pos].ID;
    }

    public void OnClick()
    {
        Debug.Log("Reserve Button Clicked: " +POS + " -- "+ ID);
        PreBattleSceneManagerScript.instance.ReservedHeroButtonClicked(ID);
    }

}
