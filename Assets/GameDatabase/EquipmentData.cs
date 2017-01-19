using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class EquipmentDataRow
  {
    public string _EIndex;
    public string _Name;
    public int _ID;
    public string _Description;
    public int _Level;
    public int _HP;
    public int _HPGrowth;
    public int _MP;
    public int _MPGrowth;
    public int _STR;
    public int _STRGrowth;
    public int _DEX;
    public int _DEXGrowth;
    public int _INT;
    public int _INTGrowth;
    public int _LUK;
    public int _LUKGrowth;
    public int _Speed;
    public int _Att;
    public int _Def;
    public int _AttGrowth;
    public int _DefGrowth;
    public int _MAtt;
    public int _MAttGrowth;
    public int _MDef;
    public int _MDefGrowth;
    public int _FAtt;
    public int _FAttGrowth;
    public int _IAtt;
    public int _IAttGrowth;
    public int _TAtt;
    public int _TAttGrowth;
    public int _FDef;
    public int _IDef;
    public int _TDef;
    public int _FRes;
    public int _IRes;
    public int _TRes;
    public int _FDefGrowth;
    public int _IDefGrowth;
    public int _TDefGrowth;
    public int _FResGrowth;
    public int _IResGrowth;
    public int _TResGrowth;
    public string _Skills;
    public string _DropNormal;
    public string _DropRare;
    public string _DropLegend;
    public string _SpriteIdle;
    public string _SpriteAttack;
    public string _SpriteMagic;
    public string _SpriteIcon;
    public string _SoundDeath;
    public string _SoundAttack;
    public int _Energy;
    public int _EnergyGrowth;
    public string _Story;
    string _end;
    public EquipmentDataRow(string EIndex,string Name,int ID,string Description,int Level,int HP,int HPGrowth,int MP,int MPGrowth,int STR,int STRGrowth,int DEX,int DEXGrowth,int INT,int INTGrowth,int LUK,int LUKGrowth,int Speed,int Att,int Def,int AttGrowth,int DefGrowth,int MAtt,int MAttGrowth,int MDef,int MDefGrowth,int FAtt,int FAttGrowth,int IAtt,int IAttGrowth,int TAtt,int TAttGrowth,int FDef,int IDef,int TDef,int FRes,int IRes,int TRes,int FDefGrowth,int IDefGrowth,int TDefGrowth,int FResGrowth,int IResGrowth,int TResGrowth,string Skills,string DropNormal,string DropRare,string DropLegend,string SpriteIdle,string SpriteAttack,string SpriteMagic,string SpriteIcon,string SoundDeath,string SoundAttack,int Energy,int EnergyGrowth,string Story,string end)
    {
     _EIndex = EIndex;
     _Name = Name;
     _ID = ID;
     _Description = Description;
     _Level = Level;
     _HP = HP;
     _HPGrowth = HPGrowth;
     _MP = MP;
     _MPGrowth = MPGrowth;
     _STR = STR;
     _STRGrowth = STRGrowth;
     _DEX = DEX;
     _DEXGrowth = DEXGrowth;
     _INT = INT;
     _INTGrowth = INTGrowth;
     _LUK = LUK;
     _LUKGrowth = LUKGrowth;
     _Speed = Speed;
     _Att = Att;
     _Def = Def;
     _AttGrowth = AttGrowth;
     _DefGrowth = DefGrowth;
     _MAtt = MAtt;
     _MAttGrowth = MAttGrowth;
     _MDef = MDef;
     _MDefGrowth = MDefGrowth;
     _FAtt = FAtt;
     _FAttGrowth = FAttGrowth;
     _IAtt = IAtt;
     _IAttGrowth = IAttGrowth;
     _TAtt = TAtt;
     _TAttGrowth = TAttGrowth;
     _FDef = FDef;
     _IDef = IDef;
     _TDef = TDef;
     _FRes = FRes;
     _IRes = IRes;
     _TRes = TRes;
     _FDefGrowth = FDefGrowth;
     _IDefGrowth = IDefGrowth;
     _TDefGrowth = TDefGrowth;
     _FResGrowth = FResGrowth;
     _IResGrowth = IResGrowth;
     _TResGrowth = TResGrowth;
     _Skills = Skills;
     _DropNormal = DropNormal;
     _DropRare = DropRare;
     _DropLegend = DropLegend;
     _SpriteIdle = SpriteIdle;
     _SpriteAttack = SpriteAttack;
     _SpriteMagic = SpriteMagic;
     _SpriteIcon = SpriteIcon;
     _SoundDeath = SoundDeath;
     _SoundAttack = SoundAttack;
     _Energy = Energy;
     _EnergyGrowth = EnergyGrowth;
     _Story = Story;
     _end = end;
    }
  } // class EquipmentDataRow
  public class EquipmentData
  {
    private EquipmentData()
    {
      Rows.Add(new EquipmentDataRow("E_01","NOEQUIPMENT",0,"NOEQUIPMENT",1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1","Tree_Log","Tree_Log","Tree_Log","NONE","NONE","NONE","NONE","NONE","NONE",1,1,"1","end"));
    }

    private class NestedEquipmentData
    {
      static NestedEquipmentData(){}
      internal static readonly EquipmentData instance = new EquipmentData();
    }

    public static EquipmentData instance
    {
      get { return NestedEquipmentData.instance;}
    }

    public List<EquipmentDataRow> Rows = new List<EquipmentDataRow>();

  } // class EquipmentData
} // namespace AntTool

