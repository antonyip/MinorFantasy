using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TeamContainerScript : MonoBehaviour {

    public int StartID;
    public List<TeamHeroButtonScript> ListOfButtons;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < ListOfButtons.Count; i++)
        {
            ListOfButtons[i].SetID(StartID + i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
