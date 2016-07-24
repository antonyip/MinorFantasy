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

    public List<Team> listOfTeams = new List<Team>();
    public int selectedTeam = 0;
	
	void Awake()
	{
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
