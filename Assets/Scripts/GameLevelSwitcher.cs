using UnityEngine;
using System.Collections;

public class GameLevelSwitcher : MonoBehaviour {

	public static GameLevelSwitcher instance;
	public GameObject MyGame;
	public GameObject MyEditor;
#if UNITY_EDITOR
	public bool GameEditorMode;
#else
	bool GameEditorMode = false;
#endif


	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start ()
	{
		if (GameEditorMode)
		{
			SceneManager.CurrentGameMode = SceneManager.GameMode.EditorMode;
		}

		if (SceneManager.CurrentGameMode == SceneManager.GameMode.GameMode)
		{
			MyGame.SetActive(true);
			MyEditor.SetActive(false);
		}
		else
		{
			MyEditor.SetActive(true);
			MyGame.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
