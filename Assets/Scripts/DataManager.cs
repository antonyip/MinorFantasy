using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SummonPageSetting
{
    NONE,
    HEROES,
    GAMBITS,
    CRAFTING,
    EQUIPMENT,
};

public enum PreBattlePage
{
    NONE,
    MANAGEHEROES,
    PREBATTLE,
}

public class DataManager : MonoBehaviour
{

    // consts
    public const int MAXTEAM = 5;
    public const int MAXUNITPERTEAM = 6;
    public const float NORMALANIMATION = 0.3f;
    public const float LONGANIMATION = 0.7f;
    public const float BASEDROPCHANCE = 0.5f;
    public const float BASERAREDROP = 0.55f;
    public const float BASELEGENDDROP = 0.85f;
    public const int MAXGAMBITCOUNT = 10;

    public const int GoldForSummoningHeroes = 5000;
    public const int GemForSummoningHeroes = 45;
    public const int GoldForSummoningHeroes10 = 45000;
    public const int GemForSummoningHeroes10 = 400;

    public const int GoldForSummoningGambit = 5000;
    public const int GemForSummoningGambit = 45;
    public const int GoldForSummoningGambit10 = 45000;
    public const int GemForSummoningGambit10 = 400;


    public static List<int> CurrentHeroesOdds = new List<int>();
    public static List<int> CurrentGambitOdds = new List<int>();

    public const string BYPASSUSERLOAD = "BYPASSUSERLOAD";

    // static data
    public static DataManager instance = null;

    // datamanager data
    public int selectedTeam = 0;
    public int selectedMapLevel = 0;

    public LevelData selectedLevel;
    public SummonPageSetting SummonPageSettings = SummonPageSetting.NONE;
    public PreBattlePage PreBattlePageSettings = PreBattlePage.NONE;
    public UserData userData;


    public List<LevelData> listOfLevels;
    public List<Sprite> listOfFloorTiles;
    public List<Sprite> listOfBackgrounds;
    public List<Sprite> listOfPlayers;

    // battle selection


    void GenerateEmptyTeamStructure()
    {
        for (int i = 0; i < MAXTEAM; i++)
        {
            Team t = new Team();
            userData.listOfTeams.Add(t);
        }
    }

    void Awake()
    {
        Debug.Log("InitDataManager");

        if (instance == null)
        {
            instance = this;
            StartHacks();
        }
        else
        {
            Debug.Log("attempt to generate 2nd datamanager?");
        }
    }

    // Use this for initialization hacks
    void StartHacks()
    {
        // hack to generate current odds for hero summon pool
        for (int i = 0; i < 5; i++)
        {
            CurrentHeroesOdds.Add(1);
            CurrentHeroesOdds.Add(2);
            CurrentHeroesOdds.Add(3);
            CurrentHeroesOdds.Add(4);
            CurrentHeroesOdds.Add(5);
        }

        // hack to generate current odds for hero summon pool
        for (int i = 0; i < 5; i++)
        {
            CurrentGambitOdds.Add(1);
            CurrentGambitOdds.Add(2);
            CurrentGambitOdds.Add(3);
            CurrentGambitOdds.Add(4);
            CurrentGambitOdds.Add(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadUser(string UniqueUserName)
    {
        Debug.Log("LoadableString:" + UniqueUserName); // LoadingString;
        Debug.Log("Already Logged In?" + PlayerIOManager.instance.LoggedIn); // LoadingString;
        if (PlayerIOManager.instance.LoggedIn == true && UniqueUserName != DataManager.BYPASSUSERLOAD) // normal loading goes here
        {
            Debug.Log("Decompressing");
            UserDataContainer udc = new UserDataContainer();
            udc.Decompress(UniqueUserName);
            userData = udc.userData;
        }
        // hacks for debugging
        else if (PlayerIOManager.instance.LoggedIn == false && UniqueUserName == DataManager.BYPASSUSERLOAD)
        {
            userData = new UserData();
            GenerateEmptyTeamStructure();

            Debug.Log("Loading UserData from our database::TODO");
            // insert unique pc for first 4.
            PlayerCharacter pc;
            for (int i = 0; i < 4; i++)
            {
                pc = new PlayerCharacter();
                pc.ID = (i+1) * 2;
                pc.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == pc.ID);
                pc.CurrentGambits[0] = 0;
                pc.CurrentSkills[0] = 1;
                userData.listOfPlayerCharacters.Add(pc);
            }

            // insert random special character for last pc
            pc = new PlayerCharacter();
            pc.ID = 3;
            pc.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == pc.ID);
            pc.CurrentGambits[0] = 0;
            pc.CurrentSkills[0] = 1;
            userData.listOfPlayerCharacters.Add(pc);

            // insert random for last 8
            for (int i = 0; i < 8; i++)
            {
                pc = new PlayerCharacter();
                pc.ID = 1;
                pc.CurrentGambits[0] = 0;
                pc.CurrentSkills[0] = 1;
                pc.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == pc.ID);
                userData.listOfPlayerCharacters.Add(pc);
            }

            Debug.Assert(userData != null);
            Debug.Assert(userData.listOfTeams != null);

            userData.listOfTeams[0].SwapCharacter(0, 0);
            userData.listOfTeams[0].SwapCharacter(1, 1);
            userData.listOfTeams[0].SwapCharacter(2, 4);
            userData.listOfTeams[0].SwapCharacter(3, 2);
            userData.listOfTeams[0].SwapCharacter(5, 8);

            userData.ListOfGambits.Add(new Gambit(1));
            userData.ListOfGambits.Add(new Gambit(2));
            userData.ListOfGambits.Add(new Gambit(3));
            userData.ListOfGambits.Add(new Gambit(4));
            userData.ListOfGambits.Add(new Gambit(5));

            PlayerIOManager.instance.BypassLogin();
        }
    }

}
