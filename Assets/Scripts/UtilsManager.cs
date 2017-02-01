using UnityEngine;
using System.Collections;

public enum TARGETTYPE
{
    SELF,
    ALLY,
    ALLIES,
    ENEMY,
    ENEMIES,
    ALL,
    INDIVIDUAL,
};

public class UtilsManager
{

    public static void UpdateUserData()
    {
        PlayerIOManager.instance.SaveToPlayerIODatabase();
    }

    public static Color hexToColor(string hex)
    {
        hex = hex.Replace ("0x", "");//in case the string is formatted 0xFFFFFF
        hex = hex.Replace ("#", "");//in case the string is formatted #FFFFFF
        byte a = 255;//assume fully visible unless specified in hex
        byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
        //Only use alpha if the string has enough characters
        if(hex.Length == 8){
            a = byte.Parse(hex.Substring(6,2), System.Globalization.NumberStyles.HexNumber);
        }
        return new Color32(r,g,b,a);
    }

    static bool randomInit = false;
    static void initRandom()
    {
        if (randomInit == false)
        {
            Random.seed = 9999;
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
