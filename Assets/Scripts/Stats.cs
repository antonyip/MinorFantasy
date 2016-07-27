using UnityEngine;
using System.Collections;
using System;

public class PlayerCharacter
{
    public int ID;
    public int CurrentLevel;
    public Google2u.HeroesDataRow databaseChar;

    public PlayerCharacter()
    {

    }
}

public sealed class Character
{

    public PlayerCharacter playerStats;
    public Google2u.MobDataRow monsterStats;
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
            return monsterStats._Name;
        }

        if (IsPlayer())
        {
            return playerStats.databaseChar._Name;
        }

        return "INVALID";
    }

    internal int GetMAtt()
    {
        if (IsMonster())
        {
            return monsterStats._MAtt + monsterStats._Level * monsterStats._MAttGrowth;
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
            return monsterStats._STR + monsterStats._Level * monsterStats._STRGrowth;
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
            return monsterStats._Def + monsterStats._Level * monsterStats._DefGrowth;
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
            return monsterStats._Att + monsterStats._Level * monsterStats._AttGrowth;
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
            return monsterStats._HP + monsterStats._Level * monsterStats._HPGrowth;
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
            return monsterStats._DEX + monsterStats._Level * monsterStats._DEXGrowth;
        }

        if (IsPlayer())
        { 
            return playerStats.databaseChar._DEX + playerStats.CurrentLevel * playerStats.databaseChar._DEXGrowth;
        }

        return 0;
    }
}