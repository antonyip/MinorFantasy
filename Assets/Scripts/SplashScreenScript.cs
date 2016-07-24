using UnityEngine;
using System.Collections;

public class SplashScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Invoke ("SwitchScene",2.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void SwitchScene()
	{
		SceneManager.instance.NextSceneName = "MainMenu";
	}
}
