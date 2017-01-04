using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Team {

    List<PlayerCharacter> listOfCharacters = new List<PlayerCharacter>();

    public List<PlayerCharacter> GetListOfCharacters()
    {
        return listOfCharacters;
    }

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SwapCharacter(int v, PlayerCharacter p)
    {
        if (listOfCharacters.Count < 6)
        {
            for (int i = 0; i < 6; i++)
            {
                PlayerCharacter pc = new PlayerCharacter();
                pc.ID = 0;
                listOfCharacters.Add(pc);
            }
        }

        listOfCharacters[v] = p;
    }
}
