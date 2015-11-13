using UnityEngine;
using DG.Tweening;

public class EnemyGenerator : MonoBehaviour {

    public GameObject[] enemyPrefab;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = SpawnEnemy(0);
            go.transform.position = GameManager.instance.StartPoint.position;
        }
	
	}

    public GameObject SpawnEnemy(int id)
    {
        return Instantiate(enemyPrefab[id]) as GameObject;
    }
}
