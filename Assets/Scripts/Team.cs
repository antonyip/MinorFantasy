using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

[System.Serializable]
public class Team {

    public const int EMPTYSLOT = -1;

    // indexes to userdata team
    List<int> listOfCharacters = new List<int>();

    public List<int> S_ListOfCharacters
    {
        get { return listOfCharacters; }
        set { listOfCharacters = value; }
    }

    public Team()
    {
        while (listOfCharacters.Count < 6)
        {
            listOfCharacters.Add(EMPTYSLOT);
        }
    }

    public List<int> GetListOfIndexes()
    {
        return listOfCharacters;
    }

    public List<PlayerCharacter> GetListOfCharacters()
    {
        List<PlayerCharacter> returnValue = new List<PlayerCharacter>();
        List<PlayerCharacter> listOfPC = DataManager.instance.userData.listOfPlayerCharacters;
        for (int i = 0; i < DataManager.MAXUNITPERTEAM; i++)
        {
            if (listOfCharacters[i] == EMPTYSLOT)
            {
                returnValue.Add(null);
            }
            else
            {
                Debug.Assert(listOfCharacters.Count == DataManager.MAXUNITPERTEAM);
                returnValue.Add(listOfPC[listOfCharacters[i]]);
            }

        }
        return returnValue;
    }

    public void SwapCharacter(int index, int PlayerIndexInUserData)
    {
        listOfCharacters[index] = PlayerIndexInUserData;
    }

    internal int FindCharacterIndexInTeam(int IndexOfHeroInGlobalContainer)
    {
        for (int i = 0; i < listOfCharacters.Count; i++)
        {
            if (listOfCharacters[i] == IndexOfHeroInGlobalContainer)
                return i;
        }
        return -1;
        
    }
}
