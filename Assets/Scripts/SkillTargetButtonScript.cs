using UnityEngine;
using System.Collections;

public class SkillTargetButtonScript : MonoBehaviour {

    int ID;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SkillButtonPressed()
    {
        GameMaster.instance.SkillButtonPressed(ID);
    }
}
