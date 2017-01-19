using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class MobDataRow
  {
    public string _IndexName;
    public string _Name;
    public int _ID;
    public string _Description;
    public string _Story;
    public string _SpriteClass;
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
    public string _SpriteFace;
    public string _SoundDeath;
    public string _SoundAttack;
    public int _Exp;
    string _end;
    public MobDataRow(string IndexName,string Name,int ID,string Description,string Story,string SpriteClass,int Level,int HP,int HPGrowth,int MP,int MPGrowth,int STR,int STRGrowth,int DEX,int DEXGrowth,int INT,int INTGrowth,int LUK,int LUKGrowth,int Speed,int Att,int Def,int AttGrowth,int DefGrowth,int MAtt,int MAttGrowth,int MDef,int MDefGrowth,int FAtt,int FAttGrowth,int IAtt,int IAttGrowth,int TAtt,int TAttGrowth,int FDef,int IDef,int TDef,int FRes,int IRes,int TRes,int FDefGrowth,int IDefGrowth,int TDefGrowth,int FResGrowth,int IResGrowth,int TResGrowth,string Skills,string DropNormal,string DropRare,string DropLegend,string SpriteIdle,string SpriteAttack,string SpriteMagic,string SpriteFace,string SoundDeath,string SoundAttack,int Exp,string end)
    {
     _IndexName = IndexName;
     _Name = Name;
     _ID = ID;
     _Description = Description;
     _Story = Story;
     _SpriteClass = SpriteClass;
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
     _SpriteFace = SpriteFace;
     _SoundDeath = SoundDeath;
     _SoundAttack = SoundAttack;
     _Exp = Exp;
     _end = end;
    }
  } // class MobDataRow
  public class MobData
  {
    private MobData()
    {
      Rows.Add(new MobDataRow("M_0","NOENEMY",0,"No Enemy","A Pityful dust bunny","TANK",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"0","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_1","Orx",1,"A string of malicious bytes","A Pityful dust bunny","TANK",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_2","Goochon",2,"A Pile of Dust","RedSquare","DPS",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","RedSquare","RedSquare","RedSquare","RedSquare","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_3","Okteeb",3,"A Pile of Dust","BlueSquare","DPS",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","BlueSquare","BlueSquare","BlueSquare","BlueSquare","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_4","Zoxo",4,"A Pile of Dust","A Pityful dust bunny","DPS",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_5","Ooleen",5,"A Pile of Dust","A Pityful dust bunny","DPS",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_6","Deepaqi",6,"A Pile of Dust","A Pityful dust bunny","MAGE",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_7","Equthinq",7,"A Pile of Dust","A Pityful dust bunny","MAGE",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_8","Xyloorq",8,"A Pile of Dust","A Pityful dust bunny","HEAL",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_9","Youpo",9,"A Pile of Dust","A Pityful dust bunny","HEAL",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:1","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
      Rows.Add(new MobDataRow("M_10","Oitu",10,"A Pile of Dust","A Pityful dust bunny","BOSS",1,10,1,10,1,10,1,10,1,10,1,10,1,10,10,10,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"1:2","Tree_Log","Tree_Log","Tree_Log","DustBunny","DustBunny","DustBunny","DustBunny","NONE","NONE",10,"end"));
    }

    private class NestedMobData
    {
      static NestedMobData(){}
      internal static readonly MobData instance = new MobData();
    }

    public static MobData instance
    {
      get { return NestedMobData.instance;}
    }

    public List<MobDataRow> Rows = new List<MobDataRow>();

  } // class MobData
} // namespace AntTool

