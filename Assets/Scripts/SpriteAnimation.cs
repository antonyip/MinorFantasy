using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class SpriteAnimation : MonoBehaviour
{
    public MonoBehaviour AdapterScript;
    GameObject simpleHealthBar;

    void Start()
    {
        simpleHealthBar = Instantiate(Resources.Load<GameObject>("SimpleHealthBar")) as GameObject;
        simpleHealthBar.transform.SetParent(transform);
        simpleHealthBar.transform.localScale = Vector3.one;
        simpleHealthBar.transform.localPosition = new Vector3(-90,-140);
    }

    public void LoadEnemyImage(string s)
    {
        AdapterScript.SendMessage("LoadEnemyImageInner", s);
    }

    public void LoadEnemyAttack(string s)
    {
        AdapterScript.SendMessage("LoadEnemyAttackInner",s);
    }
    
    public void UpdateScreenHealthBar(float percent)
    {
        simpleHealthBar.GetComponent<SimpleHealthBarScript>().UpdateScreenHealthBar(percent);
    }

}
