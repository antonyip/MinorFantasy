using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteAnimation : MonoBehaviour
{

    public Sprite[] sprites;
    int counter = 0;
    void Awake()
    {
        // load all frames in fruitsSprites array
        sprites = Resources.LoadAll<Sprite>("DustBunny");
    }

    void Start()
    {
        // create the object
        GetComponent<Image>().sprite = sprites[0];
    }

    float totalTimeCounter = 0;

    void Update()
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
