using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class ItemDropScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localScale = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetupItem(Item i)
    {
        if (i != null)
        { 
            transform.localScale = Vector3.zero;
            StartAnimation();
        }
    }

    public void StartAnimation()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOScale(Vector3.one, DataManager.NORMALANIMATION));
        seq.AppendInterval(DataManager.LONGANIMATION);
        seq.Append(transform.DOScale(Vector3.zero, DataManager.NORMALANIMATION));
        // TODO make it nicer
        seq.Play();
    }
}

