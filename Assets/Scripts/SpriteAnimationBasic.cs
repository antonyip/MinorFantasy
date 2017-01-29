using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteAnimationBasic : MonoBehaviour {

    public Sprite[] sprites;
    int counter = 1;
    bool Loaded = false;
    bool Attacking = false;
    string oldSprite;

    public void LoadEnemyImageInner(string s)
    {
        sprites = Resources.LoadAll<Sprite>(s);
        GetComponent<Image>().sprite = sprites[0];
        GetComponent<Image>().SetNativeSize();
        oldSprite = s;
        Loaded = true;
        counter = 0;
    }

    public void LoadEnemyAttackInner(string s)
    {
        sprites = Resources.LoadAll<Sprite>(s);
        GetComponent<Image>().sprite = sprites[0];
        GetComponent<Image>().SetNativeSize();
        Loaded = true;
        counter = 0;
        Attacking = true;
    }

    // Use this for initialization
    void Start () {
	
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
                        LoadEnemyImageInner(oldSprite);
                        Attacking = false;
                        counter = 0;
                        GameMaster.instance.ReleaseAnimationLock();
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
