using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class PreBattleSceneManagerScript : MonoBehaviour {

    public const int SelectEmpty = -1;
    public static PreBattleSceneManagerScript instance;
    public enum PreBattleMode
    {
        NONE,
        TACTICS,
        SWAP,
    };

    public enum ButtonType
    {
        MAIN,
        RESERVE,
    };

    public List<GameObject> CurrentTeamButtons;
    public List<GameObject> TeamButtons;
    public GameObject MainTeamContainer;
    public PreBattleMode enPreBattleMode;

    public GameObject ReserveButtonPrefab;
    public GameObject ReserveButtonContainer;
    public List<GameObject> ReserveHeroesButtons = new List<GameObject>();

    public GameObject TacticsScreen;

    public Button SwapButton;
    public Button TacticsButton;

    public ColorBlock defaultColorBlock;
    public ColorBlock selectedColorBlock;

    public GameObject SelectionButtonIndicator;

    // IDEA handle energy in teams?

    void Awake()
    {
        instance = this;
    }

	// Use this for initialization
	void Start ()
    {

        // hack for userdata to be avail on this screen
        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);

        for (int i = 0; i < TeamButtons.Count; i++)
        {
            TeamButtons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
        }

        // generate reserve list
        ReserveHeroesButtons.Clear();
        while (ReserveButtonContainer.transform.childCount > 0)
        {
            Debug.Log("Destorying");
            Destroy(ReserveButtonContainer.transform.GetChild(0));
        }

        var dataManager = DataManager.instance;
        for (int i = 0; i < dataManager.userData.listOfPlayerCharacters.Count; i++)
        {
            GameObject NewReserveButton = Instantiate(ReserveButtonPrefab) as GameObject;
            NewReserveButton.GetComponentInChildren<ReserveHeroButtonScript>().SetupGUI(i);
            NewReserveButton.transform.SetParent(ReserveButtonContainer.transform);
            NewReserveButton.transform.localScale = Vector3.one;

            // hack for now because no art and database no update
            PlayerCharacter playerChar = dataManager.userData.listOfPlayerCharacters[i];

            Debug.Assert(string.IsNullOrEmpty(playerChar.databaseChar._SpriteIdle) == false);
            var sprites = Resources.Load<Sprite>("HeroPrefabs/Faces/" + playerChar.databaseChar._SpriteFace);
            var spritesClass = Resources.Load<Sprite>("ICON_"+playerChar.databaseChar._HeroClass);

            NewReserveButton.GetComponent<ReserveHeroButtonScript>().FaceImage.sprite = sprites;
            NewReserveButton.GetComponent<ReserveHeroButtonScript>().ClassImage.sprite = spritesClass;

            ReserveHeroesButtons.Add(NewReserveButton);
        }

        UpdateTeamGUI();

        //UpdateDisabledButtons();
    } // end start

    void UpdateTeamGUI()
    {
        var dataManager = DataManager.instance;
        int ButtonCounter = 0;
        for (int i = 0; i < DataManager.MAXTEAM; i++)
        {
            for (int j = 0; j < DataManager.MAXUNITPERTEAM; j++)
            {
                Debug.Assert(dataManager.userData != null);
                Debug.Assert(dataManager.userData.listOfTeams != null);
                Debug.Assert(dataManager.userData.listOfTeams.Count == DataManager.MAXTEAM);
                var playerChar = dataManager.userData.listOfTeams[i].GetListOfCharacters()[j];

                // special case where slot is empty
                if (playerChar == null)
                {
                    var sprites = Resources.Load<Sprite>("HeroPrefabs/Faces/NONE");
                    CurrentTeamButtons[ButtonCounter].GetComponent<TeamHeroButtonScript>().FaceImage.sprite = sprites;
                    CurrentTeamButtons[ButtonCounter].GetComponent<TeamHeroButtonScript>().ClassImage.sprite = sprites;
                }
                else // normal case
                {
                    // todo change face to spriteface
                    Debug.Assert(playerChar.databaseChar != null);

                    // hack for now because no art and database no update
                    if (string.IsNullOrEmpty(playerChar.databaseChar._SpriteIdle) == true)
                    {
                        ++ButtonCounter;
                        continue;
                    }

                    Debug.Assert(string.IsNullOrEmpty(playerChar.databaseChar._SpriteIdle) == false);
                    var sprites = Resources.Load<Sprite>("HeroPrefabs/Faces/" + playerChar.databaseChar._SpriteFace);
                    var spritesClass = Resources.Load<Sprite>("ICON_"+playerChar.databaseChar._HeroClass);

                    CurrentTeamButtons[ButtonCounter].GetComponent<TeamHeroButtonScript>().FaceImage.sprite = sprites;
                    CurrentTeamButtons[ButtonCounter].GetComponent<TeamHeroButtonScript>().ClassImage.sprite = spritesClass;
                    // todo handle swapping mechanics of teams
                    // remember to handle different team members
                }
                ++ButtonCounter;

            } // end j loop
        } // end i loop

    }

    void UpdateDisabledButtons()
    {
        for (int i = 0; i < ReserveButtonContainer.transform.childCount; i++)
        {
            ReserveButtonContainer.transform.GetChild(i).GetComponentInChildren<Button>().interactable = true;
        }

        // set the current team to be disabled;
        for (int i = 0; i < DataManager.MAXUNITPERTEAM; i++)
        {
            int indexOfPlayer = DataManager.instance.userData.listOfTeams[DataManager.instance.selectedTeam].GetListOfIndexes()[i];
            if (indexOfPlayer != Team.EMPTYSLOT)
            {
                ReserveButtonContainer.transform.GetChild(indexOfPlayer).GetComponentInChildren<Button>().interactable = false;
            }
        }
    }

    public void SelectTeam(int i)
    {
        Debug.Log(i + " team selected!");
        DataManager.instance.selectedTeam = i;
        MainTeamContainer.transform.transform.DOLocalMoveX(i * -1550, DataManager.NORMALANIMATION);

        MainSelected = SelectEmpty;
        ReserveSelected = SelectEmpty;

        //UpdateDisabledButtons();
    }
	
    public void ToBattleScene()
    {
        UtilsManager.UpdateUserData();
        SceneManager.instance.NextSceneName = "BattleScene";
    }

    public void SetTactics()
    {
        if (enPreBattleMode == PreBattleMode.TACTICS)
        {
            enPreBattleMode = PreBattleMode.NONE;
        }
        else
        {
            enPreBattleMode = PreBattleMode.TACTICS;
        }
        UpdateButtonColors();
    }

    public void SwapHeroes()
    {
        if (enPreBattleMode == PreBattleMode.SWAP)
        {
            enPreBattleMode = PreBattleMode.NONE;
        }
        else
        {
            enPreBattleMode = PreBattleMode.SWAP;
        }
        UpdateButtonColors();
    }

    public void UpdateButtonColors()
    {
        SwapButton.colors = defaultColorBlock;
        TacticsButton.colors = defaultColorBlock;

        if (enPreBattleMode == PreBattleMode.SWAP)
        {
            SwapButton.colors = selectedColorBlock;
        }

        if (enPreBattleMode == PreBattleMode.TACTICS)
        {
            TacticsButton.colors = selectedColorBlock;
        }
    }

    int MainSelected = SelectEmpty;
    int ReserveSelected = SelectEmpty;

    public void TeamHeroButtonClicked(int pos)
    {
        if (MainSelected == pos)
        {
            // if double click
            TacticsScreen.SetActive(true);
            TacticsScreen.GetComponent<TacticsScreenScript>().Setup(pos, ButtonType.MAIN);
            MainSelected = SelectEmpty;
        }
        else if (ReserveSelected != SelectEmpty)
        {
            MainSelected = pos;
            HandleSwap(MainSelected, ReserveSelected);
            MainSelected = SelectEmpty;
            ReserveSelected = SelectEmpty;
        }
        else
        {
            MainSelected = pos;
        }

        UpdateSelectionButtons();
    }

    private void UpdateSelectionButtons()
    {
        if (MainSelected != SelectEmpty)
        {
            SelectionButtonIndicator.transform.DOScale(Vector3.zero, DataManager.NORMALANIMATION);
            SelectionButtonIndicator.transform.SetParent(CurrentTeamButtons[MainSelected].transform);
            Zoom();
        }
        else if (ReserveSelected != SelectEmpty)
        {
            SelectionButtonIndicator.transform.DOScale(Vector3.zero, DataManager.NORMALANIMATION);
            SelectionButtonIndicator.transform.SetParent(ReserveHeroesButtons[ReserveSelected].transform);
            Zoom();
        }
        else
        {
            SelectionButtonIndicator.transform.DOScale(Vector3.zero, DataManager.NORMALANIMATION);
        }
    }

    private void Zoom()
    {
        SelectionButtonIndicator.transform.localPosition = Vector3.zero;
        SelectionButtonIndicator.transform.localScale = Vector3.zero;
        SelectionButtonIndicator.transform.DOScale(Vector3.one, DataManager.NORMALANIMATION);
    }

    public void ReservedHeroButtonClicked(int pos)
    {
        if (ReserveSelected == pos)
        {
            // if double click
            TacticsScreen.SetActive(true);
            TacticsScreen.GetComponent<TacticsScreenScript>().Setup(pos, ButtonType.RESERVE);
            ReserveSelected = SelectEmpty;
        }
        else if (MainSelected != SelectEmpty)
        {
            ReserveSelected = pos;
            HandleSwap(MainSelected, ReserveSelected);
            MainSelected = SelectEmpty;
            ReserveSelected = SelectEmpty;
        }
        else
        {
            ReserveSelected = pos;
        }

        UpdateSelectionButtons();
    }

    void HandleSwap(int Main, int Reserve)
    {
        Debug.Log("HandleSwap");


        Team t = DataManager.instance.userData.listOfTeams[DataManager.instance.selectedTeam];
        int teamSlotIndex = Main % DataManager.MAXUNITPERTEAM;
        int IsHeroFound = t.FindCharacterIndexInTeam(Reserve);
        if (IsHeroFound == -1) // not found
        { 
            t.SwapCharacter(teamSlotIndex, Reserve);
        }
        else 
        {
            t.SwapCharacter(teamSlotIndex, Reserve);
            t.SwapCharacter(IsHeroFound, Team.EMPTYSLOT);
        }
        // remove duplicate of self

        MainSelected = SelectEmpty;
        ReserveSelected = SelectEmpty;
        UpdateTeamGUI();
        //UpdateDisabledButtons();
    }
}
