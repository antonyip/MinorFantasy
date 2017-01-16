using UnityEngine;
using System.Collections;

public enum TypeEnum
{
    ERROR,
    CRAFTINGDATA,
    CRAFTINGMATERIAL,
    EQUIPMENT,
    HERO,
    GAMBIT,
}

public class Item
{
    public TypeEnum ItemType = TypeEnum.ERROR;
    public Google2u.CraftngMatsDataRow CraftingMatsDatabase = null;
    public Google2u.CraftingDataRow    CraftingDataDatabase = null;
    public Google2u.HeroesDataRow      HeroDatabase = null;
    public Google2u.GambitDataRow      GambitDatabase = null;
    public Google2u.EquipmentDataRow   EquipmentDatabase = null;
    public int IndexInDatabase = -1;

    public GameObject sprite;
}

