using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MaskManager : MonoBehaviour {

	public static MaskManager instance;

	int maskCounter = 0;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start ()
	{
		DOTween.Init ();
	}

	public void ShowMask()
	{
		++maskCounter;

		transform.GetChild(0).gameObject.SetActive(true);
	}

	public void HideMask()
	{


		--maskCounter;
		if (maskCounter <= 0)
		{
			maskCounter = 0;
			transform.GetChild(0).gameObject.SetActive(false);
		}

	}
}
