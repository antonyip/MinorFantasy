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

    public bool EvaluateSkillEffect(Unit currentUnit, Unit unit)
    {
        skillString = dataBaseSkill._SkillFomular;
        SubsituteTexts(ref currentUnit, ref unit);
        int result = (int)ep.Evaluate(skillString);
        Color32 color = Color.red;
        bool ShowDamage = true;


        // limit damage
        if (dataBaseSkill._DamageType.Equals("DAMAGE"))
        {
            if (result < 1)
            {
                result = 1;
            }
        }

        int resultDisplay = result;

        if (dataBaseSkill._DamageType.Equals("HEAL"))
        {
            color = Color.green;
            resultDisplay = -resultDisplay;
        }

        if (dataBaseSkill._DamageType.Equals("NONE"))
        {
            ShowDamage = false;
        }


        
        // do stuffs
        string topText = string.Format("{0} uses {1} on {2}", currentUnit.GetUnitName(), dataBaseSkill._Name, unit.GetUnitName());
        string debugText = string.Format("{0} ({1})", topText, skillString);
        Debug.Log(debugText);
        GameMaster.instance.UpdateTopText(topText);

        if (ShowDamage)
        {
            GameMaster.instance.SpawnDamageAt(unit.sprite.transform.position, resultDisplay.ToString(), color);
        }


        unit.HP -= result;

        return dataBaseSkill._AnimationType.Contains("AnimType_MeleeTarget");
    }
}

