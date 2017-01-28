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
    public AntTool.CraftingMatsDataRow CraftingMatsDatabase = null;
    public AntTool.CraftingDataRow    CraftingDataDatabase = null;
    public AntTool.HeroesDataRow      HeroDatabase = null;
    public AntTool.GambitDataRow      GambitDatabase = null;
    public AntTool.EquipmentDataRow   EquipmentDatabase = null;
    public int IDInDatabase = -1;

    public GameObject sprite;
}

