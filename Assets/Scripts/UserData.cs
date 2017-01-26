using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

public class UserDataContainer
{
    public UserData userData;

    public string Compress()
    {
        XmlSerializer xmls = new XmlSerializer(typeof(UserData));
        var xml = "";

        using (var sww = new StringWriter())
        {
            using (XmlWriter writer = XmlWriter.Create(sww))
            {
                xmls.Serialize(writer, userData);
                xml = sww.ToString();
            }
        }

        Debug.Log(xml);

        return xml;
    }

    public void Decompress(string deString)
    {
        var deser = new XmlSerializer(typeof(UserData));
        StringReader sr = new StringReader(deString);
        userData = deser.Deserialize(sr) as UserData;
    }
}

[System.Serializable]
public class UserData
{
    public int Gold;
    public int Gems;
    public int Energy;
    public int MaxEnergy;
    public int PvpEnergy;
    public float MAPBONUSMULTIPLIER;

    // stored as an index to the database
    public GambitContainer ListOfGambits = new GambitContainer();
    public List<int> ListOfCraftingMats = new List<int>();
    public List<int> ListOfEquipment = new List<int>();

    public List<Team> listOfTeams = new List<Team>();
    public List<PlayerCharacter> listOfPlayerCharacters = new List<PlayerCharacter>();

    public UserData()
    {
        Gold = 50000;
        Gems = 2000;
        Energy = 50;
        MaxEnergy = 50;
        PvpEnergy = 0;
        MAPBONUSMULTIPLIER = 1.0f;
    }
}
