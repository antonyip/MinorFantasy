using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{
	public float attackSpeed = 1; 	//in seconds
	public float range = 9999; 		// per hexagon
	public int damage;			// per bullet
	public FloorType towerColor;

	// Use this for initialization
	void Start () {

	}

	public void Setup(float attackSpeed, float range, int damage)
	{
		this.attackSpeed = attackSpeed;
		this.range = range;
		this.damage = damage;
		SetupComplete();
	}

	void SetupComplete()
	{
		InvokeRepeating("Fire",0,attackSpeed);
	}

	GameObject CheckForEnemies ()
	{
		for (int i = 0; i < GameManager.instance.enemyGenerator.listOfEnemiesSpawned.Count; i++)
		{
			float diffsqred = (GameManager.instance.enemyGenerator.listOfEnemiesSpawned[i].transform.position - gameObject.transform.position).sqrMagnitude;
			if (diffsqred < range * range)
			{
				return GameManager.instance.enemyGenerator.listOfEnemiesSpawned[i];
			}
		}

		return null;
	}
	
	void Fire ()
	{
		GameObject enemy = CheckForEnemies();
		if (enemy != null)
		{
			GameObject go = Instantiate(GameManager.instance.bulletGenerator.bulletPrefabs[0]) as GameObject;
			Bullet b = new Bullet(1);
			go.transform.position = transform.position;
			go.GetComponent<BulletScript>().SetBullet(b);
			go.GetComponent<BulletScript>().setTarget(enemy);
		}
	}
}
