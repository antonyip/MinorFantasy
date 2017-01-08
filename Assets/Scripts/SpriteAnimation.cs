using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteAnimation : MonoBehaviour
{
    public MonoBehaviour AdapterScript;
    int counter = 1;
    bool Loaded = false;
    bool Attacking = false;
    string oldSprite;

    public void LoadEnemyImage(string s)
    {
        AdapterScript.SendMessage("LoadEnemyImageInner", s);
    }

    public void LoadEnemyAttack(string s)
    {
        AdapterScript.SendMessage("LoadEnemyAttackInner",s);
    }
    
    void Update()
    {
        
    }
}
