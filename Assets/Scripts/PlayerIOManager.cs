using UnityEngine;
using System.Collections;
using PlayerIOClient;
using System;

public class PlayerIOManager : MonoBehaviour {

	public static PlayerIOManager instance;

	string gameID = "doomzcastle-qyld5t9hqk6fnkeqimrgxa";
	string username;
	string password;
	string email;
	int mode = 0;
	bool _loggedin = false;
	public bool LoggedIn
	{	
		get {return _loggedin;}
	}


	Client client;
	PlayerIOError ioerror;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start ()
	{
		username = PlayerPrefs.GetString(PlayerPrefStrings.UserUsername, "");
		password = PlayerPrefs.GetString(PlayerPrefStrings.UserPassword, "");
		email = PlayerPrefs.GetString(PlayerPrefStrings.UserEmail, "");
		mode = PlayerPrefs.GetInt(PlayerPrefStrings.UserLoginMode, 0);

		if (username != "" && password != "" && mode == 1)
		{
			Login(username,password,DoNothing,DoNothingFailure);
		}
	}

	Action cbFunctionSuccess;
	Action<string> cbFunctionFailure;

	public void Login(string _username, string _password, Action callbackFunctionSuccess, Action<string> callbackFunctionFailure)
	{
		username = _username;
		password = _password;
		mode = 1;
		cbFunctionSuccess = callbackFunctionSuccess;
		cbFunctionFailure = callbackFunctionFailure;
		Debug.Log("LoginSimple");
		PlayerIO.QuickConnect.SimpleConnect(gameID,username,password,null,OnConnect,OnConnectFailure);

        // Load the Userdata
        DataManager.instance.LoadUser(_username);
	}

	public void Register(string _username, string _password, string _email, Action callbackFunctionSuccess, Action<string> callbackFunctionFailure)
	{
		username = _username;
		password = _password;
		email = _email;
		mode = 1;
		cbFunctionSuccess = callbackFunctionSuccess;
		cbFunctionFailure = callbackFunctionFailure;
		Debug.Log("RegisterSimple");
		PlayerIO.QuickConnect.SimpleRegister(gameID,username,password,_email,null,null,null,null,null,OnRegister,OnRegisterFail);
	}

	public void Logout()
	{
		//client.Logout();
		PlayerPrefs.SetString(PlayerPrefStrings.UserUsername,"");
		PlayerPrefs.SetString(PlayerPrefStrings.UserPassword,"");
		PlayerPrefs.SetString(PlayerPrefStrings.UserEmail, "");
		PlayerPrefs.SetInt(PlayerPrefStrings.UserLoginMode, 0);
		_loggedin = false;
	}

	void OnRegisterFail(PlayerIOError _client)
	{
		Debug.Log(_client.ErrorCode.ToString());
		cbFunctionFailure(_client.ErrorCode.ToString());
	}

	void OnRegister(Client _client)
	{
		Debug.Log("Registered");
		client = _client;
		Login(username,password,cbFunctionSuccess, cbFunctionFailure);
	}

	void DoNothing()
	{
		// simpleconnect;
		mode = 1;
	}

	void DoNothingFailure(string s)
	{
		// simpleconnect;
		Debug.Log("Shouldnt happen");
		mode = 0;
	}

	void OnConnect(Client _client)
	{
		//Debug.Log(client.ConnectUserId);
		Debug.Log("Connected");
		client = _client;
		mode = 1;
		PlayerPrefs.SetString(PlayerPrefStrings.UserUsername,username);
		PlayerPrefs.SetString(PlayerPrefStrings.UserPassword,password);
		PlayerPrefs.SetString(PlayerPrefStrings.UserEmail, email);
		PlayerPrefs.SetInt(PlayerPrefStrings.UserLoginMode, mode);
		_loggedin = true;
		cbFunctionSuccess();
	}

	void OnConnectFailure(PlayerIOError _client)
	{
		Debug.Log(_client.ErrorCode.ToString());
		cbFunctionFailure(_client.ErrorCode.ToString());
	}

	void SearchLevel()
	{
		//client.BigDB.Load("CustomLevels","creator2",OnSearchLevel);
		client.BigDB.LoadRange("CustomLevels","creator", new object[]{"antonyip"},null,null,1000,OnSearchByName);
	}

	void OnSearchByName(DatabaseObject[] _databaseObject)
	{
		/*
		foreach (DatabaseObject DO in _databaseObject)
			Debug.Log(DO);
		*/
	}

	void OnSearchLevel(DatabaseObject _databaseObject)
	{
		string leveldata = _databaseObject.GetString("leveldata");
		Debug.Log(leveldata);
	}

	public void SubmitCurrentLevel()
	{
		DatabaseObject DO = new DatabaseObject();
		DO.Set("attempts",0);
		DO.Set("creator",username);
		DO.Set("fail",0);
		DO.Set("pass",0);
		DO.Set("leveldata",DataManager.instance.selectedLevel.levelData);
		string uid = username+"_"+System.DateTime.Now.Ticks;
		client.BigDB.CreateObject("CustomLevels",uid,DO,OnCreateLevelData,FailCreateLevelData);
		DebugConsole.Log("Submitted");
	}

	void CreateLevel()
	{
		DatabaseObject DO = new DatabaseObject();
		DO.Set("attempts",0);
		DO.Set("creator",username);
		DO.Set("fail",0);
		DO.Set("pass",0);
		DO.Set("leveldata","222222222");
		client.BigDB.CreateObject("CustomLevels","creator2",DO,OnCreateLevelData,FailCreateLevelData);
	}

	void OnCreateLevelData(DatabaseObject _databaseObject)
	{
		Debug.Log("Created");
	}
	
	void FailCreateLevelData(PlayerIOError _error)
	{
		Debug.Log(_error.Message);
	}
}
