using UnityEngine;
using System.Collections.Generic;
using DG.Tweening;

public class SpawnObject
{
	public SpawnObject (int id, float time)
	{
		this.id = id;
		this.time = time;

	}
	public float time;
	public int id;
	public bool spawned = false;
}

public class EnemyGenerator : MonoBehaviour {

    public GameObject[] enemyPrefab;

	public List<GameObject> listOfEnemiesSpawned = new List<GameObject>();

	public float TimeBetweenWaves = 30f;
	public List<SpawnObject> listOfEnemies = new List<SpawnObject>();

	float TimeRightNow = 0;
	int wave = 0;
    // Use this for initialization
    void Start () {
		listOfEnemies.Clear();
    }
	
	// Update is called once per frame
	void Update () {

		if (GameManager.instance.GameStarted && !GameManager.instance.GamePaused)
			TimeRightNow += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy(0);
        }


		if (listOfEnemies.Count > 1 && listOfEnemies[0].time < TimeRightNow)
		{
			SpawnEnemy(listOfEnemies[0].id);
			listOfEnemies.RemoveAt(0);
		}

	}

    public GameObject SpawnEnemy(int id)
    {
        GameObject go = Instantiate(enemyPrefab[id]) as GameObject;
		go.transform.position = GameManager.instance.StartPoint.position;
		go.GetComponent<EnemyScript>().StartWalking();
		listOfEnemiesSpawned.Add(go);
		return go;
    }

	public void StartWaves ()
	{
		NextWaves();
	}

	public void NextWaves ()
	{
		++wave;
		for (int i = 0; i < 5; i++) {
			listOfEnemies.Add(new SpawnObject(0,i+wave*TimeBetweenWaves));
		}
		Invoke("NextWaves",TimeBetweenWaves);
	}
}
