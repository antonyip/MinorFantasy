using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class GambitDataRow
  {
    public string _GambitIndex;
    public string _Name;
    public string _Type;
    public int _ID;
    public string _Description;
    public string _Sprite;
    string _end;
    public GambitDataRow(string GambitIndex,string Name,string Type,int ID,string Description,string Sprite,string end)
    {
     _GambitIndex = GambitIndex;
     _Name = Name;
     _Type = Type;
     _ID = ID;
     _Description = Description;
     _Sprite = Sprite;
     _end = end;
    }
  } // class GambitDataRow
  public class GambitData
  {
    private GambitData()
    {
      Rows.Add(new GambitDataRow("G_1","Any_Enemy","Gambit_Target",1,"Selects an Enemy at random","NONE","end"));
      Rows.Add(new GambitDataRow("G_2","Enemy > 75%","Gambit_Target",2,"Enemy > 75%","NONE","end"));
      Rows.Add(new GambitDataRow("G_3","Enemy > 50%","Gambit_Target",3,"Enemy > 50%","NONE","end"));
      Rows.Add(new GambitDataRow("G_4","Enemy > 25%","Gambit_Target",4,"Enemy > 25%","NONE","end"));
      Rows.Add(new GambitDataRow("G_5","Ally > 75%","Gambit_Target",5,"Ally > 75%","NONE","end"));
      Rows.Add(new GambitDataRow("G_6","Ally > 50%","Gambit_Target",6,"Ally > 50%","NONE","end"));
      Rows.Add(new GambitDataRow("G_7","Ally > 25%","Gambit_Target",7,"Ally > 25%","NONE","end"));
      Rows.Add(new GambitDataRow("G_8","Any_Ally","Gambit_Target",8,"Any_Ally","NONE","end"));
      Rows.Add(new GambitDataRow("G_9","Enemy Team","Gambit_Team",9,"Enemy Team","NONE","end"));
      Rows.Add(new GambitDataRow("G_10","Ally Team","Gambit_Team",10,"Ally Team","NONE","end"));
      Rows.Add(new GambitDataRow("G_11","Burnt Ally","Gambit_Target",11,"Burnt Ally","NONE","end"));
      Rows.Add(new GambitDataRow("G_12","Frozen Ally","Gambit_Target",12,"Frozen Ally","NONE","end"));
      Rows.Add(new GambitDataRow("G_13","Shocked Ally","Gambit_Target",13,"Shocked Ally","NONE","end"));
      Rows.Add(new GambitDataRow("G_14","Burnt Enemy","Gambit_Target",14,"Burnt Enemy","NONE","end"));
      Rows.Add(new GambitDataRow("G_15","Frozen Enemy","Gambit_Target",15,"Frozen Enemy","NONE","end"));
      Rows.Add(new GambitDataRow("G_16","Shocked Enemy","Gambit_Target",16,"Shocked Enemy","NONE","end"));
      Rows.Add(new GambitDataRow("G_17","Do Once Per Battle","Gambit_Team",17,"Do Once Per Battle","NONE","end"));
      Rows.Add(new GambitDataRow("G_18","Every Other Turn","Gambit_Team",18,"Every Other Turn","NONE","end"));
      Rows.Add(new GambitDataRow("G_19","Every 5 turns","Gambit_Team",19,"Every 5 turns","NONE","end"));
      Rows.Add(new GambitDataRow("G_20","Every Turn","Gambit_Team",20,"Every Turn","NONE","end"));
    }

    private class NestedGambitData
    {
      static NestedGambitData(){}
      internal static readonly GambitData instance = new GambitData();
    }

    public static GambitData instance
    {
      get { return NestedGambitData.instance;}
    }

    public List<GambitDataRow> Rows = new List<GambitDataRow>();

  } // class GambitData
} // namespace AntTool

