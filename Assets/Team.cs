using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Team {

    List<Character> listOfCharacters = new List<Character>();

    public List<Character> GetListOfCharacters()
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

    public void SwapCharacter(int v, Character p)
    {
        if (listOfCharacters.Count < 6)
        {
            for (int i = 0; i < 6; i++)
            {
                listOfCharacters.Add(new Character());
            }
        }

        listOfCharacters[v] = p;
    }
}
