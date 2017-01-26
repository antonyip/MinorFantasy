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

enum SummonType
{
    Heroes,
    Gambit,
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
    SummonType summonType;


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

    // heroes
    public void SummonHeroButtonPressed1Gold()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gold >= DataManager.GoldForSummoningHeroes)
        {
            Debug.Log("Send Confirmation of gold summon 1");
            summonPaymentType = SummonPaymentType.Gold;
            amountToPay = DataManager.GoldForSummoningHeroes;
            heroesToGet = 1;
            summonType = SummonType.Heroes;
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
            summonType = SummonType.Heroes;
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
            summonType = SummonType.Heroes;
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
            summonType = SummonType.Heroes;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }
    // heroes end

    // gambits
    public void SummonGambitButtonPressed1Gold()
    {
        Debug.Log("Summon Gambit button pressed");
        if (DataManager.instance.userData.gold >= DataManager.GoldForSummoningGambit)
        {
            Debug.Log("Send Confirmation of gold summon 1");
            summonPaymentType = SummonPaymentType.Gold;
            amountToPay = DataManager.GoldForSummoningGambit;
            heroesToGet = 1;
            summonType = SummonType.Gambit;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void SummonGambitButtonPressed11Gold()
    {
        Debug.Log("Summon Gambit button pressed");
        if (DataManager.instance.userData.gold >= DataManager.GoldForSummoningGambit10)
        {
            Debug.Log("Send Confirmation of gold summon 11");
            summonPaymentType = SummonPaymentType.Gold;
            amountToPay = DataManager.GoldForSummoningGambit10;
            heroesToGet = 11;
            summonType = SummonType.Gambit;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void SummonGambitButtonPressed1Gem()
    {
        Debug.Log("Summon Gambit button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GemForSummoningGambit)
        {
            Debug.Log("Send Confirmation of gem summon 1");
            summonPaymentType = SummonPaymentType.Gem;
            amountToPay = DataManager.GemForSummoningGambit;
            heroesToGet = 1;
            summonType = SummonType.Gambit;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }

    public void SummonGambitButtonPressed11Gem()
    {
        Debug.Log("Summon Heroes button pressed");
        if (DataManager.instance.userData.gems >= DataManager.GemForSummoningGambit10)
        {
            Debug.Log("Send Confirmation of gem summon 11");
            summonPaymentType = SummonPaymentType.Gem;
            amountToPay = DataManager.GemForSummoningGambit10;
            heroesToGet = 11;
            summonType = SummonType.Gambit;
            SummonPopup.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough gems");
            SummonPopupNotEnough.SetActive(true);
        }
    }
    // gambits -- end

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

        if (summonType == SummonType.Heroes)
        {
            List<int> HeroesGotten = new List<int>();
            for (int i = 0; i < heroesToGet; i++)
            {
                HeroesGotten.Add(DataManager.CurrentHeroesOdds[UtilsManager.RandomInt(0, DataManager.CurrentHeroesOdds.Count)]);
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
        }
        else if (summonType == SummonType.Gambit)
        {
            List<int> GambitsGotten = new List<int>();
            for (int i = 0; i < heroesToGet; i++)
            {
                GambitsGotten.Add(DataManager.CurrentGambitOdds[UtilsManager.RandomInt(0, DataManager.CurrentGambitOdds.Count)]);
            }

            for (int i = 0; i < heroesToGet; i++)
            {
                ListOfHeroesGottenText.text += (i + 1).ToString() + ". " + AntTool.GambitData.instance.Rows[GambitsGotten[i]]._Name + "\n";
            }
            HeroesGottenPopup.SetActive(true);

            for (int i = 0; i < heroesToGet; i++)
            {
                DataManager.instance.userData.ListOfGambits.Add(new Gambit(GambitsGotten[i]));
            }
        }

        UtilsManager.UpdateUserData();
    }
}
