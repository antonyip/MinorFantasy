using UnityEngine;
using System.Collections;

public class SummonSceneButtonsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoHeroes()
    {
        SummonSceneManager.instance.GoHeroes();
    }

    public void GoEquip()
    {
        SummonSceneManager.instance.GoEquip();
    }

    public void GoGambit()
    {
        SummonSceneManager.instance.GoGambit();
    }

    public void GoCraftingMats()
    {
        SummonSceneManager.instance.GoCraftingMats();
    }

    public void SummonHeroButtonPressed1Gold()
    {
        SummonSceneManager.instance.SummonHeroButtonPressed1Gold();
    }

    public void SummonHeroButtonPressed11Gold()
    {
        SummonSceneManager.instance.SummonHeroButtonPressed11Gold();
    }

    public void SummonHeroButtonPressed1Gem()
    {
        SummonSceneManager.instance.SummonHeroButtonPressed1Gem();
    }

    public void SummonHeroButtonPressed11Gem()
    {
        SummonSceneManager.instance.SummonHeroButtonPressed11Gem();
    }
}
