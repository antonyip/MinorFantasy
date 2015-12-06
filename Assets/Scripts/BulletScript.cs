using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BulletScript : MonoBehaviour {

	Bullet b;
	GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setTarget (GameObject enemy)
	{
		target = enemy;
		transform.DOMove(target.transform.position,0.5f).OnComplete(DestroySelf).SetEase(Ease.Linear);
	}

	void DestroySelf()
	{
		if (target != null)
			target.GetComponent<EnemyScript>().AddBullet(b);
		Destroy(gameObject);
	}

	public void SetBullet(Bullet b)
	{
		this.b = b;
	}

}
