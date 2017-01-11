using UnityEngine;
using System.Collections;

public class LoginCheckerScript : MonoBehaviour {


    public GameObject MainMenu;
    public GameObject LoginMenu;
    public GameObject ReloginPopup;
    public GameObject LoginPopup;

    public static bool doOnce = true;

    // Use this for initialization
    void Start ()
    {
        if (doOnce)
        {
            if (PlayerPrefs.GetString(PlayerPrefStrings.UserUsername,"") != "")
            {
                ReloginPopup.SetActive(true);
            }
            doOnce = false;
        }
        InvokeRepeating("CheckLoggedIn",0.5f,1.0f);
    }

    void CheckLoggedIn()
    {
        if (PlayerIOManager.instance.LoggedIn)
        {
            ReloginPopup.SetActive(false);
            LoginPopup.SetActive(false);
            MainMenu.SetActive(true);
            LoginMenu.SetActive(false);
        }
        else
        {
            LoginMenu.SetActive(true);
            MainMenu.SetActive(false);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
