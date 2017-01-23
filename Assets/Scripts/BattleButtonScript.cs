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

	// Use this for initialization
	void Start () {
	
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
        }
        else
        {
            myname.text = pc.GetUnitName();
            red.transform.DOScaleX(pc.HPPercent, DataManager.NORMALANIMATION);
            blue.transform.DOScaleX(pc.MPPercent, DataManager.NORMALANIMATION);
            yellow.transform.DOScaleX(pc.SoulPercent, DataManager.NORMALANIMATION);
        }

	}
}

