using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class CraftingDataRow
  {
    public string _Name;
    public int _ID;
    public string _Items;
    public string _Sprite;
    string _end;
    public CraftingDataRow(string Name,int ID,string Items,string Sprite,string end)
    {
     _Name = Name;
     _ID = ID;
     _Items = Items;
     _Sprite = Sprite;
     _end = end;
    }
  } // class CraftingDataRow
  public class CraftingData
  {
    private CraftingData()
    {
      Rows.Add(new CraftingDataRow("Tree_Lumber",1,"1,1,1","Tree_Lumber_Image","end"));
    }

    private class NestedCraftingData
    {
      static NestedCraftingData(){}
      internal static readonly CraftingData instance = new CraftingData();
    }

    public static CraftingData instance
    {
      get { return NestedCraftingData.instance;}
    }

    public List<CraftingDataRow> Rows = new List<CraftingDataRow>();

  } // class CraftingData
} // namespace AntTool

