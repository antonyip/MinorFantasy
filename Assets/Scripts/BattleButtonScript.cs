using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class BattleButtonScript : MonoBehaviour {

    public Image face;
    public Image red;
    public Image blue;
    public Image yellow;
    public Text myname;

    int ID;

	// Use this for initialization
	public void Setup (int id) {
        ID = id;
    }
	
	// Update is called once per frame
    public void UpdateGUI (Unit pc)
    {
        if (pc.character == null)
        {
            myname.text = "No Character";
            red.transform.DOScaleX(0, DataManager.NORMALANIMATION);
            blue.transform.DOScaleX(0, DataManager.NORMALANIMATION);
            yellow.transform.DOScaleX(0, DataManager.NORMALANIMATION);
            face.sprite = Resources.Load<Sprite>("HeroPrefabs/Faces/NONE");
        }
        else
        {
            Debug.Assert(pc != null);
            Debug.Assert(myname != null);
            myname.text = pc.GetUnitName();
            red.transform.DOScaleX(pc.HPPercent, DataManager.NORMALANIMATION);
            blue.transform.DOScaleX(pc.MPPercent, DataManager.NORMALANIMATION);
            yellow.transform.DOScaleX(pc.SoulPercent, DataManager.NORMALANIMATION);
            face.sprite = Resources.Load<Sprite>("HeroPrefabs/Faces/" + pc.character.playerStats.databaseChar._SpriteFace);
        }

	}

    public void ButtonPressed()
    {
        // should change this..
        if (GetComponentInChildren<DOTweenVisualManager>().enabled)
        {
            GameMaster.instance.GUIButtonPressed(ID);
        }
    }
}

