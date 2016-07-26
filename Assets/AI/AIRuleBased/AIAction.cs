using UnityEngine;
using System.Collections.Generic;
using System;

public abstract class AIAction
{
    public virtual List<Unit> EvaluateThis(ref Unit MyUnit, ref List<Unit> allUnits)
    {
        return allUnits;
    }

}

public static class Gambits
{
    public static AIAction GetGambit(int id)
    {
        switch(id)
        {
            case 1:
                return new Logic_Any_Enemy();
            default:
                return new Logic_Any_Enemy();
        }
    }
}