using System.Collections.Generic;

public class UserData
{
    public int gold;
    public int gems;
    public int energy;
    public int pvpenergy;

    public List<int> ListOfGambits = new List<int>();
    public List<int> ListOfCraftingMats = new List<int>();
    public List<int> ListOfEquipment = new List<int>();

    public List<Team> listOfTeams = new List<Team>();
    public List<PlayerCharacter> listOfPlayerCharacters = new List<PlayerCharacter>();

    public UserData()
    {
        gold = 0;
        gems = 0;
        energy = 0;
        pvpenergy = 0;
    }
}
