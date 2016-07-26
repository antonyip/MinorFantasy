using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Logic_Any_Enemy : AIAction
{
    public new List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        return allUnits.FindAll(x => MyUnit.IsEnemyUnit != x.IsEnemyUnit);
    }

    public new Logic_Any_Enemy Clone()
    {
        return new Logic_Any_Enemy();
    }
}
