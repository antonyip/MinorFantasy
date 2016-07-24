using UnityEngine;
using System.Collections;

public class LevelEditorQuitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPress()
	{
		SceneManager.instance.NextSceneName = "MainMenu";
	}
}
