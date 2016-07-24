using UnityEngine;
using System.Collections;

public class GiveUpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPress()
	{
		GameScript.instance.gameInProgress = false;
		GameScript.instance.DefeatPopUp.SetActive(true);
	}
}
