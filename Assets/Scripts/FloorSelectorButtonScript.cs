using UnityEngine;
using System.Collections;

public class FloorSelectorButtonScript : MonoBehaviour {

	public int ID;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Debug.Log("FloorSelectorButtonScript" + ID);
		UIManager.instance.isFloorSelectorOpen = false;
		FloorSelectorScript.instance.SelectionClicked(ID);
	}
}
