using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuButton : MonoBehaviour
{
	public InputField LoginAccountUsername;
	public InputField LoginAccountPassword;
	public InputField LoginAccountPasswordRepeat;
	public InputField LoginAccountEmail;
	public GameObject LoginAccountScreen;
	public GameObject LoginMenu;
	public GameObject MainMenu;

    /// <summary>
    /// hack to bypass the login system - user data is not saved
    /// </summary>
	public void OnButtonClick()
	{
        //SceneManager.instance.NextSceneName = "MapScene";
        DataManager.instance.LoadUser("BYPASSUSER");
        PlayerIOManager.instance.BypassLogin();
        LoginMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

	public void RegisterAccount()
	{

	}

	public void RegisterAccountRegister()
	{
		string username = LoginAccountUsername.text;
		string password = LoginAccountPassword.text;
		string passwordRepeat = LoginAccountPasswordRepeat.text;
		string email = LoginAccountEmail.text;
		
		if (password != passwordRepeat)
		{
			// pop up password not matching error
		}
		LoginAccountScreen.SetActive(false);
		
		PlayerIOManager.instance.Register(username,password,email,OnSimpleSuccess,OnSimpleFailure);
	}

	public void CancelLogin()
	{
		PlayerIOManager.instance.Logout();
	}

	public void LoginAccount()
	{

	}

	public void LoginFacebook()
	{

	}

	public void LoginKongregate()
	{

	}

	public void GoToLevelEditor()
	{
		//SceneManager.CurrentGameMode = SceneManager.GameMode.EditorMode;
		//SceneManager.instance.NextSceneName = "GameLevel";
	}

	public void Continue()
	{
		SceneManager.instance.NextSceneName = "MapScene";
	}

	public void Logout()
	{
		PlayerIOManager.instance.Logout();
		SceneManager.instance.NextSceneName = "MainMenu";
	}


	public void LoginAccountLogin()
	{
		string username = LoginAccountUsername.text;
		string password = LoginAccountPassword.text;
		LoginAccountScreen.SetActive(false);
		PlayerIOManager.instance.Login(username,password, OnSimpleSuccess, OnSimpleFailure);
	}

	void OnSimpleSuccess()
	{
		Debug.Log("MainMenuButtonLoginSuccess");
		LoginMenu.SetActive(false);
		MainMenu.SetActive(true);
	}

	void OnSimpleFailure(string s)
	{
		Debug.Log("menuerror:  "+ s);
	}
}
