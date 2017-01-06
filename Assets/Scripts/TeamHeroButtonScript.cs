using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TeamHeroButtonScript : MonoBehaviour {

    public int ID;
    public Image FaceImage;
    public Image ClassImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetID(int id)
    {
        ID = id;
    }

    public void OnClicked()
    {
        //Debug.Log(ID);
        PreBattleSceneManagerScript.instance.TeamHeroButtonClicked(ID);
    }
}
