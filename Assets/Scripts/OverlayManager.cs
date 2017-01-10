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
        if (DataManager.instance.userData != null)
        {
            if (EnergyText != null)
                EnergyText.text = "E: " + DataManager.instance.userData.energy.ToString() + " / " + DataManager.instance.userData.maxEnergy;
        
            if (MoneyText != null)
                MoneyText.text = "$" + DataManager.instance.userData.gold.ToString();
        
            if (GemText != null)
                GemText.text = "G: " + DataManager.instance.userData.gems.ToString();
        }
	}
	        
}
