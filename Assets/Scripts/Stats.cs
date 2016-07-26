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