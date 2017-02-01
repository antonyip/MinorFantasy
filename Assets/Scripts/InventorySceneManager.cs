using UnityEngine;
using System.Collections;

public class InventorySceneManager : MonoBehaviour
{

    public static InventorySceneManager instance;
    public GameObject HeroView;
    public GameObject EquipView;
    public GameObject MobView;
    public GameObject GambitView;

    enum PanelType { HERO, EQUIP, MOB, GAMBIT }

    public Transform InventoryContainer;
    public GameObject ItemPrefab;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        HandleInventory();
    }

    void HandleInventory()
    {
        // cleanup
        int childs = InventoryContainer.childCount;
        for (int i = 0; i < childs; i++)
        {
            Destroy(InventoryContainer.GetChild(i).gameObject);
        }

        // find objects and populate
        Debug.Assert(DataManager.instance != null);
        Debug.Assert(DataManager.instance.userData != null);

        var Inventory = DataManager.instance.userData.Inventory;
        var InventoryList = Inventory.ToList();
        for (int i = 0; i < InventoryList.Count; i++)
        {
            GameObject go = Instantiate(ItemPrefab) as GameObject;
            go.transform.SetParent(InventoryContainer);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            go.GetComponent<ItemScript>().Setup(i, InventoryList[i].Key, InventoryList[i].Value);
        }
    }

    void switchPanel(PanelType PanelName)
    {
        HeroView.SetActive(false);
        EquipView.SetActive(false);
        MobView.SetActive(false);
        GambitView.SetActive(false);
        switch (PanelName)
        {
            case PanelType.EQUIP:
                EquipView.SetActive(true);
                break;
            case PanelType.GAMBIT:
                GambitView.SetActive(true);
                break;
            case PanelType.HERO:
                HandleInventory();
                HeroView.SetActive(true);
                break;
            case PanelType.MOB:
                MobView.SetActive(true);
                break;
            default:
                Debug.Log("Error, invalid panel!");
                break;
        }
    }

    public void GoToHero()
    {
        switchPanel(PanelType.HERO);
    }

    public void GoToEquip()
    {
        switchPanel(PanelType.EQUIP);
    }

    public void GoToMob()
    {
        switchPanel(PanelType.MOB);
    }

    public void GoToGambit()
    {
        switchPanel(PanelType.GAMBIT);
    }
}
