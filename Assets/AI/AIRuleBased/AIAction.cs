using UnityEngine;
using System.Collections.Generic;
using System;

public abstract class AIAction
{
    public virtual List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        return allUnits;
    }

    public virtual AIAction Clone()
    {
        return null;
    }
}

public static class Gambits
{
    public static List<AIAction> AllGambits = new List<AIAction>();

    public static void Init()
    {
        AllGambits.Add(new Logic_Any_Enemy()); // first one is padding
        AllGambits.Add(new Logic_Any_Enemy());
    }
}