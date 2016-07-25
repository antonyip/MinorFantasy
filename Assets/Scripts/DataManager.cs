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
    public int selectedMap = 1;
    public int selectedMapLevel = 1;

	void Awake()
	{
        selectedMap = 1;
        Team t = new Team();
        Character c = new Character();
        t.SwapCharacter(0, c);
        listOfTeams.Add(t);
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
