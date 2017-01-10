using UnityEngine;
using System.Collections;

public class UtilsManager
{
    public static void UpdateUserData()
    {

    }


    static bool randomInit = false;
    static void initRandom()
    {
        if (randomInit == false)
        {
            Random.seed = 32767;
            randomInit = true;
        }
    }

    public static int RandomInt(int minValue, int maxValue)
    {
        initRandom();

        float dummyRandom = Random.value;

        // just to make sure that its not 1.0f
        while (dummyRandom == 1.0f)
        {
            dummyRandom = Random.value;
        }

        int offset = Mathf.CeilToInt(dummyRandom * (maxValue - minValue));
        return minValue + offset;
    }

    public static float RandomFloat(float minValue, float maxValue)
    {
        initRandom();

        float dummyRandom = Random.value;

        // just to make sure that its not 1.0f
        while (dummyRandom == 1.0f)
        {
            dummyRandom = Random.value;
        }

        float offset = dummyRandom * (maxValue - minValue);
        return minValue + offset;
    }
}
