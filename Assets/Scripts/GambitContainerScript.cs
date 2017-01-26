using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GambitContainerScript : MonoBehaviour {

    public Text GambitText;
    public Text SkillText;

    int ID;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetID(int idToBe)
    {
        ID = idToBe;
    }

    public void SetGambit(int indexInUserDatabase)
    {
        Debug.Log("SetGambit:" + indexInUserDatabase);
        if (indexInUserDatabase != -1)
        {
            Gambit g = DataManager.instance.userData.ListOfGambits.GetGambitAt(indexInUserDatabase);
            GambitText.text = AntTool.GambitData.instance.Rows.Find(x => x._ID == g.PositionInGambitDatabase)._Name;
        }
        else
        {
            GambitText.text = "?";
        }
    }

    public void SetSkill(int indexInSkillDatabase)
    {
        if (indexInSkillDatabase != -1)
        {
            SkillText.text = AntTool.SkillData.instance.Rows.Find(x => x._ID == indexInSkillDatabase)._Name;
        }
        else
        {
            SkillText.text = "?";
        }
    }

    public void SetVisible(bool visible)
    {
        if (visible)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    public void GambitButtonClicked()
    {
        TacticsScreenScript.instance.GambitButtonClicked(ID);
    }

    public void SkillButtonClicked()
    {
        TacticsScreenScript.instance.SkillButtonClicked(ID);
    }
}

