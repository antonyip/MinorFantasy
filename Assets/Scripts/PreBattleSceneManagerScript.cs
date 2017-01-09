using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;

public class PreBattleSceneManagerScript : MonoBehaviour {

    public static PreBattleSceneManagerScript instance;
    public enum PreBattleMode
    {
        NONE,
        TACTICS,
        SWAP,
    };

    public List<GameObject> CurrentTeamButtons;
    public List<GameObject> TeamButtons;
    public GameObject MainTeamContainer;
    public PreBattleMode enPreBattleMode;

    public GameObject ReserveButtonPrefab;
    public GameObject ReserveButtonContainer;
    public List<GameObject> ReserveHeroes = new List<GameObject>();

    public GameObject TacticsScreen;

    // IDEA handle energy in teams?

    void Awake()
    {
        instance = this;
    }

	// Use this for initialization
	void Start () {

        // hack for userdata to be avail on this screen
        DataManager.instance.LoadUser(DataManager.BYPASSUSERLOAD);

        for (int i = 0; i < TeamButtons.Count; i++)
        {
            TeamButtons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
        }

        var dataManager = DataManager.instance;
        int ButtonCounter = 0;
        for (int i = 0; i < DataManager.MAXTEAM; i++)
        {
            for (int j = 0; j < DataManager.MAXUNITPERTEAM; j++)
            {
                var playerChar = dataManager.listOfTeams[i].GetListOfCharacters()[j];

                // todo change face to spriteface
                Debug.Assert(playerChar.databaseChar != null);

                // hack for now because no art and database no update
                if (string.IsNullOrEmpty(playerChar.databaseChar._SpriteIdle) == true)
                {
                    ++ButtonCounter;
                    continue;
                }

                Debug.Assert(string.IsNullOrEmpty(playerChar.databaseChar._SpriteIdle) == false);
                var sprites = Resources.LoadAll<Sprite>(playerChar.databaseChar._SpriteFace);
                var spritesClass = Resources.Load<Sprite>("ICON_"+playerChar.databaseChar._HeroClass);
                //GetComponent<Image>().sprite = sprites[0];
                //GetComponent<Image>().SetNativeSize();

                CurrentTeamButtons[ButtonCounter].GetComponent<TeamHeroButtonScript>().FaceImage.sprite = sprites[0];
                CurrentTeamButtons[ButtonCounter].GetComponent<TeamHeroButtonScript>().ClassImage.sprite = spritesClass;
                // todo handle swapping mechanics of teams
                // remember to handle different team members
                ++ButtonCounter;
            } // end j loop
        } // end i loop

        // generate reserve list
        while(ReserveButtonContainer.transform.childCount > 0)
        {
            Debug.Log("Destorying");
            Destroy(ReserveButtonContainer.transform.GetChild(0));
        }
        
        for (int i = 0; i < dataManager.listOfPlayerCharacters.Count; i++)
        {
            GameObject NewReserveButton = Instantiate(ReserveButtonPrefab) as GameObject;
            NewReserveButton.GetComponentInChildren<ReserveHeroButtonScript>().SetupGUI(i);
            NewReserveButton.transform.SetParent(ReserveButtonContainer.transform);
            NewReserveButton.transform.localScale = Vector3.one;
        }
	} // end start

    void OnEnable()
    {

    }

    public void SelectTeam(int i)
    {
        Debug.Log(i + " team selected!");
        DataManager.instance.selectedTeam = i;
        MainTeamContainer.transform.transform.DOLocalMoveX(i * -1550, DataManager.NORMALANIMATION);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToBattleScene()
    {
        SceneManager.instance.NextSceneName = "BattleScene";
    }

    public void SetTactics()
    {
        enPreBattleMode = PreBattleMode.TACTICS;
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
    }

    public void TeamHeroButtonClicked(int id)
    {
        // if (enPreBattleMode == PreBattleMode.TACTICS)
        {
            TacticsScreen.SetActive(true);
            TacticsScreen.GetComponent<TacticsScreenScript>().Setup(id);

        }
    }
}
