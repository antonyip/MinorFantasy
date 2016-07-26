using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Logic_Any_Enemy : AIAction
{
    public override List<Unit> EvaluateThis(Unit MyUnit, ref List<Unit> allUnits)
    {
        return allUnits.FindAll(x => MyUnit.IsEnemyUnit != x.IsEnemyUnit);
    }

}
