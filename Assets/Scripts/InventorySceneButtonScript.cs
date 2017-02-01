using UnityEngine;
using System.Collections;

public class InventorySceneButtonScript : MonoBehaviour {

    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}

    public void GoToHero()
    {
        InventorySceneManager.instance.GoToHero();
    }

    public void GoToEquip()
    {
        InventorySceneManager.instance.GoToEquip();
    }

    public void GoToMob()
    {
        InventorySceneManager.instance.GoToMob();
    }

    public void GoToGambit()
    {
        InventorySceneManager.instance.GoToGambit();
    }


}
