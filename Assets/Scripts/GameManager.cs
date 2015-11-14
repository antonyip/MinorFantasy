using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public FloorGenerator floorGenerator;
    public EnemyGenerator enemyGenerator;
    public List<Vector3> thePath;

    public Transform StartPoint;
    public Transform EndPoint;

	public GameObject readyButton;

	public bool GameStarted = false;
	public bool GamePaused = false;

    void Awake()
    {
        DOTween.Init();
        instance = this;
    }

	void LoadLevelData (int levelSelected)
	{

	}

	void LoadPlayerData (LevelOptions levelOptions)
	{

	}

	// Use this for initialization
	void Start ()
	{
		LoadPlayerData(PlayerManager.instance.levelOptions);
		LoadLevelData(PlayerManager.instance.selectedLevel);
    }
	
	// Update is called once per frame
	void Update (){
	
	}

	void ShowReadyButton ()
	{
		readyButton.SetActive(true);
	}

	public void GeneratePath()
	{
		thePath = floorGenerator.FindPath(StartPoint.position, EndPoint.position);
		ShowReadyButton();
	}

	void StartWaves ()
	{
		enemyGenerator.StartWaves();
	}

	public void GameStart()
	{
		readyButton.SetActive(false);
		StartWaves();
		GameStarted = true;
	}

}
