using UnityEngine;
using System.Collections.Generic;
using SimpleJSON;

public class Team : Compressable
{


    public string Compress()
    {
        var returnValue = JSON.Parse("{}");
        for (int i = 0; i < listOfCharacters.Count; i++)
        {
            returnValue["TeamMembers"][-1] = listOfCharacters[i].ToString();
        }
        
        return returnValue.ToString();
    }

    public void Decompress(string deString)
    {
        var json = JSON.Parse(deString);
        int counter = 0;
        listOfCharacters.Clear();
        while (json["TeamMembers"][counter] != null)
        {
            listOfCharacters.Add(json["TeamMembers"][counter].AsInt);
            ++counter;
        }
    }

    public const int EMPTYSLOT = -1;

    // indexes to userdata team
    List<int> listOfCharacters = new List<int>();

    public Team()
    {
        while (listOfCharacters.Count < DataManager.MAXUNITPERTEAM)
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
