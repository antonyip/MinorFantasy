using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class TacticsScreenScript : MonoBehaviour {

    public GameObject stats;
    public GameObject equips;
    public GameObject skill;
    public Image CharacterFace;
    public GameObject BackButton;
    public List<GameObject> GambitContainers;
    public GameObject SelectionSkillGambitPrefab;
    public Transform SelectionSkillGambitContainer;

    PlayerCharacter currentPC;

    public static TacticsScreenScript instance;

    void Awake()
    {
        instance = this;
    }

    enum TacticsMode
    {
        Strategy,
        ViewStats,
        ViewEquips,
    };

    TacticsMode currentMode = TacticsMode.Strategy;

	// Use this for initialization
	void Start () {
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.SetActive(false);
        stats.SetActive(false);
        equips.SetActive(false);
        skill.SetActive(false);
	}
	
    public void Setup(int id, PreBattleSceneManagerScript.ButtonType buttonType)
    {
        this.gameObject.transform.localScale = Vector3.zero;
        this.gameObject.transform.DOScale(Vector3.one, 0.5f);
        BackButton.SetActive(false);
        Debug.Log("Tactics Screen Setting up:" + id);

        // figure out how to load
        if (buttonType == PreBattleSceneManagerScript.ButtonType.MAIN)
        {
            int teamIndex = id % DataManager.MAXUNITPERTEAM;
            currentPC = DataManager.instance.userData.listOfTeams[DataManager.instance.selectedTeam].GetListOfCharacters()[teamIndex];
        }
        else if (buttonType == PreBattleSceneManagerScript.ButtonType.RESERVE)
        {
            currentPC = DataManager.instance.userData.listOfPlayerCharacters[id];
        }

        // handle actual loading
        Debug.Assert(currentPC != null);
        CharacterFace.sprite = Resources.Load<Sprite>("HeroPrefabs/Faces/" + currentPC.databaseChar._SpriteFace);

        for (int i = 0; i < GambitContainers.Count; i++)
        {
            GambitContainers[i].GetComponent<GambitContainerScript>().SetID(i);
            GambitContainers[i].GetComponent<GambitContainerScript>().SetGambit(currentPC.CurrentGambits[i]);
            GambitContainers[i].GetComponent<GambitContainerScript>().SetSkill(currentPC.CurrentSkills[i]);
            GambitContainers[i].GetComponent<GambitContainerScript>().SetVisible(currentPC.LimitGambits[i]);
        }

    }

    public void CloseTacticsScreen()
    {
        BackButton.SetActive(true);
        this.gameObject.transform.DOScale(Vector3.zero,DataManager.NORMALANIMATION).OnComplete(SetInactive);
        if (currentMode == TacticsMode.Strategy)
        {
            stats.SetActive(false);
            equips.SetActive(false);
        }
        if (currentMode == TacticsMode.ViewStats)
        {
            equips.SetActive(false);
        }
        if (currentMode == TacticsMode.ViewEquips)
        {
            stats.SetActive(false);
        }
    }

    public void SetInactive()
    {
        this.gameObject.SetActive(false);
        equips.transform.localPosition = new Vector3(1600, 0, 0);
        stats.transform.localPosition = new Vector3(-1600, 0, 0);
        equips.SetActive(false);
        stats.SetActive(false);
        currentMode = TacticsMode.Strategy;
    }

    public void ViewStatsClicked()
    {
        if (currentMode == TacticsMode.ViewStats)
        {
            currentMode = TacticsMode.Strategy;
            stats.transform.DOLocalMoveX(-1600, DataManager.NORMALANIMATION);
            if (equips.activeInHierarchy)
            {
                equips.transform.DOLocalMoveX(1600, DataManager.NORMALANIMATION);    
            }
        }
        else
        {
            currentMode = TacticsMode.ViewStats;
            stats.transform.localPosition = new Vector3(-1600, 0, 0);
            stats.SetActive(true);
            stats.transform.DOLocalMoveX(0, DataManager.NORMALANIMATION);
            if (equips.activeInHierarchy)
            {
                equips.transform.DOLocalMoveX(1600, DataManager.NORMALANIMATION);    
            }
        }
    }

    public void ViewEquipmentClicked()
    {
        if (currentMode == TacticsMode.ViewEquips)
        {
            currentMode = TacticsMode.Strategy;
            equips.transform.DOLocalMoveX(1600, DataManager.NORMALANIMATION);
            if (stats.activeInHierarchy)
            {
                stats.transform.DOLocalMoveX(-1600, DataManager.NORMALANIMATION);    
            }
        }
        else
        {
            currentMode = TacticsMode.ViewEquips;
            equips.transform.localPosition = new Vector3(1600, 0, 0);
            equips.SetActive(true);
            equips.transform.DOLocalMoveX(0, DataManager.NORMALANIMATION);
            if (stats.activeInHierarchy)
            {
                stats.transform.DOLocalMoveX(-1600, DataManager.NORMALANIMATION);    
            }
        }
    }

    int gambitButtonID = -1;
    int skillButtonID = -1;


    public enum ButtonType
    {
        Gambit,
        Skill,
    }

    public void GambitButtonClicked(int id)
    {
        gambitButtonID = id;
        skillButtonID = -1;
        skill.SetActive(true);
        skill.transform.DOLocalMoveY(0, DataManager.NORMALANIMATION);
        SetupSelection(ButtonType.Gambit);
    }

    public void SetupSelection(ButtonType buttonType)
    {
        int childCount = SelectionSkillGambitContainer.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Destroy(SelectionSkillGambitContainer.GetChild(i).gameObject);
        }

        if (buttonType == ButtonType.Gambit)
        {
            List<int> GambitLists = DataManager.instance.userData.ListOfGambits;
            for (int i = 0; i < GambitLists.Count; i++)
            {
                GameObject go = Instantiate(SelectionSkillGambitPrefab) as GameObject;
                go.transform.SetParent(SelectionSkillGambitContainer);
                go.transform.localScale = Vector3.one;
                go.GetComponent<GambitSkillButton>().Setup(i);
                // TODO:: change this to the correct
                AntTool.GambitDataRow gdr = AntTool.GambitData.instance.Rows.Find(x => x._ID == GambitLists[i]);
                Debug.Assert(gdr != null);
                go.GetComponent<GambitSkillButton>().SetName(gdr._Name);
            }
        }
        else if (buttonType == ButtonType.Skill)
        {

        }
    }

    public void SkillButtonClicked(int id)
    {
        skillButtonID = id;
        gambitButtonID = -1;
        skill.SetActive(true);
        skill.transform.DOLocalMoveY(0, DataManager.NORMALANIMATION);
        SetupSelection(ButtonType.Skill);
    }

    public void CancelSelectGambitSkill()
    {
        gambitButtonID = -1;
        skillButtonID = -1;
        skill.transform.DOLocalMoveY(-1650, DataManager.NORMALANIMATION).OnComplete(HideSkillGambit);
    }

    void HideSkillGambit()
    {
        skill.SetActive(false);
    }

    public void GambitSkillClicked(int id)
    {
        Debug.Log("Button Clicked:" + id);
    }
}
