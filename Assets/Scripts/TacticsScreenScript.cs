using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TacticsScreenScript : MonoBehaviour {

    public GameObject stats;
    public GameObject equips;

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
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Setup(int id, PreBattleSceneManagerScript.ButtonType buttonType)
    {
        this.gameObject.transform.localScale = Vector3.zero;
        this.gameObject.transform.DOScale(Vector3.one, 0.5f);
        Debug.Log("Tactics Screen Setting up:" + id);
    }

    public void CloseTacticsScreen()
    {
        this.gameObject.transform.DOScale(Vector3.zero,0.5f).OnComplete(SetInactive);
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
}
