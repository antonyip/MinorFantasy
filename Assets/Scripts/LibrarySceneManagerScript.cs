using UnityEngine;
using System.Collections;

public class LibrarySceneManagerScript : MonoBehaviour {

    public GameObject HeroView;
    public GameObject EquipView;
    public GameObject MobView;
    public GameObject GambitView;
    enum PanelName { HERO, EQUIP, MOB, GAMBIT };

    // Use this for initialization
    void Start () {
        switchPanel(PanelName.HERO);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToHero()
    {
        switchPanel(PanelName.HERO);
    }

    public void GoToEquip()
    {
        switchPanel(PanelName.EQUIP);
    }

    public void GoToMob()
    {
        switchPanel(PanelName.MOB);
    }

    public void GoToGambit()
    {
        switchPanel(PanelName.GAMBIT);
    }

    void switchPanel(PanelName panelName)
    {
        HeroView.SetActive(false);
        EquipView.SetActive(false);
        MobView.SetActive(false);
        GambitView.SetActive(false);
        switch(panelName)
        {
            case PanelName.EQUIP:
                EquipView.SetActive(true);
                break;
            case PanelName.GAMBIT:
                GambitView.SetActive(true);
                break;
            case PanelName.HERO:
                HeroView.SetActive(true);
                break;
            case PanelName.MOB:
                MobView.SetActive(true);
                break;
            default:
                Debug.Log("Error, invalid panel!");
                break;
        }
    }
}
