using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class SimpleHealthBarScript : MonoBehaviour {

    public Image LifeBar;
    public void UpdateScreenHealthBar(float percent)
    {
        if (percent < 0)
            percent = 0;

        if (percent > 1)
            percent = 1;

        LifeBar.transform.DOScaleX(percent, DataManager.NORMALANIMATION);
    }
}

