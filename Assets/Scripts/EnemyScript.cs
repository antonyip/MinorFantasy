using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using System;

public class EnemyScript : MonoBehaviour {

    List<Vector3> path;
	// Use this for initialization
	void Start () {
        path = new List<Vector3>(GameManager.instance.thePath);
        transform.DOMove(path[0],1).OnComplete(NextMove);

    }

    void NextMove()
    {
        if (path.Count > 2)
        {
            path.RemoveAt(0);
            transform.DOMove(path[0], 1).OnComplete(NextMove);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
