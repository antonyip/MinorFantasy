using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DG.Tweening;

public class GameScript : MonoBehaviour {

	public static GameScript instance;
	public GameObject FloorPrefab;
	public GameObject PlayerPrefab;
	//public GameObject BeatIndicatorPrefab;
	public GameObject FloorHolder;
	public GameObject TutorialPopUp;
	public GameObject StartPopUp;
	public GameObject VictoryPopUp;
	public GameObject DefeatPopUp;
	public Image Background;

	// Floor Details
	public List<GameObject> allFloors = new List<GameObject>(); // Holder for Visuals
	public int[] blockedFloors; // use this for figuring out blocking

	// Debug
	public bool BEATMODE;

	public static int maxRow = 7;
	public static int maxCol = 7;
	public static int gridSpace = 20;

	public static int offsetGrid;
	public static Vector3 startPoint = new Vector3();

	// Player Details
	GameObject Player;
	int pRow = 0;
	int pCol = 0;
	//bool hasMoved = false;

	// Game Details
	public bool gameInProgress = false;

	// Rhythm Details
	int BPM = 140;
	float DefaultBeatTimer;
	float BeatTimer;
	float LateBeatTimer = 0.0f;
	float LateLimit = 0.2f;
	//float LateOffset = 0.0f;

	// control details
	bool leftOkay;
	bool rightOkay;
	bool downOkay;
	bool upOkay;

	// EnemyStuffs
	//bool EnemyUpdated = false;

	public GameObject BeatIndicator;

	void Awake()
	{
		instance = this;
	}

	public void PrepareTutorial()
	{
		TutorialPopUp.SetActive(true);
		TutorialPopUp.transform.FindChild("TutorialText").GetComponent<Text>().text = DataManager.instance.selectedLevel.tuttext;
	}

	// Use this for initialization
	void Start ()
	{
		//Invoke("StartGame",2.0f);
		if (SceneManager.CurrentGameMode == SceneManager.GameMode.GameMode)
		{
			PrepareTutorial();
			PrepareBoard();
			StartPopUp.SetActive(true);
		}
	}

	public void StartGame()
	{
		gameInProgress = true;
	}

	public void VictoryOver()
	{
		if (SceneManager.CurrentGameMode == SceneManager.GameMode.GameMode)
		{
			SceneManager.instance.NextSceneName = "LevelSelect";
		}
		else
		{
			GameLevelSwitcher.instance.MyGame.SetActive(false);
			GameLevelSwitcher.instance.MyEditor.SetActive(true);
			PlayerIOManager.instance.SubmitCurrentLevel();
		}
	}

	public void DefeatOver()
	{
		if (SceneManager.CurrentGameMode == SceneManager.GameMode.GameMode)
		{
			SceneManager.instance.NextSceneName = "LevelSelect";
		}
		else
		{
			GameLevelSwitcher.instance.MyGame.SetActive(false);
			GameLevelSwitcher.instance.MyEditor.SetActive(true);
		}

	}

	public void PrepareBoard()
	{
		// cleanup
		// assign the Floor Times
		/*
		GameObject[] array = GameObject.FindGameObjectsWithTag("Floor");

		for (int i = 0; i < 49; ++i)
		{
			int id = int.Parse(array[i].name.Substring("FloorPrefab(Clone) ".Length));
			id = 48-id;
			allFloors[id] = array[i];
			//Debug.Log(id);
		}
		*/
		Background.sprite = DataManager.instance.listOfBackgrounds[DataManager.instance.selectedLevel.customizedBackground];

		offsetGrid = (int)FloorPrefab.GetComponent<RectTransform>().rect.width;
		startPoint = new Vector3(-(offsetGrid + gridSpace) * (int)(maxRow/2), -(offsetGrid + gridSpace)*(int)(maxCol/2),0);
		Sprite floorSprite = DataManager.instance.listOfFloorTiles[DataManager.instance.selectedLevel.customizedTile];

		for (int row = 0; row < maxRow; row++)
		{
			for (int col = 0; col < maxCol; col++)
			{
				GameObject go = Instantiate(FloorPrefab) as GameObject;
				go.GetComponent<Image>().overrideSprite = floorSprite;
				go.transform.SetParent(FloorHolder.transform);
				go.transform.localScale = Vector3.one;
				go.transform.localPosition = startPoint + new Vector3(col*(offsetGrid+gridSpace),row*(offsetGrid+gridSpace),0);
				go.transform.GetChild(0).GetComponent<Text>().text = (col+row*maxRow).ToString();
				allFloors.Add(go);
				
			}
		}


		// Player Destroy and recreate
		if (Player != null)
		{
			Destroy(Player);
		}
		
		Player = Instantiate(PlayerPrefab) as GameObject;
		Player.transform.SetParent(FloorHolder.transform);
		Player.transform.localScale = Vector3.one;

		//Debug.Log(DataManager.instance.selectedLevel.levelName);

		EnemyManager.instance.SpawnEnemies(DataManager.instance.selectedLevel.levelData);
		
		// calcualate beat timings
		BeatTimer = 60.0f/BPM;
		DefaultBeatTimer = BeatTimer;
		
		//reset controls
		leftOkay = false;
		rightOkay = false;
		downOkay = false;
		upOkay = false;

		blockedFloors = new int[maxCol*maxRow];
	}

	void UpdateEnemyPositionsInGrid()
	{
		//reset the floor
		for (int i = 0; i < blockedFloors.Length; i++)
		{
			blockedFloors[i] = 0;
		}

		foreach (Enemy go in EnemyManager.instance.AllEnemies)
		{
			//if (go.eColType == CollisionType.Block)
			blockedFloors[go.eCol+go.eRow*maxRow] = go.eID;
		}
	}

