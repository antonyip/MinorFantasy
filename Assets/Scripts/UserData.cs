using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public interface Compressable
{
    string Compress();
    void Decompress(string deString);
}

public class UserDataContainer : Compressable
{
    public UserData userData;

    public string Compress()
    {
        string compressString =  userData.Compress();
        Debug.Log("CompressString:" + compressString);
        return compressString;
    }

    public void Decompress(string deString)
    {
        userData = new UserData();
        userData.Decompress(deString);
    }
}

public class UserData : Compressable
{
    public int Gold;
    public int Gems;
    public int Energy;
    public int MaxEnergy;
    public int PvpEnergy;
    public float MAPBONUSMULTIPLIER;

    // stored as an index to the database
    public GambitContainer ListOfGambits = new GambitContainer();
    public List<int> ListOfCraftingMats = new List<int>();
    public List<int> ListOfEquipment = new List<int>();

    public List<Team> listOfTeams = new List<Team>();
    public List<PlayerCharacter> listOfPlayerCharacters = new List<PlayerCharacter>();

    public UserData()
    {
        Gold = 50000;
        Gems = 500;
        Energy = 50;
        MaxEnergy = 50;
        PvpEnergy = 5;
        MAPBONUSMULTIPLIER = 1.0f;

        while (listOfTeams.Count < DataManager.MAXTEAM)
        {
            listOfTeams.Add(new Team());
        }
    }

    public string Compress()
    {
        var returnValue = JSON.Parse("{}");
        returnValue["Gold"]                   = Gold.ToString();
        returnValue["Gems"]                   = Gems.ToString();
        returnValue["Energy"]                 = Energy.ToString();
        returnValue["MaxEnergy"]              = MaxEnergy.ToString();
        returnValue["PvpEnergy"]              = PvpEnergy.ToString();
        returnValue["ListOfGambits"]          = ListOfGambits.Compress();

        for (int i = 0; i < listOfTeams.Count; i++)
        {
            returnValue["Teams"][-1] = listOfTeams[i].Compress();
        }

        for (int i = 0; i < listOfPlayerCharacters.Count; i++)
        {
            returnValue["PC"][-1] = listOfPlayerCharacters[i].Compress();
        }


        return returnValue.ToString();
    }

    public void Decompress(string deString)
    {
        var returnValue = JSON.Parse(deString);
        if (returnValue["Gold"] != null)                   Gold      = returnValue["Gold"].AsInt;
        if (returnValue["Gems"] != null)                   Gems      = returnValue["Gems"].AsInt;
        if (returnValue["Energy"] != null)                 Energy    = returnValue["Energy"].AsInt;
        if (returnValue["MaxEnergy"] != null)              MaxEnergy = returnValue["MaxEnergy"].AsInt;
        if (returnValue["ListOfGambits"] != null)          ListOfGambits.Decompress(returnValue["ListOfGambits"].Value);

        listOfTeams.Clear();
        if (returnValue["Teams"] != null)
        {
            int counter = 0;
            while (returnValue["Teams"][counter] != null)
            {
                Team t = new Team();
                t.Decompress(returnValue["Teams"][counter]);
                listOfTeams.Add(t);
                ++counter;
            }

            while (counter < DataManager.MAXTEAM)
            {
                Team t = new Team();
                listOfTeams.Add(t);
                ++counter;
            }
        }

        listOfPlayerCharacters.Clear();
        if (returnValue["PC"] != null)
        {
            int counter = 0;
            while (returnValue["PC"][counter] != null)
            {
                PlayerCharacter pc = new PlayerCharacter();
                pc.Decompress(returnValue["PC"][counter]);
                listOfPlayerCharacters.Add(pc);
                ++counter;
            }
        }

    }
}
