using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleJSON;

public class InventoryContainer : Compressable
{
    Dictionary<int, int> ListOfItems = new Dictionary<int, int>();

    public string Compress()
    {
        var returnValue = JSON.Parse("{}");
        foreach (var item in ListOfItems)
        {
            if (item.Value > 0)
            { 
                returnValue["Items"][-1] = item.Key + "=" + item.Value;
            }
        }
        return returnValue.ToString();
    }

    public void Decompress(string deString)
    {
        var json = JSON.Parse(deString);
        int counter = 0;
        ListOfItems.Clear();
        while (json["Items"][counter] != null)
        {
            string[] decompstring = json["Items"][counter].ToString().Split('=');
            ListOfItems.Add(int.Parse(decompstring[0]), int.Parse(decompstring[1]));
            ++counter;
        }
    }

    public bool Add(int DataBaseID)
    {
        if (ListOfItems.ContainsKey(DataBaseID))
        {
            // add limit here to return false if u want
            ListOfItems[DataBaseID] += 1;
        }
        else
        {
            ListOfItems.Add(DataBaseID, 1);
        }
        return true;
    }

    public bool Remove(int DataBaseID)
    {
        if (ListOfItems.ContainsKey(DataBaseID) && ListOfItems[DataBaseID] > 0)
        {
            ListOfItems[DataBaseID] -= 1;
            return true;
        }
        return false;
    }
}
