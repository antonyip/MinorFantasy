using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using SimpleJSON;

public class PlayerCharacter : Compressable
{
    public string Compress()
    {
        var returnValue = JSON.Parse("{}");
        returnValue["ID"] = ID.ToString();
        
        returnValue["CurrentLevel"] = CurrentLevel.ToString();

        for (int i = 0; i < CurrentGambits.Count; i++)
        {
            returnValue["Gambits"][-1] = CurrentGambits[i].ToString();
        }

        for (int i = 0; i < CurrentSkills.Count; i++)
        {
            returnValue["Skills"][-1] = CurrentSkills[i].ToString();
        }

        for (int i = 0; i < LimitGambits.Count; i++)
        {
            returnValue["LimitGambits"][-1] = LimitGambits[i].ToString();
        }

        return returnValue.ToString();
    }

    public void Decompress(string deString)
    {
        var json = JSON.Parse(deString);
        if (json["ID"] != null) ID = json["ID"].AsInt;
        if (json["CurrentLevel"] != null) CurrentLevel = json["CurrentLevel"].AsInt;

        CurrentGambits.Clear();
        CurrentSkills.Clear();
        LimitGambits.Clear();

        int counter = 0;
        while(json["Skills"][counter] != null)
        {
            CurrentSkills.Add(json["Skills"][counter].AsInt);
            ++counter;
        }

        counter = 0;
        while (json["Gambits"][counter] != null)
        {
            CurrentGambits.Add(json["Gambits"][counter].AsInt);
            ++counter;
        }

        counter = 0;
        while (json["LimitGambits"][counter] != null)
        {
            LimitGambits.Add(json["LimitGambits"][counter].AsBool);
            ++counter;
        }

        // other init 
        databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == ID);
    }

    public int ID;
    public int CurrentLevel = 1;

    /// <summary>
    /// The current gambits that are assigned to this player character
    /// </summary>
    public List<int> CurrentGambits = new List<int>();

    /// <summary>
    /// The current skills that are assigned to this player character
    /// </summary>
    public List<int> CurrentSkills = new List<int>();

    /// <summary>
    /// The limit of gambits that this character has
    /// </summary>
    public List<bool> LimitGambits = new List<bool>();

    public AntTool.HeroesDataRow databaseChar;

    public EquipmentContainer Equipments = new EquipmentContainer();

    public List<int> AvailableSkills()
    {
        List<int> returnValue = new List<int>();

        if (databaseChar == null)
            databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == ID);

        string[] ListOfSkillsAvail = databaseChar._Skills.Split('=');

        for (int i = 0; i < ListOfSkillsAvail.Length; i++)
        {
            if (!string.IsNullOrEmpty(ListOfSkillsAvail[i]))
            {
                returnValue.Add(int.Parse(ListOfSkillsAvail[i]));
            }
        }

        return returnValue;
    }

    public PlayerCharacter()
    {
        while (CurrentGambits.Count < 10)
        {
            CurrentGambits.Add(-1);
        }

        while (CurrentSkills.Count < 10)
        {
            CurrentSkills.Add(-1);
        }

        while (LimitGambits.Count < 5)
        {
            LimitGambits.Add(true);
        }

        while (LimitGambits.Count < 10)
        {
            LimitGambits.Add(false);
        }
    }
}

public class MonsterCharacter
{
    public int ID;
    public int CurrentLevel;
    public AntTool.MobDataRow monsterStats;
}

public sealed class Character
{
    public MonsterCharacter monsterStats;
    public PlayerCharacter playerStats;

    public bool IsMonster()
    {
        return monsterStats != null;
    }

    public bool IsPlayer()
    {
        return playerStats != null;
    }

