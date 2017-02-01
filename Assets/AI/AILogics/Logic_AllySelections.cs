using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Logic_AllyMoreThanSelections : AIAction
{
    public float HPLimit = 0.75f;

    public override List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        var selectedUnits = allUnits.FindAll(x => MyUnit.IsEnemyUnit == x.IsEnemyUnit && !x.isDead && x.HPPercent >= HPLimit).ToList();
        Debug.Log("AllyMoreThenCalled:" + HPLimit);
        return selectedUnits;
    }
}


public class Logic_AllyLessThanSelections : AIAction
{
    public float HPLimit = 0.75f;

    public override List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        var selectedUnits = allUnits.FindAll(x => MyUnit.IsEnemyUnit == x.IsEnemyUnit && !x.isDead && x.HPPercent <= HPLimit).ToList();
        Debug.Log("AllyLessThenCalled:" + HPLimit);
        return selectedUnits;
    }
}

public class Logic_Ally_M75 : Logic_AllyMoreThanSelections
{
    public Logic_Ally_M75()
    {
        HPLimit = 0.75f;
    }
}

public class Logic_Ally_M50 : Logic_AllyMoreThanSelections
{
    public Logic_Ally_M50()
    {
        HPLimit = 0.5f;
    }
}

public class Logic_Ally_M25 : Logic_AllyMoreThanSelections
{
    public Logic_Ally_M25()
    {
        HPLimit = 0.25f;
    }
}


public class Logic_Ally_L75 : Logic_AllyLessThanSelections
{
    public Logic_Ally_L75()
    {
        HPLimit = 0.75f;
    }
}

public class Logic_Ally_L50 : Logic_AllyLessThanSelections
{
    public Logic_Ally_L50()
    {
        HPLimit = 0.5f;
    }
}

public class Logic_Ally_L25 : Logic_AllyLessThanSelections
{
    public Logic_Ally_L25()
    {
        HPLimit = 0.25f;
    }
}

