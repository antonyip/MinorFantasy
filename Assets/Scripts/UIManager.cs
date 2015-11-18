using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	public bool isFloorSelectorOpen = false;

	// Use this for initialization
	void Awake () {
	
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