	// Update is called once per frame
	void Update ()
	{

		#region Game
		if (gameInProgress)
		{
			//Debug.Log(thisBeat);
			//handling beats
			BeatTimer -= Time.deltaTime;
			LateBeatTimer += Time.deltaTime;

			HandleKeyboardInput();

			if (BeatTimer < LateLimit/2)
			{
				ShowHitBeat();
			}
			
			if (BeatTimer < 0.0f)
			{
				BeatTimer = DefaultBeatTimer;
				LateBeatTimer = 0.0f;
				UpdateEnemyPositionsInGrid();
				EnemyManager.instance.UpdateEnemies();
				HandlePlayerMovement();
				Player.transform.DOMove(allFloors[pCol+pRow*maxRow].transform.position,DefaultBeatTimer/2);
				CheckForCollisions ();
			}
			
			if (LateBeatTimer > LateLimit/2)
			{
				HideHitBeat();
			}

			// handle input



		}
		#endregion
	}

	public void SetPlayerPos(int row, int col)
	{
		Player.transform.position = allFloors[col+row*maxRow].transform.position;
		pCol = col;
		pRow = row;
	}

	void ShowHitBeat()
	{
		//BeatIndicator.SetActive(true);
	}

	void HideHitBeat()
	{
		//BeatIndicator.SetActive(false);	
	}

	void CheckForCollisions ()
	{
		foreach (Enemy go in EnemyManager.instance.AllEnemies) {
			// update positions
			//go.transform.position = allFloors[go.eCol+go.eRow*maxRow].transform.position;
			go.transform.DOMove (allFloors [go.eCol + go.eRow * maxRow].transform.position, DefaultBeatTimer / 2);
			//go.transform.localPosition = GameScript.startPoint + new Vector3(go.eCol*GameScript.offsetGrid,go.eRow*GameScript.offsetGrid,0);
			// check for game over
			if (go.eCol == pCol && go.eRow == pRow) {
				if (go.eColType == CollisionType.Death) {
					gameInProgress = false;
					DefeatPopUp.SetActive (true);
					Debug.Log ("Game Over");
					return;
				}
				if (go.eColType == CollisionType.Win) {
					gameInProgress = false;
					VictoryPopUp.SetActive (true);
					Debug.Log ("Victory!");
				}
			}
		}
	}

	void HandlePlayerMovement()
	{
		int temp;
		if (upOkay)
		{
			temp = pRow+1;

			if (temp > maxRow-1)
			{
				temp = 0;
			}

			if ((EnemyType)blockedFloors[(temp)*maxRow + pCol] == EnemyType.Wall)
				return;

			pRow = temp;

			downOkay = false;
			leftOkay = false;
			rightOkay = false;
		}
		if (downOkay)
		{
			//hasMoved = true;
			//Debug.Log("Hit Down Success");
			temp = pRow-1;
			if (temp < 0)
			{
				temp = maxRow-1;
			}

			if ((EnemyType)blockedFloors[(temp)*maxRow + pCol] == EnemyType.Wall)
				return;

			pRow = temp;

			upOkay = false;
			leftOkay = false;
			rightOkay = false;
		}
		if (leftOkay)
		{
			//hasMoved = true;
			//Debug.Log("Hit Left Success");
			temp = pCol-1;
			if (temp < 0)
			{
				temp = maxCol-1;
			}

			if ((EnemyType)blockedFloors[(pRow)*maxRow + temp] == EnemyType.Wall)
				return;

			pCol = temp;

			upOkay = false;
			downOkay = false;
			rightOkay = false;
		}
		if (rightOkay)
		{
			//hasMoved = true;
			//Debug.Log("Hit Right Success");
			temp = pCol+1;
			if (temp > maxCol-1)
			{
				temp= 0;
			}

			if ((EnemyType)blockedFloors[(pRow)*maxRow + temp] == EnemyType.Wall)
				return;

			pCol = temp;

			upOkay = false;
			downOkay = false;
			leftOkay = false;
		}
	}
	
	void HandleKeyboardInput()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
		{
			UpButtonPressed();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.S))
		{
			DownButtonPressed();
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.A))
		{
			LeftButtonPressed();
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D))
		{
			RightButtonPressed();
		}
	}

	public void LeftButtonPressed()
	{
		//if (BeatTimer < LateLimit || LateBeatTimer < LateLimit || !BEATMODE)
		{
			rightOkay = false;
			downOkay = false;
			upOkay = false;
			leftOkay = true;
			//hasMoved = true;
		}
	}

	public void RightButtonPressed()
	{
		//if (BeatTimer < LateLimit || LateBeatTimer < LateLimit || !BEATMODE)
		{
			downOkay = false;
			upOkay = false;
			leftOkay = false;
			rightOkay = true;
			//hasMoved = true;
		}
	}

	public void UpButtonPressed()
	{
		//if (BeatTimer < LateLimit || LateBeatTimer < LateLimit || !BEATMODE)
		{
			rightOkay = false;
			downOkay = false;
			leftOkay = false;
			upOkay = true;
			//hasMoved = true;
		}
	}

	public void DownButtonPressed()
	{
		//if (BeatTimer < LateLimit || LateBeatTimer < LateLimit || !BEATMODE)
		{
			upOkay = false;
			rightOkay = false;
			leftOkay = false;
			downOkay = true;
			//hasMoved = true;
		}
	}
	
}

