using UnityEngine;
using System.Collections;

public class LevelSelectBackButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPressed()
	{
		SceneManager.instance.NextSceneName = "MainMenu";
	}
}
