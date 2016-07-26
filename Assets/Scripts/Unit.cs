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
    public bool isDead;

    public int HP
    {
        get { return _HP; }
        set
        {
            _HP = value; if (_HP <= 0) { isDead = true; } else { isDead = false; }
        }
    }
    private int _HP;

    public bool IsEnemyUnit { get; set; }

    // Use this for initialization
    public void Start()
    {
        HP = character.GetHP();
    }

    public string GetUnitName()
    {
        return character.GetName();
    }
}
