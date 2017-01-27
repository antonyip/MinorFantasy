using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverlayManager : MonoBehaviour {

    public static OverlayManager instance;
    public Text EnergyText;
    public Text MoneyText;
    public Text GemText;

    void Awake()
    {
        instance = this;
    }

	public void Update()
    {
        // this is so badly done, think of how to factor this better.
        if (DataManager.instance!= null && DataManager.instance.userData != null)
        {
            if (EnergyText != null)
                EnergyText.text = "E: " + DataManager.instance.userData.Energy.ToString() + " / " + DataManager.instance.userData.MaxEnergy;
        
            if (MoneyText != null)
                MoneyText.text = "$" + DataManager.instance.userData.Gold.ToString();
        
            if (GemText != null)
                GemText.text = "G: " + DataManager.instance.userData.Gems.ToString();
        }
	}
	        
}
