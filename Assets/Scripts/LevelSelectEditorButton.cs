using UnityEngine;
using System.Collections;

public class LevelSelectEditorButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPress()
	{
		SceneManager.CurrentGameMode = SceneManager.GameMode.EditorMode;
		SceneManager.instance.NextSceneName = "GameLevel";
	}
}
