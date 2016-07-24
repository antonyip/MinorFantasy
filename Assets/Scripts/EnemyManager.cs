using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

	public static EnemyManager instance;
	public List<Enemy> AllEnemies = new	List<Enemy>();
	public List<GameObject> AllEnemiesPrefabs;

	// Use this for initialization
	void Awake () {
		instance = this;
	}

	void Start()
	{

	}



	public void SpawnEnemies(string s)
	{
		AllEnemies.Clear();

		if (s.Length != GameScript.maxCol*GameScript.maxRow)
		{
			Debug.Log("EnemyManager::String Length Error");
			return;
		}

		for (int row = 0; row < GameScript.maxRow; row++)
		{
			for (int col = 0; col < GameScript.maxCol; col++)
			{
				int curr = col+row*GameScript.maxRow;
				// if its not blank
				if (s[curr] != '0')
				{
					// if its not player start
					int k = (int)Enemy.charToEnemyTypeConverter(s[curr]);
					//Debug.Log(k);
					if (k == (int)EnemyType.PlayerStart)
					{
						GameScript.instance.SetPlayerPos(row,col);
						continue;
					}

					GameObject go = Instantiate(AllEnemiesPrefabs[k]) as GameObject;
					Enemy e = go.GetComponent<Enemy>();
					e.eCol = col;
					e.eRow = row;
					go.transform.SetParent(GameScript.instance.FloorHolder.transform);
					go.transform.localScale = Vector3.one;
					go.transform.localPosition = GameScript.startPoint + new Vector3(col*(GameScript.offsetGrid+GameScript.gridSpace),row*(GameScript.offsetGrid+GameScript.gridSpace),0);
					AllEnemies.Add(e);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	public void UpdateEnemies()
	{
		AllEnemies.Sort(Enemy.pCompare);

		for (int i = 0; i < AllEnemies.Count; i++)
		{
			//Debug.Log(AllEnemies[i].eName);
			AllEnemies[i].UpdateAI();
		}
	}
}

