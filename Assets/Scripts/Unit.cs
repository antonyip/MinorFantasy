using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Unit
{
    public GameObject sprite { get; set; }
    public Character character { get; set; }
    public GameObject uiButton { get; set; }


    public List<AIAction> aiActions = new List<AIAction>();
    public List<Skill> aiSkills = new List<Skill>();

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
