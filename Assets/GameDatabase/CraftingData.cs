using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class CraftingDataRow
  {
    string _Name;
    string _ID;
    string _Items;
    string _Sprite;
    string _end;
    public CraftingDataRow(string Name,string ID,string Items,string Sprite,string end)
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
      Rows.Add(new CraftingDataRow("Tree_Lumber","Tree_Lumber","Tree_Lumber","Tree_Lumber","end"));
    }

    private class NestedCraftingData
    {
      static NestedCraftingData(){}
      internal static readonly CraftingData instance = new CraftingData();
    }

    private static CraftingData instance
    {
      get { return NestedCraftingData.instance;}
    }

    public List<CraftingDataRow> Rows = new List<CraftingDataRow>();

  } // class CraftingData
} // namespace AntTool

