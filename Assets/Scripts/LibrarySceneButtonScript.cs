using UnityEngine;
using System.Collections;

public class LibrarySceneButtonScript : MonoBehaviour {

    public static LibrarySceneButtonScript instance;

    // Use this for initialization
    void Start () {

	}

    void Awake()
    {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToHero()
    {
        LibrarySceneManagerScript.instance.GoToHero();
    }

    public void GoToEquip()
    {
        LibrarySceneManagerScript.instance.GoToEquip();
    }

    public void GoToMob()
    {
        LibrarySceneManagerScript.instance.GoToMob();
    }

    public void GoToGambit()
    {
        LibrarySceneManagerScript.instance.GoToGambit();
    }


}
