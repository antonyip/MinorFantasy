using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class LevelEditorItemPrefab : MonoBehaviour, IDragHandler,IBeginDragHandler,IEndDragHandler,IPointerClickHandler
{
	public int ID;

	public static GameObject objectBeingDragged;
	//public GameObject prefabObject;
	Vector3 startPosition;
	bool disableDrag = true;

	void Start()
	{
		//prefabObject = transform.parent.GetChild(1).gameObject;
		//prefabObject.transform.SetParent(transform);
	}

	public void OnBeginDrag (PointerEventData eventData)
	{
		if (!disableDrag)
		{
			objectBeingDragged = Instantiate(gameObject);
			objectBeingDragged.transform.SetParent(LevelEditorScript.instance.FloorHolder.transform);
			startPosition = gameObject.transform.position;
		}
	}

	public void OnDrag (PointerEventData eventData)
	{
		if (!disableDrag)
		{
			objectBeingDragged.transform.position = Input.mousePosition;
		}
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		if (!disableDrag)
		{
			objectBeingDragged = null;
			objectBeingDragged.transform.position = startPosition;
		}
	}

	public void OnPointerClick (PointerEventData eventData)
	{
		objectBeingDragged = gameObject;
		LevelEditorScript.instance.CurrentBrush.name = gameObject.name;
		LevelEditorScript.instance.CurrentBrush.GetComponent<LevelEditorCurrentBrushScript>().ID = ID;
		LevelEditorScript.instance.CurrentBrush.GetComponent<Image>().sprite = transform.GetChild(0).GetComponent<Image>().sprite;
		LevelEditorScript.instance.CurrentBrush.GetComponent<Image>().color = transform.GetChild(0).GetComponent<Image>().color;
	}

}

