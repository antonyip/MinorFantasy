using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOptionsButton : MonoBehaviour {

    int ID;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Setup(int id)
    {
        if (id == 0)
        {
            GetComponentInChildren<Text>().text = "Gambits";
            UpdateAutoButton();
        }

        if (id == 1)
        {
            GetComponentInChildren<Text>().text = "RepeatLast";
            GetComponent<Button>().interactable = false;
        }

        if (id == 2)
        {
            GetComponentInChildren<Text>().text = "Options";
        }

        ID = id;
    }

    void UpdateAutoButton()
    {
        if (GameMaster.instance.AutoMode == true)
        {
            GetComponent<Image>().color = UtilsManager.hexToColor("5DFF00A6");
            GameMaster.instance.AutoOn();
        }
        else
        {
            GetComponent<Image>().color = Color.white;            
        }
    }

    public void OnButtonClick()
    {
        if (ID == 0)
        {
            if (GameMaster.instance.AutoMode == true)
            {
                GameMaster.instance.AutoMode = false;
                DataManager.instance.userData.AutoMode = false;
            }
            else
            {
                GameMaster.instance.AutoMode = true;
                DataManager.instance.userData.AutoMode = true;
            }
            UpdateAutoButton();
        }

        if (ID == 1)
        {
            GetComponentInChildren<Text>().text = "Tactics";
        }

        if (ID == 2)
        {
            GameMaster.instance.ShowOptions();
        }
    }
}
