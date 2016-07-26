using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Skill
{
    public int id;
    public Google2u.SkillDataRow dataBaseSkill;

    public Skill(int skillid)
    {
        this.id = skillid;
        dataBaseSkill = Google2u.SkillData.Instance.Rows.Find(x => x._ID == id);
    }

    string skillString;

    public void SubsituteTexts()
    {
        // skillString = skillString;
    }

    public bool EvaluateSkillEffect(ref Unit currentUnit, ref Unit unit)
    {
        skillString = dataBaseSkill._SkillFomular;
        SubsituteTexts();

        // do stuffs
        Debug.Log("smacky");
        unit.HP -= 10;
        return dataBaseSkill._AnimationType.Equals("Melee");
    }
}

