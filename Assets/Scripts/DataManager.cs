using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Google2u;

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


    public static List<int> CurrentHeroesOdds = new List<int>();

    public const string BYPASSUSERLOAD = "BYPASSUSERLOAD";

    // static data
    public static DataManager instance = null;

    // datamanager data
    public bool LOADEDUSER = false;
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadUser(string UniqueUserName)
    {
        if (LOADEDUSER == false)
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
                pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
                userData.listOfPlayerCharacters.Add(pc);
            }

            // insert random special character for last pc
            pc = new PlayerCharacter();
            pc.ID = 3;
            pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
            userData.listOfPlayerCharacters.Add(pc);

            // insert random for last 8
            for (int i = 0; i < 8; i++)
            {
                pc = new PlayerCharacter();
                pc.ID = 1;
                pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
                userData.listOfPlayerCharacters.Add(pc);
            }

            Debug.Assert(userData != null);
            Debug.Assert(userData.listOfTeams != null);

            userData.listOfTeams[0].SwapCharacter(0, 0);
            userData.listOfTeams[0].SwapCharacter(1, 1);
            userData.listOfTeams[0].SwapCharacter(2, 4);
            userData.listOfTeams[0].SwapCharacter(3, 2);
            userData.listOfTeams[0].SwapCharacter(5, 8);

            LOADEDUSER = true;
        }

        if (UniqueUserName == DataManager.BYPASSUSERLOAD)
        {
            PlayerIOManager.instance.BypassLogin();
        }
    }

}
