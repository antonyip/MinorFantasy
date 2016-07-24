using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PopUpManager : MonoBehaviour {

	public static PopUpManager instance;
	public List<PopUpObject> listOfPopUps;
	public PopUpObject currentPopup;
	public bool isShowing = false;

	void Awake()
	{
		instance = this;
	}
	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("CheckForPopups",0.5f,0.5f);

	}
	
	// Update is called once per frame
	void CheckForPopups ()
	{
		if (listOfPopUps.Count > 0 && !isShowing)
		{
			listOfPopUps[0].ShowPopUp();
			currentPopup = listOfPopUps[0];
			listOfPopUps.RemoveAt(0);
			isShowing = true;
		}
	}

	void AddPopup(PopUpObject puo)
	{
		listOfPopUps.Add(puo);
	}

	public void CloseCurrentPopup()
	{
		currentPopup.gameObject.SetActive(false);
	}
}
