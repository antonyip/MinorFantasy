using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public FloorGenerator floorGenerator;
    public EnemyGenerator enemyGenerator;
    public List<Vector3> thePath;

    public Transform StartPoint;
    public Transform EndPoint;

    void Awake()
    {
        DOTween.Init();
        instance = this;
    }


	// Use this for initialization
	void Start () {
        Invoke("LateStart", 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void LateStart()
    {
        thePath = floorGenerator.FindPath(StartPoint.position, EndPoint.position);
    }
}
