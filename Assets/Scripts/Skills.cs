using B83.ExpressionParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Skill
{
    public int id;
    public AntTool.SkillDataRow dataBaseSkill;
    private static ExpressionParser ep = new ExpressionParser();

    public Skill(int skillid)
    {
        this.id = skillid;
        dataBaseSkill = AntTool.SkillData.instance.Rows.Find(x => x._ID == id);
    }

    string skillString;

    public void SubsituteTexts(ref Unit currentUnit, ref Unit unit)
    {
        skillString = skillString.Replace("{PPATT}", currentUnit.character.GetPAtt().ToString());
        skillString = skillString.Replace("{PMATT}", currentUnit.character.GetMAtt().ToString());
        skillString = skillString.Replace("{PPDEF}", currentUnit.character.GetPDef().ToString());
        skillString = skillString.Replace("{PSTR}",  currentUnit.character.GetStr().ToString());
        skillString = skillString.Replace("{PFATT}", currentUnit.character.GetFAtt().ToString());
        skillString = skillString.Replace("{PINT}", currentUnit.character.GetInt().ToString());
        skillString = skillString.Replace("{PMDEF}", currentUnit.character.GetMDef().ToString());

        skillString = skillString.Replace("{EPDEF}", unit.character.GetPDef().ToString());
        skillString = skillString.Replace("{EMDEF}", unit.character.GetMDef().ToString());
        skillString = skillString.Replace("{EFDEF}", unit.character.GetFDef().ToString());


        skillString = skillString.Replace(" ", "");
    }

    public bool EvaluateSkillEffect(ref Unit currentUnit, ref Unit unit)
    {
        skillString = dataBaseSkill._SkillFomular;
        SubsituteTexts(ref currentUnit, ref unit);
        int result = (int)ep.Evaluate(skillString);

        // limit damage
        if (result < 1)
        {
            result = 1;
        }
        
        // do stuffs
        string topText = string.Format("{0} hits {1} for {2} using {3}", currentUnit.GetUnitName(), unit.GetUnitName(), result, dataBaseSkill._Name);
        string debugText = string.Format("{0} ({1})", topText, skillString);
        Debug.Log(debugText);
        GameMaster.instance.UpdateTopText(topText);
        unit.HP -= result;
        return dataBaseSkill._AnimationType.Contains("AnimType_MeleeTarget");
    }
}

