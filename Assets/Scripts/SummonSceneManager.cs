using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SummonSceneManager : MonoBehaviour {

    public static SummonSceneManager instance;
    public GameObject SummonHeroesPage;
    public GameObject SummonEquipmentPage;
    public GameObject SummonGambitPage;
    public GameObject SummonCraftingMatsPage;

    Vector3 OutsidePoint = new Vector3(1600,0,0);

    void Awake()
    {
        instance = this;
    }

	// Use this for initialization
	void Start ()
    {
        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);

        switch (DataManager.instance.SummonPageSettings)
        {
            case SummonPageSetting.HEROES:
                GoHeroes();
                break;
            case SummonPageSetting.CRAFTING:
                GoCraftingMats();
                break;
            case SummonPageSetting.EQUIPMENT:
                GoEquip();
                break;
            case SummonPageSetting.GAMBITS:
                GoGambit();
                break;
            default:
                break;
        }
	}

	// Update is called once per frame
	void Update ()
    {
	
	}

    public void GoHeroes()
    {
        SummonHeroesPage.transform.DOLocalMove(Vector3.zero, DataManager.LONGANIMATION);
        SummonEquipmentPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonGambitPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonCraftingMatsPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
    }

    public void GoEquip()
    {
        SummonHeroesPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonEquipmentPage.transform.DOLocalMove(Vector3.zero, DataManager.LONGANIMATION);
        SummonGambitPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonCraftingMatsPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
    }

    public void GoGambit()
    {
        SummonHeroesPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonEquipmentPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonGambitPage.transform.DOLocalMove(Vector3.zero, DataManager.LONGANIMATION);
        SummonCraftingMatsPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
    }

    public void GoCraftingMats()
    {
        SummonHeroesPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonEquipmentPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonGambitPage.transform.DOLocalMove(OutsidePoint, DataManager.LONGANIMATION);
        SummonCraftingMatsPage.transform.DOLocalMove(Vector3.zero, DataManager.LONGANIMATION);
    }

    public void SummonHeroButtonPressed1Gold()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GoldForSummoningHeroes)
        {
            Debug.Log("Send Confirmation of gold summon 1");
        }
        else
        {
            Debug.Log("Not enough gems");
        }
    }

    public void SummonHeroButtonPressed11Gold()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GoldForSummoningHeroes10)
        {
            Debug.Log("Send Confirmation of gold summon 11");
        }
        else
        {
            Debug.Log("Not enough gems");
        }
    }

    public void SummonHeroButtonPressed1Gem()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GemForSummoningHeroes)
        {
            Debug.Log("Send Confirmation of gem summon 1");
        }
        else
        {
            Debug.Log("Not enough gems");
        }
    }

    public void SummonHeroButtonPressed11Gem()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GemForSummoningHeroes10)
        {
            Debug.Log("Send Confirmation of gem summon 11");
        }
        else
        {
            Debug.Log("Not enough gems");
        }
    }
}
