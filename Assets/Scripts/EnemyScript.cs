using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using System;

public class EnemyScript : MonoBehaviour {

    public List<Vector3> path;
    List<Bullet> bullets = new List<Bullet>();

    public int hp = 5;
    int maxhp = 5;
    float speed = 1f;

    void NextMove()
    {
        if (path.Count > 0)
        {
            transform.DOMove(path[0], speed).OnComplete(NextMove);
			path.RemoveAt(0);
        }
        else
        {
			EnemyHitBase();
		}
	}

	public void StartWalking()
	{
		path = new List<Vector3>(GameManager.instance.thePath);
		NextMove();
	}

    // Update is called once per frame
    void Update () {
	
	}

    public void AddBullet(Bullet b)
    {
        bullets.Add(new Bullet(b));
        hp -= b.damage;

		if (hp <= 0)
		{
			DOTween.Kill(gameObject);
			EnemyDied();
		}
    }
    
    void FixedUpdate()
    {

    }

	void EnemyHitBase()
	{
		EnemyDiedandCleanUp();
	}

	void EnemyDied()
	{

		EnemyDiedandCleanUp();
	}

	void EnemyDiedandCleanUp()
	{
		GameManager.instance.enemyGenerator.listOfEnemiesSpawned.Remove(gameObject);
		Destroy(gameObject);
	}
}
