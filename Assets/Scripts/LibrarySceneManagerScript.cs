using UnityEngine;
using System.Collections;

public class LibrarySceneManagerScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
        //Initialize and populate all panes
        Google2u.HeroesData heroesData = Google2u.HeroesData.Instance;
        foreach (string row in heroesData.rowNames)
        {
            Google2u.HeroesDataRow data = heroesData.GetRow(row);
            Debug.Log(data);
        }

        //Set to Hero Scene First
        LibrarySceneButtonScript.instance.GoToHero();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

}
