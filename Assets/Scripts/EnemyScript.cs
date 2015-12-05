using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using System;

public class EnemyScript : MonoBehaviour {

    public List<Vector3> path;
    List<Bullet> bullets = new List<Bullet>();

    public int hp = 5;
    public int maxhp = 5;
	public int defaultarmor = 0;
	public int armor = 0;
	public float movespeed = 1;
	public float defaultmovespeed = 1;

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
