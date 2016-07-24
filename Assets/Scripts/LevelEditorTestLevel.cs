using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelEditorTestLevel : MonoBehaviour
{

	public GameObject MyGame;
	public GameObject MyEditor;

	// Update is called once per frame
	public void TestLevel ()
	{
		List<GameObject> floor = LevelEditorScript.instance.allFloors;
		string concatString = "";
		for (int i = 0; i < floor.Count; i++)
		{
			concatString += floor[i].GetComponent<EditorFloorScript>().ID.ToString();
		}
		//TODO:: ERROR CHECKING

		DataManager.instance.selectedLevel.LoadLevel(concatString);

		MyGame.SetActive(true);
		GameScript.instance.PrepareBoard();
		GameScript.instance.StartPopUp.SetActive(true);
		MyEditor.SetActive(false);
	}
}
