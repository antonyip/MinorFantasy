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

    void Start()
    {
        GetComponentInChildren<Text>().color = Color.white;
    }

    /// <summary>
    /// hack to bypass the login system - user data is not saved
    /// </summary>
	public void OnButtonClick()
	{
        //SceneManager.instance.NextSceneName = "MapScene";
        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);
        LoginMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void GoCreditsScreen()
    {
        SceneManager.instance.NextSceneName = "Credits";
    }

    public void GoMainMenu()
    {
        SceneManager.instance.NextSceneName = "MainMenu";
    }

    public void GoSummonPageHeroes()
    {
        SceneManager.instance.NextSceneName = "SummonScene";
        DataManager.instance.SummonPageSettings = SummonPageSetting.HEROES;
    }

    public void GoSummonPageCrafting()
    {
        SceneManager.instance.NextSceneName = "SummonScene";
        DataManager.instance.SummonPageSettings = SummonPageSetting.CRAFTING;
    }

    public void GoSummonPageEquipment()
    {
        SceneManager.instance.NextSceneName = "SummonScene";
        DataManager.instance.SummonPageSettings = SummonPageSetting.EQUIPMENT;
    }

    public void GoSummonPageGambits()
    {
        SceneManager.instance.NextSceneName = "SummonScene";
        DataManager.instance.SummonPageSettings = SummonPageSetting.GAMBITS;
    }

    public void GoManageHeroes()
    {
        SceneManager.instance.NextSceneName = "PreBattleScene";
        DataManager.instance.PreBattlePageSettings = PreBattlePage.MANAGEHEROES;
    }

    public void GoLibrary()
    {
        SceneManager.instance.NextSceneName = "LibraryScene";
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
