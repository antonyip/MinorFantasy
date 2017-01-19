using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;
using System.Collections.Generic;
using System;

enum SummonPaymentType 
{
    Free,
    Gold,
    Gem,
};

public class SummonSceneManager : MonoBehaviour {

    public static SummonSceneManager instance;
    public GameObject SummonHeroesPage;
    public GameObject SummonEquipmentPage;
    public GameObject SummonGambitPage;
    public GameObject SummonCraftingMatsPage;
    public GameObject SummonPopup;
    public GameObject SummonPopupNotEnough;
    public GameObject HeroesGottenPopup;
    public Text ListOfHeroesGottenText;

    SummonPaymentType summonPaymentType;
    int amountToPay;
    int heroesToGet;


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
        if (DataManager.instance.userData.gold >= DataManager.GoldForSummoningHeroes)
        {
            Debug.Log("Send Confirmation of gold summon 1");
            summonPaymentType = SummonPaymentType.Gold;
            amountToPay = DataManager.GoldForSummoningHeroes;
            heroesToGet = 1;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void SummonHeroButtonPressed11Gold()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gold >= DataManager.GoldForSummoningHeroes10)
        {
            Debug.Log("Send Confirmation of gold summon 11");
            summonPaymentType = SummonPaymentType.Gold;
            amountToPay = DataManager.GoldForSummoningHeroes10;
            heroesToGet = 11;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void SummonHeroButtonPressed1Gem()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GemForSummoningHeroes)
        {
            Debug.Log("Send Confirmation of gem summon 1");
            summonPaymentType = SummonPaymentType.Gem;
            amountToPay = DataManager.GemForSummoningHeroes;
            heroesToGet = 1;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void SummonHeroButtonPressed11Gem()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GemForSummoningHeroes10)
        {
            Debug.Log("Send Confirmation of gem summon 11");
            summonPaymentType = SummonPaymentType.Gem;
            amountToPay = DataManager.GemForSummoningHeroes10;
            heroesToGet = 11;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void CancelSummon()
    {
        PopUpManager.instance.CloseCurrentPopup();
    }

    public void ConfirmedSummon()
    {
        // TO FINISH UP
        if (summonPaymentType == SummonPaymentType.Gold)
        {
            DataManager.instance.userData.gold -= amountToPay;
        }
        else if (summonPaymentType == SummonPaymentType.Gem)
        {
            DataManager.instance.userData.gems -= amountToPay;
        }
        
        ListOfHeroesGottenText.text = "";
        PopUpManager.instance.CloseCurrentPopup();

        List<int> HeroesGotten = new List<int>();
        for (int i = 0; i < heroesToGet; i++)
        {
            HeroesGotten.Add(DataManager.CurrentHeroesOdds[UtilsManager.RandomInt(0,DataManager.CurrentHeroesOdds.Count)]);
        }

        for (int i = 0; i < heroesToGet; i++)
        {
            ListOfHeroesGottenText.text += (i + 1).ToString() + ". " + AntTool.HeroesData.instance.Rows[HeroesGotten[i]]._Name + "\n";
        }
        HeroesGottenPopup.SetActive(true);

        for (int i = 0; i < heroesToGet; i++)
        {
            PlayerCharacter pc = new PlayerCharacter();
            pc.ID = HeroesGotten[i];
            pc.databaseChar = AntTool.HeroesData.instance.Rows.Find(x => x._ID == pc.ID);
            DataManager.instance.userData.listOfPlayerCharacters.Add(pc);
        }

        UtilsManager.UpdateUserData();
    }
}
