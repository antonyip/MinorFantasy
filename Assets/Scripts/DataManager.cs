using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Google2u;

public class DataManager : MonoBehaviour {

    // consts
    public const int MAXTEAM = 5;
    public const int MAXUNITPERTEAM = 6;
    public static bool LOADEDUSER = false;

    // static data
	public static DataManager instance;

    // datamanager data
	public LevelData selectedLevel;

	public List<LevelData> listOfLevels;
	public List<Sprite> listOfFloorTiles;
	public List<Sprite> listOfBackgrounds;
	public List<Sprite> listOfPlayers;

    // battle selection
    public List<Team> listOfTeams = new List<Team>();
    public int selectedTeam = 0;
    public int selectedMap = 0;
    public int selectedMapLevel = 0;

    public List<PlayerCharacter> listOfPlayerCharacters = new List<PlayerCharacter>();

	void Awake()
	{
        Debug.Log("InitDataManager");

        for (int i = 0; i < MAXTEAM; i++)
        {
            Team t = new Team();
            for (int j = 0; j < MAXUNITPERTEAM; j++)
            {
                PlayerCharacter pc = new PlayerCharacter();
                pc.ID = 0;
                pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
                t.SwapCharacter(j, pc);
            }
            listOfTeams.Add(t);
        }

        instance = this;
	}

	// Use this for initialization
	void Start ()
	{

    }
	
	// Update is called once per frame
	void Update ()
	{
	
	}

    public void LoadUser(string UniqueUserName)
    {
        Debug.Log("Loading UserData from our database::TODO");
        // insert unique pc for first 5.
        PlayerCharacter pc;
        for (int i = 0; i < 5; i++)
        {
            pc = new PlayerCharacter();
            pc.ID = i*2;
            pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
            listOfPlayerCharacters.Add(pc);
        }

        // insert random for last 15
        for (int i = 0; i < 15; i++)
        {
            pc = new PlayerCharacter();
            pc.ID = 1;
            pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
            listOfPlayerCharacters.Add(pc);
        }

        // insert random special character for last pc
        pc = new PlayerCharacter();
        pc.ID = 12;
        pc.databaseChar = Google2u.HeroesData.Instance.Rows.Find(x => x._ID == pc.ID);
        listOfPlayerCharacters.Add(pc);


        listOfTeams[0].SwapCharacter(0, listOfPlayerCharacters[0]);
        listOfTeams[0].SwapCharacter(1, listOfPlayerCharacters[1]);
        listOfTeams[0].SwapCharacter(2, listOfPlayerCharacters[2]);
        listOfTeams[0].SwapCharacter(3, listOfPlayerCharacters[4]);
        listOfTeams[0].SwapCharacter(4, listOfPlayerCharacters[3]);
        listOfTeams[0].SwapCharacter(5, listOfPlayerCharacters[20]);

        LOADEDUSER = true;
    }

}
