using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class BattleButtonScript : MonoBehaviour {

    public Image face;
    public Image red;
    public Image blue;
    public Image yellow;
    public Text name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    public void UpdateGUI (Unit pc)
    {
        if (pc.character == null)
        {
            name.text = "No Character";
            red.transform.DOScaleX(0, DataManager.NORMALANIMATION);
            blue.transform.DOScaleX(0, DataManager.NORMALANIMATION);
            yellow.transform.DOScaleX(0, DataManager.NORMALANIMATION);
        }
        else
        {
            name.text = pc.GetUnitName();
            red.transform.DOScaleX(pc.HPPercent, DataManager.NORMALANIMATION);
            //blue.transform.DOScaleX(pc.HPPercent, DataManager.NORMALANIMATION);
            //yellow.transform.DOScaleX(pc.HPPercent, DataManager.NORMALANIMATION);
        }

	}
}

