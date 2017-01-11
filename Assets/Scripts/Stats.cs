using UnityEngine;
using System.Collections;
using System;

public class PlayerCharacter
{
    public int ID;
    public int CurrentLevel;
    public Google2u.HeroesDataRow databaseChar;
}

public class MonsterCharacter
{
    public int ID;
    public int CurrentLevel;
    public Google2u.MobDataRow monsterStats;
}

public sealed class Character
{
    public MonsterCharacter monsterStats;
    public PlayerCharacter playerStats;
    public Google2u.EquipmentDataRow equipmentStats;

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
}