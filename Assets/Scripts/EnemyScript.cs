using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using System;

public class EnemyScript : MonoBehaviour {

    List<Vector3> path;
    List<Bullet> bullets;

    int hp = 5;
    int maxhp = 5;
    float speed = 1f;

    // Use this for initialization
    void Start () {
        path = new List<Vector3>(GameManager.instance.thePath);
        transform.DOMove(path[0], speed).OnComplete(NextMove);

    }

    void NextMove()
    {
        if (path.Count > 2)
        {
            path.RemoveAt(0);
            transform.DOMove(path[0], speed).OnComplete(NextMove);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void AddBullet(Bullet b)
    {
        bullets.Add(new Bullet(b));
        hp -= b.damage;
    }
    
    void FixedUpdate()
    {

    }
}
