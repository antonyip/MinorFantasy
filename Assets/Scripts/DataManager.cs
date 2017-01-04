using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Google2u;

public class DataManager : MonoBehaviour {

	public static DataManager instance;
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

	void Awake()
	{
        selectedMap = 0;
        Team t = new Team();
        PlayerCharacter pc = new PlayerCharacter();
        pc.ID = 1;
        pc.CurrentLevel = 10;
        t.SwapCharacter(0, pc);
        listOfTeams.Add(t);
        Debug.Log("InitDataManager");
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

}
