using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;
using System;

public class ThrowAwayDamageScript : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start ()
    {
        transform.DOMove(transform.position + new Vector3(0, 0.8f, 0), DataManager.LONGANIMATION);
        transform.DOScale(Vector3.zero, DataManager.LONGANIMATION * 3).OnComplete(DestroyMe);
    }
	
	void DestroyMe()
    {
        Destroy(gameObject);
	}

    public void SetDamage(string damage, Color32 color)
    {
        text.text = damage;
        text.color = color;
    }
}

