using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GambitSkillButton : MonoBehaviour {

    int ButtonPosition;
    int UserDatabasePosition;
    public Text textToShow;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetupGambit(int buttonPosition, int userDatabasePosition, bool HasBeenUsedElsewhere)
    {
        ButtonPosition = buttonPosition;
        UserDatabasePosition = userDatabasePosition;
        GetComponent<Button>().interactable = !HasBeenUsedElsewhere;
    }

    public void SetupSkill(int buttonPosition, int skillID)
    {
        ButtonPosition = buttonPosition;
        UserDatabasePosition = skillID;
    }

    public void SetName(string name)
    {
        textToShow.text = name;
    }

    public void GambitSkillClick()
    {
        TacticsScreenScript.instance.GambitSkillClicked(ButtonPosition, UserDatabasePosition);
    }

    public void Cancel()
    {
        TacticsScreenScript.instance.CancelSelectGambitSkill();
    }
}
