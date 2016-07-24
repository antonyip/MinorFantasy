using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EditorFloorScript : MonoBehaviour {

	public int ID;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonClicked()
	{
		transform.FindChild("SpriteImage").GetComponent<Image>().sprite = LevelEditorScript.instance.CurrentBrush.GetComponent<Image>().sprite;
		transform.FindChild("SpriteImage").GetComponent<Image>().color = LevelEditorScript.instance.CurrentBrush.GetComponent<Image>().color;
		ID = LevelEditorScript.instance.CurrentBrush.GetComponent<LevelEditorCurrentBrushScript>().ID;

		if (LevelEditorScript.instance.CurrentBrush.name == "Eraser")
		{
			transform.FindChild("SpriteImage").GetComponent<Image>().color = new Color(0,0,0,0);
			ID = 0;
		}


	}
}

