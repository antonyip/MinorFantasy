using UnityEngine;
using System.Collections;

public class LibrarySceneManagerScript : MonoBehaviour {

    public static LibrarySceneManagerScript instance;
    public GameObject HeroView;
    public GameObject EquipView;
    public GameObject MobView;
    public GameObject GambitView;
    enum PanelType { HERO, EQUIP, MOB, GAMBIT }

    public GameObject HeroGridView;

    // Use this for initialization
    void Start () {
        //Initialize and populate all panes
        var heroesData = Google2u.HeroesData.Instance.Rows;
        for (int i=0; i<heroesData.Count; i++)
        {
            //Spawn Prefab with index as argument, Data retrieval in the object itself
            Debug.Log(heroesData[i]);
        }

        //Set to Hero Scene First
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        instance = this;
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
