using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour
{

    public static ItemManager instance;
    // Use this for initialization
    void Awake()
    {
        instance = this;
    }

    public Item GenerateItem(string NameOfItem)
    {
        Item returnValue = null;

        if (AntTool.CraftingMatsData.instance.Rows.Find(x => x._Name.Equals(NameOfItem)) != null)
        {
            returnValue = new Item();
            returnValue.CraftingMatsDatabase = AntTool.CraftingMatsData.instance.Rows.Find(x => x._Name.Equals(NameOfItem));
            returnValue.IndexInDatabase = AntTool.CraftingMatsData.instance.Rows.FindIndex(x => x._ID == returnValue.CraftingMatsDatabase._ID);
        }

        if (AntTool.CraftingData.instance.Rows.Find(x => x._Name.Equals(NameOfItem)) != null)
        {
            returnValue = new Item();
            returnValue.CraftingDataDatabase = AntTool.CraftingData.instance.Rows.Find(x => x._Name.Equals(NameOfItem));
            returnValue.IndexInDatabase = AntTool.CraftingData.instance.Rows.FindIndex(x => x._ID == returnValue.CraftingDataDatabase._ID);
        }

        if (AntTool.HeroesData.instance.Rows.Find(x => x._Name.Equals(NameOfItem)) != null)
        {
            returnValue = new Item();
            returnValue.HeroDatabase = AntTool.HeroesData.instance.Rows.Find(x => x._Name.Equals(NameOfItem));
            returnValue.IndexInDatabase = AntTool.HeroesData.instance.Rows.FindIndex(x => x._ID == returnValue.HeroDatabase._ID);
        }

        if (AntTool.GambitData.instance.Rows.Find(x => x._Name.Equals(NameOfItem)) != null)
        {
            returnValue = new Item();
            returnValue.GambitDatabase = AntTool.GambitData.instance.Rows.Find(x => x._Name.Equals(NameOfItem));
            returnValue.IndexInDatabase = AntTool.GambitData.instance.Rows.FindIndex(x => x._ID == returnValue.GambitDatabase._ID);
        }

        if (AntTool.EquipmentData.instance.Rows.Find(x => x._Name.Equals(NameOfItem)) != null)
        {
            returnValue = new Item();
            returnValue.EquipmentDatabase = AntTool.EquipmentData.instance.Rows.Find(x => x._Name.Equals(NameOfItem));
            returnValue.IndexInDatabase = AntTool.EquipmentData.instance.Rows.FindIndex(x => x._ID == returnValue.EquipmentDatabase._ID);
        }
        
        return returnValue;
    }
}

