using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSelectManagerScript : MonoBehaviour {

    public List<GameObject> ListOfButtons;
	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < ListOfButtons.Count; i++)
        {
            ListOfButtons[i].GetComponent<LevelSelectButtonScript>().SetName((i+1).ToString());
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
