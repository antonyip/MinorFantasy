using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkillTargetButtonScript : MonoBehaviour {

    int ID;
    public Text skillName;
    AntTool.SkillDataRow skillSelected;

    public enum MODE
    {
        Skill,
        Target
    };

    MODE mode;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SkillButtonPressed()
    {
        if (mode == MODE.Skill)
        {
            GameMaster.instance.SkillButtonPressed(skillSelected, ID);
        }
        else
        {
            GameMaster.instance.TargetButtonPressed(ID);
        }
    }

    public void SetupSkill(AntTool.SkillDataRow skill, int id)
    {
        ID = id;
        skillSelected = skill;

        skillName.text = skill._Name;
        mode = MODE.Skill;
    }

    public void SetupTarget(string textToDisplay, int id)
    {
        ID = id;
        skillName.text = textToDisplay;
        mode = MODE.Target;
    }
}
