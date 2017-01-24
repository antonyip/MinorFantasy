using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GambitSkillButton : MonoBehaviour {

    int ID;
    public Text textToShow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Setup(int idToBe)
    {
        ID = idToBe;
    }

    public void SetName(string name)
    {
        textToShow.text = name;
    }

    public void GambitSkillClick()
    {
        TacticsScreenScript.instance.GambitSkillClicked(ID);
    }

    public void Cancel()
    {
        TacticsScreenScript.instance.CancelSelectGambitSkill();
    }
}
