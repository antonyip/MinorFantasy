using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class LevelDataRow
  {
    public string _NameIndex;
    public string _Name;
    public int _ID;
    public string _Battle1;
    public string _Battle2;
    public string _Battle3;
    public string _Battle4;
    public string _Battle5;
    public string _Loot;
    public string _Description;
    public int _EnergyRequirement;
    public string _BackgroundSprite;
    public int _Gold;
    public LevelDataRow(string NameIndex,string Name,int ID,string Battle1,string Battle2,string Battle3,string Battle4,string Battle5,string Loot,string Description,int EnergyRequirement,string BackgroundSprite,int Gold)
    {
     _NameIndex = NameIndex;
     _Name = Name;
     _ID = ID;
     _Battle1 = Battle1;
     _Battle2 = Battle2;
     _Battle3 = Battle3;
     _Battle4 = Battle4;
     _Battle5 = Battle5;
     _Loot = Loot;
     _Description = Description;
     _EnergyRequirement = EnergyRequirement;
     _BackgroundSprite = BackgroundSprite;
     _Gold = Gold;
    }
  } // class LevelDataRow
  public class LevelData
  {
    private LevelData()
    {
      Rows.Add(new LevelDataRow("L_1","NONAMEYET",1,"1","1,1","","","","","",2,"desert",100));
      Rows.Add(new LevelDataRow("L_2","NONAMEYET",2,"1","1,1,1","","","","","",2,"desert",200));
      Rows.Add(new LevelDataRow("L_3","NONAMEYET",3,"1,2,1","2,1,2","","","","","",3,"desert",300));
      Rows.Add(new LevelDataRow("L_4","NONAMEYET",4,"2,2","1,2,1,1","","","","","",3,"desert",400));
      Rows.Add(new LevelDataRow("L_5","NONAMEYET",5,"2,2,2","1,1,1,1","2,3,2","","","","",3,"desert",500));
      Rows.Add(new LevelDataRow("L_6","NONAMEYET",6,"2,1,1,2","1,3,1","","","","","",4,"swamp",600));
      Rows.Add(new LevelDataRow("L_7","NONAMEYET",7,"2,3,3,2","1,2,1,2,1","","","","","",4,"swamp",700));
      Rows.Add(new LevelDataRow("L_8","NONAMEYET",8,"1,1,1","1,1,4,1,1","","","","","",4,"swamp",800));
      Rows.Add(new LevelDataRow("L_9","NONAMEYET",9,"2,1,4,1","2,3,3,3,2","","","","","",4,"swamp",900));
      Rows.Add(new LevelDataRow("L_10","NONAMEYET",10,"1,1,1,1,1","1,3,4,3,1","3,4,5,4,3","","","","",5,"swamp",1000));
      Rows.Add(new LevelDataRow("L_11","NONAMEYET",11,"2,2,2,2","2,3,4,3,2","3,1,1,1,3","","","","",5,"NONE",1100));
      Rows.Add(new LevelDataRow("L_12","NONAMEYET",12,"2,1,2,1,2","4,2,4,2,4","1,8,3,8,1","","","","",5,"NONE",1200));
      Rows.Add(new LevelDataRow("L_13","NONAMEYET",13,"5,4,1,4,5","3,3,8,8,3","2,3,2,3,4","","","","",5,"NONE",1300));
      Rows.Add(new LevelDataRow("L_14","NONAMEYET",14,"1,1,5,8,1,1","2,1,2,8,8","1,3,5,5,5","","","","",6,"NONE",1400));
      Rows.Add(new LevelDataRow("L_15","NONAMEYET",15,"1,1,1,1","2,8,5,8,2","2,3,4,4,3,2","1,6,8,6,1","","","",6,"NONE",1500));
      Rows.Add(new LevelDataRow("L_16","NONAMEYET",16,"1,1,1,1,1,1","2,3,4,3,4,8","1,4,2,6,2,1","","","","",6,"NONE",1600));
      Rows.Add(new LevelDataRow("L_17","NONAMEYET",17,"2,2,2,2,2,2","3,5,3,5,3","1,5,5,8,5,5","","","","",7,"NONE",1700));
      Rows.Add(new LevelDataRow("L_18","NONAMEYET",18,"3,3,3,3,3,3","3,3,8,6,6,9","2,6,8,9,6,2","","","","",7,"NONE",1800));
      Rows.Add(new LevelDataRow("L_19","NONAMEYET",19,"4,4,4,4,4,4","7,7,7","3,4,5,5,4,3","","","","",8,"NONE",1900));
      Rows.Add(new LevelDataRow("L_20","NONAMEYET",20,"5,5,5,5,5,5","2,1,7,1,2","2,2,3,3,2,2","6,8,7,7,6,9","","","",10,"NONE",2000));
    }

    private class NestedLevelData
    {
      static NestedLevelData(){}
      internal static readonly LevelData instance = new LevelData();
    }

    public static LevelData instance
    {
      get { return NestedLevelData.instance;}
    }

    public List<LevelDataRow> Rows = new List<LevelDataRow>();

  } // class LevelData
} // namespace AntTool

