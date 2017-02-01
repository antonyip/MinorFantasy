using UnityEngine;
using System.Collections.Generic;
using System;

public abstract class AIAction
{
    public virtual List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
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
            case 2:
                return new Logic_Enemy_M75();
            case 3:
                return new Logic_Enemy_M50();
            case 4:
                return new Logic_Enemy_M25();
            case 5:
                return new Logic_Ally_M75();
            case 6:
                return new Logic_Ally_M50();
            case 7:
                return new Logic_Ally_M25();
                /* GAP HERE */
            case 21:
                return new Logic_Enemy_L75();
            case 22:
                return new Logic_Enemy_L50();
            case 23:
                return new Logic_Enemy_L25();
            case 24:
                return new Logic_Ally_L75();
            case 25:
                return new Logic_Ally_L50();
            case 26:
                return new Logic_Ally_L25();

            default:
                return new Logic_Any_Enemy();
        }
    }
}