    public string GetName()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._Name;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._Name;
        }

        return "INVALID";
    }

    internal int GetCurrentLevel()
    {
        if (IsMonster())
        {
            return monsterStats.CurrentLevel;
        }

        if (IsPlayer())
        {
            return playerStats.CurrentLevel;
        }

        return 0;
    }

    internal int GetMAtt()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._MAtt + monsterStats.CurrentLevel * monsterStats.monsterStats._MAttGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._MAtt + playerStats.CurrentLevel * playerStats.databaseChar._MAttGrowth;
        }
        return 0;
    }

    internal int GetStr()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._STR + monsterStats.CurrentLevel * monsterStats.monsterStats._STRGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._STR + playerStats.CurrentLevel * playerStats.databaseChar._STRGrowth;
        }
        return 0;
    }

    internal int GetPDef()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._Def + monsterStats.CurrentLevel * monsterStats.monsterStats._DefGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._Def + playerStats.CurrentLevel * playerStats.databaseChar._DefGrowth;
        }
        return 0;
    }

    internal int GetPAtt()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._Att + monsterStats.CurrentLevel * monsterStats.monsterStats._AttGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._Att + playerStats.CurrentLevel * playerStats.databaseChar._AttGrowth;
        }
        return 0;
    }

    internal int GetHP()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._HP + monsterStats.CurrentLevel * monsterStats.monsterStats._HPGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._HP + playerStats.CurrentLevel * playerStats.databaseChar._HPGrowth;
        }

        return 0;
    }

    internal int GetMP()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._MP + monsterStats.CurrentLevel * monsterStats.monsterStats._MPGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._MP + playerStats.CurrentLevel * playerStats.databaseChar._MPGrowth;
        }

        return 0;
    }

    internal int GetSoul()
    {
        /*
        if (IsMonster())
        {
            return monsterStats.monsterStats._MP + monsterStats.CurrentLevel * monsterStats.monsterStats._MPGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._MP + playerStats.CurrentLevel * playerStats.databaseChar._MPGrowth;
        }
        */

        return 1;
    }

    internal int GetFAtt()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._FAtt + monsterStats.CurrentLevel * monsterStats.monsterStats._FAttGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._FAtt + playerStats.CurrentLevel * playerStats.databaseChar._FAttGrowth;
        }

        return 0;
    }

    internal int GetMDef()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._MDef + monsterStats.CurrentLevel * monsterStats.monsterStats._MDefGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._MDef + playerStats.CurrentLevel * playerStats.databaseChar._MDefGrowth;
        }

        return 0;
    }

    internal int GetInt()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._INT + monsterStats.CurrentLevel * monsterStats.monsterStats._INTGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._INT + playerStats.CurrentLevel * playerStats.databaseChar._INTGrowth;
        }

        return 0;
    }

    internal int GetFDef()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._FDef + monsterStats.CurrentLevel * monsterStats.monsterStats._FDefGrowth;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._FDef + playerStats.CurrentLevel * playerStats.databaseChar._FDefGrowth;
        }

        return 0;
    }


    public float GetSpeed()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._DEX + monsterStats.CurrentLevel * monsterStats.monsterStats._DEXGrowth;
        }

        if (IsPlayer())
        { 
            return playerStats.databaseChar._DEX + playerStats.CurrentLevel * playerStats.databaseChar._DEXGrowth;
        }

        return 0;
    }

    public Item GetLoot(Unit DeadUnit, float BonusChanceDrop, float BonusChanceNormal, float BonusChanceRare, float BonusChanceLegend)
    {
        Item returnValue = null;
        if (IsMonster())
        {
            float rolldropchance = UtilsManager.RandomFloat(0, 1) + BonusChanceDrop;
            Debug.Log("DropChance:" + rolldropchance.ToString());
            // manager to get loot
            if (rolldropchance > DataManager.BASEDROPCHANCE)
            {
                float rollitemchance = UtilsManager.RandomFloat(0, 1);
                Debug.Log("ItemChance:" + rollitemchance.ToString());
                if (rollitemchance + BonusChanceLegend > DataManager.BASELEGENDDROP)
                {
                    returnValue = ItemManager.instance.GenerateItem(DeadUnit.character.GetLegendDropName());
                }
                else if (rollitemchance + BonusChanceRare > DataManager.BASERAREDROP)
                {
                    returnValue = ItemManager.instance.GenerateItem(DeadUnit.character.GetRareDropName());
                }
                else
                {
                    returnValue = ItemManager.instance.GenerateItem(DeadUnit.character.GetNormalDropName());
                }
            }
        }

        return returnValue;
    }

    public string GetLegendDropName()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._DropLegend;
        }

        return "NONE";
    }

    public string GetRareDropName()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._DropRare;
        }

        return "NONE";
    }

    public string GetNormalDropName()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._DropNormal;
        }

        return "NONE";
    }

    public int GetExperience()
    {
        if (IsMonster())
        {
            return monsterStats.monsterStats._Exp;
        }

        return 0;
    }
}
