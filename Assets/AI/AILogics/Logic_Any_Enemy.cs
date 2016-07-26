using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Logic_Any_Enemy : AIAction
{
    public override List<Unit> EvaluateThis(ref Unit MyUnit, ref List<Unit> allUnits)
    {
        Unit u = MyUnit;
        var allunits = allUnits.FindAll(x => u.IsEnemyUnit != x.IsEnemyUnit);
        allunits.RemoveRange(1, allunits.Count - 1);
        return allunits;
    }

}
