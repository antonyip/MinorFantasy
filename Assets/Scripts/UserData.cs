using System.Collections.Generic;
using UnityEngine;

public class UserData
{
    public int gold;
    public int gems;
    public int energy;
    public int maxEnergy;
    public int pvpEnergy;
    public float MAPBONUSMULTIPLIER;

    public List<int> ListOfGambits = new List<int>();
    public List<int> ListOfCraftingMats = new List<int>();
    public List<int> ListOfEquipment = new List<int>();

    public List<Team> listOfTeams = new List<Team>();
    public List<PlayerCharacter> listOfPlayerCharacters = new List<PlayerCharacter>();

    public UserData()
    {
        gold = 50000;
        gems = 2000;
        energy = 50;
        maxEnergy = 50;
        pvpEnergy = 0;
        MAPBONUSMULTIPLIER = 1.0f;
    }

    public string Compress()
    {
        string returnValue = "v1=";

        // gold
        returnValue += "{g:" + gold.ToString() + ":g}";

        // gem
        returnValue += "{h:" + gems.ToString() + ":h}";

        // energy
        returnValue += "{i:" + energy.ToString() + ":i}";

        //pvp
        returnValue += "{p:" + pvpEnergy.ToString() + ":p}";

        //teams
        returnValue += "{tt:";
        for (int i = 0; i < listOfTeams.Count; i++)
        {
            returnValue += "{t:";
            for (int j = 0; j < listOfTeams[i].GetListOfIndexes().Count; j++)
            {
                returnValue += listOfTeams[i].GetListOfIndexes()[j].ToString();
                returnValue += "=";
            }
            returnValue += ":t}";
        }
        returnValue += ":tt}";

        // PlayerCharacters
        returnValue += "{yy:";
        for (int i = 0; i < listOfPlayerCharacters.Count; i++)
        {
            returnValue += "{y:";
            returnValue += listOfPlayerCharacters[i].ID + "=";
            returnValue += listOfPlayerCharacters[i].CurrentLevel + "=";
            returnValue += ":y}";
        }
        returnValue += ":yy}";

        return returnValue;
    }

    public void Decompress(string deString)
    {
        DecompressInt(deString, "g", out gold);
        DecompressInt(deString, "h", out gems);
        DecompressInt(deString, "i", out energy);
        DecompressInt(deString, "p", out pvpEnergy);

        // PlayerCharacters
        string pc;
        DecompressString(deString, "yy", out pc);
        string[] pcSpilt = pc.Split('{');
        listOfPlayerCharacters.Clear();

        // one because first token is a ""
        for (int i = 1; i < pcSpilt.Length; i++)
        {
            string pcstring = "{" + pcSpilt[i];
            string pcStringExtracted;
            DecompressString(pcstring, "y", out pcStringExtracted);

            Debug.Log("pse: " + pcStringExtracted);
            string[] arrayOfNumbers = pcStringExtracted.Split('=');

            
            for (int j = 0; j < arrayOfNumbers.Length; j += 2)
            {
                if (!string.IsNullOrEmpty(arrayOfNumbers[j]))
                {
                    var playerChar = new PlayerCharacter();
                    playerChar.ID = int.Parse(arrayOfNumbers[j]);
                    playerChar.CurrentLevel = int.Parse(arrayOfNumbers[j + 1]);
                    playerChar.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == playerChar.ID);
                    listOfPlayerCharacters.Add(playerChar);
                }
            }
        }

        // Teams
        string teams;
        DecompressString(deString, "tt", out teams);
        string[] teamsSpilt = teams.Split('{');
        listOfTeams.Clear();

        // one because first token is a ""
        for (int i = 1; i < teamsSpilt.Length; i++)
        {
            string teamstring = "{" + teamsSpilt[i];
            //Debug.Log("ts:" + teamstring);
            string teamStringExtracted;
            DecompressString(teamstring, "t", out teamStringExtracted);
            //Debug.Log("tse:" + teamStringExtracted);
            string[] arrayOfNumbers = teamStringExtracted.Split('=');

            listOfTeams.Add(new Team());
            for (int j = 0; j < arrayOfNumbers.Length; j++)
            {
                if (!string.IsNullOrEmpty(arrayOfNumbers[j]))
                { 
                    //Debug.Log(arrayOfNumbers[j]);
                    int teamIndex = int.Parse(arrayOfNumbers[j]);
                    //Debug.Log(teamIndex);
                    //because loop starts from 1
                    listOfTeams[i-1].SwapCharacter(j, teamIndex);
                }
            }
        }
    }

    void DecompressString(string originalString, string token, out string returnValue)
    {
        string value = "";
        if (originalString.Contains("{"+ token + ":"))
        {
            string tokenToFind = "{"+token+":";
            int StartPos = originalString.IndexOf(tokenToFind);
            int EndPos = originalString.IndexOf(":"+ token + "}", StartPos);
            int len = EndPos - (StartPos + 2 + token.Length);
            value = originalString.Substring(StartPos + 2 + token.Length, len);
        }
        else
        {
            Debug.LogError("Fail to parse:" + token);
        }
        returnValue = value;
    }

    void DecompressInt(string originalString, string token, out int returnValue)
    {
        int value = 0;
        if (originalString.Contains("{" + token + ":"))
        {
            string tokenToFind = "{" + token + ":";
            int StartPos = originalString.IndexOf(tokenToFind);
            int EndPos = originalString.IndexOf(":" + token + "}", StartPos);
            int len = EndPos - (StartPos + 2 + token.Length);
            bool success = int.TryParse(originalString.Substring(StartPos + 2 + token.Length, len), out value);

            if (!success)
            {
                Debug.LogError("Fail to parse on tryparse:" + token);
            }
        }
        else
        {
            Debug.LogError("Fail to parse missing toekn:" + token);
        }
        returnValue = value;
    }
}
