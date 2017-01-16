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
	
    TypeEnum SearchForItem(string NameOfItem)
    {
        return SearchForItem(NameOfItem, TypeEnum.ERROR);
    }

    TypeEnum SearchForItem(string NameOfItem, TypeEnum type)
    {
        if (type == TypeEnum.ERROR)
        {
            if (Google2u.CraftngMatsData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.CRAFTINGDATA;

            if (Google2u.CraftingData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.CRAFTINGMATERIAL;

            if (Google2u.HeroesData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.HERO;

            if (Google2u.GambitData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.GAMBIT;

            if (Google2u.EquipmentData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.EQUIPMENT;
        }


        if (type == TypeEnum.CRAFTINGMATERIAL)
        {
            if (Google2u.CraftngMatsData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.CRAFTINGMATERIAL;
        }

        if (type == TypeEnum.CRAFTINGDATA)
        {
            if (Google2u.CraftingData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.CRAFTINGDATA;
        }

        if (type == TypeEnum.EQUIPMENT)
        {
            if (Google2u.EquipmentData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.EQUIPMENT;
        }

        if (type == TypeEnum.HERO)
        {
            if (Google2u.HeroesData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.HERO;
        }

        if (type == TypeEnum.GAMBIT)
        {
            if (Google2u.GambitData.Instance.GetRow(NameOfItem) != null)
                return TypeEnum.GAMBIT;
        }

        return TypeEnum.ERROR;
    }

    public Item GenerateItem(string NameOfItem)
    {
        Item returnValue = null;

        if (Google2u.CraftngMatsData.Instance.GetRow(NameOfItem) != null)
        {
            returnValue = new Item();
            returnValue.CraftingMatsDatabase = Google2u.CraftngMatsData.Instance.GetRow(NameOfItem);
            returnValue.IndexInDatabase = Google2u.CraftngMatsData.Instance.Rows.FindIndex(x => x._ID == returnValue.CraftingMatsDatabase._ID);
        }

        if (Google2u.CraftingData.Instance.GetRow(NameOfItem) != null)
        {
            returnValue = new Item();
            returnValue.CraftingDataDatabase = Google2u.CraftingData.Instance.GetRow(NameOfItem);
            returnValue.IndexInDatabase = Google2u.CraftingData.Instance.Rows.FindIndex(x => x._ID == returnValue.CraftingDataDatabase._ID);
        }

        if (Google2u.HeroesData.Instance.GetRow(NameOfItem) != null)
        {
            returnValue = new Item();
            returnValue.HeroDatabase = Google2u.HeroesData.Instance.GetRow(NameOfItem);
            returnValue.IndexInDatabase = Google2u.HeroesData.Instance.Rows.FindIndex(x => x._ID == returnValue.HeroDatabase._ID);
        }

        if (Google2u.GambitData.Instance.GetRow(NameOfItem) != null)
        {
            returnValue = new Item();
            returnValue.GambitDatabase = Google2u.GambitData.Instance.GetRow(NameOfItem);
            returnValue.IndexInDatabase = Google2u.GambitData.Instance.Rows.FindIndex(x => x._ID == returnValue.GambitDatabase._ID);
        }

        if (Google2u.EquipmentData.Instance.GetRow(NameOfItem) != null)
        {
            returnValue = new Item();
            returnValue.EquipmentDatabase = Google2u.EquipmentData.Instance.GetRow(NameOfItem);
            returnValue.IndexInDatabase = Google2u.EquipmentData.Instance.Rows.FindIndex(x => x._ID == returnValue.EquipmentDatabase._ID);
        }
        
        return returnValue;
    }
}

