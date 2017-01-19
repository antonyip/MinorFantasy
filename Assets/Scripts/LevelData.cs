using UnityEngine;
using System.Collections;

public class LevelData
{

	public string levelName;
	public int level;
	public string levelData;
	public string tuttext;

	// customization
	public int customizedTile;
	public int customizedBackground;


	// Use this for initialization
	public LevelData ()
	{
		levelName = "undefined";
		level = -1;
		levelData = "0000000020004000000000060000000010000000000000003";
		tuttext = "undefined";
		customizedTile = 0;
		customizedBackground = 0;
	}

	// used for internal levels
	public void LoadLevel(int level)
	{

		//LevelsRow ldata = Levels.Instance.GetRow("level"+level.ToString());
		//level = ldata._idint;
		//levelData = ldata._leveldata;
		//levelName = ldata._name;
		//tuttext = ldata._tuttext;
		//Levels.Instance.GetGenRow("level"+level.ToString());

	}

	// used for external levels
	public void LoadLevel(LevelData ld)
	{

	}

	// used for external levels
	public void LoadLevel(string s)
	{
        Debug.Assert(s.Length == 49);
		Debug.Log("LevelData: " + s);
		levelName = "LevelEditor";
		level = 99;
		levelData = s;
	}
}
