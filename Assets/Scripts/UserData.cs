using System.Collections.Generic;

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
}
