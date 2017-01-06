using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TacticsScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Setup(int id)
    {
        this.gameObject.transform.localScale = Vector3.zero;
        this.gameObject.transform.DOScale(Vector3.one, 0.5f);
        Debug.Log("Tactics Screen Setting up:" + id);
    }

    public void CloseTacticsScreen()
    {
        this.gameObject.transform.DOScale(Vector3.zero,0.5f).OnComplete(SetInactive);
    }

    public void SetInactive()
    {
        this.gameObject.SetActive(false);
    }
}
