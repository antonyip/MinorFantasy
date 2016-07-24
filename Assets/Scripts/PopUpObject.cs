using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PopUpObject : MonoBehaviour {

	// Use this for initialization
	void OnEnable ()
	{
		//Debug.Log("PopUP::ENABLE");
		gameObject.transform.SetParent(PopUpManager.instance.transform);
		gameObject.transform.localScale = Vector3.zero;
		PopUpManager.instance.listOfPopUps.Add(this);
	}

	void OnDisable()
	{
		PopUpManager.instance.isShowing = false;
		PopUpManager.instance.currentPopup = null;
		MaskManager.instance.HideMask();
	}

	public void ShowPopUp()
	{
		PopUpManager.instance.isShowing = true;
		gameObject.transform.DOScale(Vector3.one,0.5f);
		MaskManager.instance.ShowMask();
	}
}
