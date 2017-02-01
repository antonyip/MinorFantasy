using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Logic_EnemyMoreThanSelections : AIAction
{
    public float HPLimit = 0.75f;

    public override List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        var selectedUnits = allUnits.FindAll(x => MyUnit.IsEnemyUnit != x.IsEnemyUnit && !x.isDead && x.HPPercent >= HPLimit).ToList();
        if (selectedUnits.Count > 1)
        {
            selectedUnits.RemoveRange(1, selectedUnits.Count - 1);
        }
        return selectedUnits;
    }
}


public class Logic_EnemyLessThanSelections : AIAction
{
    public float HPLimit = 0.75f;

    public override List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        var selectedUnits = allUnits.FindAll(x => MyUnit.IsEnemyUnit != x.IsEnemyUnit && !x.isDead && x.HPPercent <= HPLimit).ToList();
        if (selectedUnits.Count > 1)
        {
            selectedUnits.RemoveRange(1, selectedUnits.Count - 1);
        }
        return selectedUnits;
    }
}

public class Logic_Enemy_M75 : Logic_EnemyMoreThanSelections
{
    public Logic_Enemy_M75()
    {
        HPLimit = 0.75f;
    }
}

public class Logic_Enemy_M50 : Logic_EnemyMoreThanSelections
{
    public Logic_Enemy_M50()
    {
        HPLimit = 0.5f;
    }
}

public class Logic_Enemy_M25 : Logic_EnemyMoreThanSelections
{
    public Logic_Enemy_M25()
    {
        HPLimit = 0.25f;
    }
}


public class Logic_Enemy_L75 : Logic_EnemyLessThanSelections
{
    public Logic_Enemy_L75()
    {
        HPLimit = 0.75f;
    }
}

public class Logic_Enemy_L50 : Logic_EnemyLessThanSelections
{
    public Logic_Enemy_L50()
    {
        HPLimit = 0.5f;
    }
}

public class Logic_Enemy_L25 : Logic_EnemyLessThanSelections
{
    public Logic_Enemy_L25()
    {
        HPLimit = 0.25f;
    }
}

