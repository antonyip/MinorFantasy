using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class CraftingMatsDataRow
  {
    string _Name;
    string _ID;
    string _Sprite;
    string _end;
    public CraftingMatsDataRow(string Name,string ID,string Sprite,string end)
    {
     _Name = Name;
     _ID = ID;
     _Sprite = Sprite;
     _end = end;
    }
  } // class CraftingMatsDataRow
  public class CraftingMatsData
  {
    private CraftingMatsData()
    {
      Rows.Add(new CraftingMatsDataRow("Tree_Log","Tree_Log","Tree_Log","end"));
    }

    private class NestedCraftingMatsData
    {
      static NestedCraftingMatsData(){}
      internal static readonly CraftingMatsData instance = new CraftingMatsData();
    }

    private static CraftingMatsData instance
    {
      get { return NestedCraftingMatsData.instance;}
    }

    public List<CraftingMatsDataRow> Rows = new List<CraftingMatsDataRow>();

  } // class CraftingMatsData
} // namespace AntTool

