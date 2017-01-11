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

    public float HPPercent
    {
        get
        { 
            float test = 1.0f * _HP / _MAXHP;

            if (test > 0)
                return test;
            
            return 0;
        }
    }

    private int _HP;
    private int _MAXHP;

    public bool IsEnemyUnit { get; set; }

    // Use this for initialization
    public void Start()
    {
        _HP = character.GetHP();
        _MAXHP = character.GetHP();
    }

    public string GetUnitName()
    {
        return character.GetName();
    }
}
