using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteAnimation : MonoBehaviour
{

    public Sprite[] sprites;
    int counter = 1;
    bool Loaded = false;

    public void LoadEnemyImage(string s)
    {
        sprites = Resources.LoadAll<Sprite>(s);
        GetComponent<Image>().sprite = sprites[0];
        GetComponent<Image>().SetNativeSize();
        Loaded = true;
    }

    float totalTimeCounter = 0;
    void Update()
    {
        if (Loaded)
        {
            totalTimeCounter += Time.deltaTime;
            if (totalTimeCounter > 0.16f)
            {
                GetComponent<Image>().sprite = sprites[counter % sprites.Length];
                totalTimeCounter = 0;
                ++counter;
            }
        }
    }
}
