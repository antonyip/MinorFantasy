using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Unit : MonoBehaviour
{
    public GameObject sprite { get; set; }
    public Character character { get; set; }
    public AIBase aiBase { get; set; }
    public GameObject uiButton { get; set; }
    public bool IsEnemyUnit { get; set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string GetUnitName()
    {
        return character.GetName();
    }
}
