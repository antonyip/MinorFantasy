using UnityEngine;
public class LevelOptions
{

}

public class PlayerManager : MonoBehaviour
{
	public static PlayerManager instance;
	public int selectedLevel;
	public LevelOptions levelOptions = new LevelOptions();

	void Awake()
	{
		instance = this;
	}
}


