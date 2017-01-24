using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class PlayerCharacter
{
    public int ID;
    public int CurrentLevel;
    public List<int> CurrentGambits = new List<int>();
    public List<int> CurrentSkills = new List<int>();
    public List<bool> LimitGambits = new List<bool>();
    public AntTool.HeroesDataRow databaseChar;

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
    public AntTool.EquipmentDataRow equipmentStats;

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
