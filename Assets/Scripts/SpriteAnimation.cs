using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteAnimation : MonoBehaviour
{

    public Sprite[] sprites;
    int counter = 1;
    bool Loaded = false;
    bool Attacking = false;
    string oldSprite;
    public void LoadEnemyImage(string s)
    {
        sprites = Resources.LoadAll<Sprite>(s);
        GetComponent<Image>().sprite = sprites[0];
        GetComponent<Image>().SetNativeSize();
        oldSprite = s;
        Loaded = true;
        counter = 0;
    }

    public void LoadEnemyAttack(string s)
    {
        sprites = Resources.LoadAll<Sprite>(s);
        GetComponent<Image>().sprite = sprites[0];
        GetComponent<Image>().SetNativeSize();
        Loaded = true;
        counter = 0;
        Attacking = true;
    }

    float totalTimeCounter = 0;
    void Update()
    {
        if (Loaded)
        {
            totalTimeCounter += Time.deltaTime;
            if (totalTimeCounter > 0.16f)
            {
                if (Attacking)
                {
                    if (counter >= sprites.Length)
                    {
                        LoadEnemyImage(oldSprite);
                        Attacking = false;
                        counter = 0;
                        GameMaster.AnimationLock = false;
                        return;
                    }
                    GetComponent<Image>().sprite = sprites[counter];
                }
                else
                {
                    GetComponent<Image>().sprite = sprites[counter % sprites.Length];
                }
                totalTimeCounter = 0;
                ++counter;
            }
        }
    }
}
