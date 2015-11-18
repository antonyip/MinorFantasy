using UnityEngine;
using System.Collections;

public class FloorSelectorScript : MonoBehaviour {

	public static FloorSelectorScript instance;

	public FloorScript currentFloor;

	Vector3 offset = new Vector3(0,0,-1);

	public FloorSelectorButtonScript[] floorSelectorButtons;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FloorClicked(FloorScript floorScript)
	{
		if (GameManager.instance.GameStarted && !GameManager.instance.GamePaused)
		{
			currentFloor = floorScript;
			GetComponent<SpriteRenderer>().enabled = true;
			transform.position = floorScript.gameObject.transform.position + offset;

			foreach (var go in floorSelectorButtons)
			{
				go.gameObject.SetActive(true);
			}

		}
	}

	public void SelectionClicked(int ID)
	{
		GameObject go = Instantiate(GameManager.instance.towerGenerator.TowerPrefabs[0]) as GameObject;
		go.transform.position = currentFloor.gameObject.transform.position;
		go.transform.SetParent(GameManager.instance.towerGenerator.transform);
		go.transform.localScale = Vector3.one/8;
		currentFloor.tower = go.GetComponent<Tower>();
		currentFloor.tower.Setup(1,999,1);

		CloseFloor ();
	}

	public void CloseFloor ()
	{
		GetComponent<SpriteRenderer>().enabled = false;
		
		foreach (var go in floorSelectorButtons)
		{
			go.gameObject.SetActive(false);
		}
		
		UIManager.instance.isFloorSelectorOpen = false;
	}
}
