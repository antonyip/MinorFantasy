using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Skill
{
    public int id;
    public Google2u.SkillDataRow dataBaseSkill;

    public Skill(int skillid)
    {
        this.id = skillid;
        dataBaseSkill = Google2u.SkillData.Instance.Rows.Find(x => x._ID == id);
    }

    public void EvaluateSkillEffect(Unit currentUnit, Unit unit)
    {
        
    }
}

