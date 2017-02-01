using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Logic_Any_Enemy : AIAction
{
    public override List<Unit> EvaluateThis(Unit MyUnit, List<Unit> allUnits)
    {
        Unit u = MyUnit;
        var selectedUnits = allUnits.FindAll(x => u.IsEnemyUnit != x.IsEnemyUnit && !x.isDead).ToList();
        return selectedUnits;
    }

}
