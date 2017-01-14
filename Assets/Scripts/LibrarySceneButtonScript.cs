using UnityEngine;
using System.Collections;

public class LibrarySceneButtonScript : MonoBehaviour {

    public static LibrarySceneButtonScript instance;

    //Tabbed Pane Views
    public GameObject Views;
    string[] viewNames = { "Mob View", "Gambit View", "Hero View", "Equip View" };
    GameObject[] viewPanels;

    // Use this for initialization
    void Start () {
        //Save panels for hiding later on
        viewPanels = new GameObject[viewNames.Length];
        for (int i=0; i<viewNames.Length; i++)
        {
            viewPanels[i] = GameObject.Find(viewNames[i]);
        }
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToHero()
    {
        switchPanel("Hero View");
    }

    public void GoToEquip()
    {
        switchPanel("Equip View");
    }

    public void GoToMob()
    {
        switchPanel("Mob View");
    }

    public void GoToGambit()
    {
        switchPanel("Gambit View");
    }

    public void switchPanel(string panelName)
    {
        for (int i=0; i<viewNames.Length; i++)
        {
            viewPanels[i].SetActive(viewNames[i].Equals(panelName));
        }
    }
}
