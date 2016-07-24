using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LevelEditorScript : MonoBehaviour {

	public static LevelEditorScript instance;

	public GameObject EditorFloorPrefab;
	public GameObject FloorHolder;
	public GameObject CurrentBrush;

	public List<GameObject> allFloors = new List<GameObject>();

	public static int maxRow = 7;
	public static int maxCol = 7;
	public static int gridSpace = 20;
	
	public static int offsetGrid;
	public static Vector3 startPoint = new Vector3();

	void Awake()
	{
		instance = this;
		Input.simulateMouseWithTouches = true;
	}
	// Use this for initialization
	void Start ()
	{
		MakeGrid();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void MakeGrid()
	{
		offsetGrid = (int)EditorFloorPrefab.GetComponent<RectTransform>().rect.width;
		startPoint = new Vector3(-(offsetGrid + gridSpace) * (int)(maxRow/2), -(offsetGrid + gridSpace)*(int)(maxCol/2),0);
		
		for (int row = 0; row < maxRow; row++)
		{
			for (int col = 0; col < maxCol; col++)
			{
				GameObject go = Instantiate(EditorFloorPrefab) as GameObject;
				go.transform.SetParent(FloorHolder.transform);
				go.transform.localScale = Vector3.one;
				go.transform.localPosition = startPoint + new Vector3(col*(offsetGrid+gridSpace),row*(offsetGrid+gridSpace),0);
				go.transform.FindChild("ID").GetComponent<Text>().text = (col+row*maxRow).ToString();
				allFloors.Add(go);
				
			}
		}
	}
}
