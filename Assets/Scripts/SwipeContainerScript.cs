using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SwipeContainerScript : MonoBehaviour {

	int index = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MoveLeft()
	{
		Debug.Log ("Left Clicked");
		if (index > 0)
		{
			index -= 1;
			//transform.localPosition = new Vector3(-index * 1550, 0, 0);
			transform.DOLocalMoveX(-index * 1550, DataManager.NORMALANIMATION);
		}
	}

	void MoveRight()
	{
		Debug.Log ("Right Clicked");
		if (index < 3)
		{
			index += 1;
			//transform.localPosition = new Vector3(-index * 1550, 0, 0);
			transform.DOLocalMoveX(-index * 1550, DataManager.NORMALANIMATION);
		}
	}
}
