using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class HeroesDataRow
  {
    public string _IndexName;
    public string _Name;
    public int _ID;
    public string _Gender;
    public string _Description;
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
    public string _SpriteIdle;
    public string _SpriteAttack;
    public string _SpriteMagic;
    public string _SpriteFace;
    public string _HeroClass;
    public string _SoundDeath;
    public string _SoundAttack;
    public int _Energy;
    public int _EnergyGrowth;
    public string _Story;
    public HeroesDataRow(string IndexName,string Name,int ID,string Gender,string Description,int HP,int HPGrowth,int MP,int MPGrowth,int STR,int STRGrowth,int DEX,int DEXGrowth,int INT,int INTGrowth,int LUK,int LUKGrowth,int Speed,int Att,int Def,int AttGrowth,int DefGrowth,int MAtt,int MAttGrowth,int MDef,int MDefGrowth,int FAtt,int FAttGrowth,int IAtt,int IAttGrowth,int TAtt,int TAttGrowth,int FDef,int IDef,int TDef,int FRes,int IRes,int TRes,int FDefGrowth,int IDefGrowth,int TDefGrowth,int FResGrowth,int IResGrowth,int TResGrowth,string Skills,string SpriteIdle,string SpriteAttack,string SpriteMagic,string SpriteFace,string HeroClass,string SoundDeath,string SoundAttack,int Energy,int EnergyGrowth,string Story)
    {
     _IndexName = IndexName;
     _Name = Name;
     _ID = ID;
     _Gender = Gender;
     _Description = Description;
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
     _SpriteIdle = SpriteIdle;
     _SpriteAttack = SpriteAttack;
     _SpriteMagic = SpriteMagic;
     _SpriteFace = SpriteFace;
     _HeroClass = HeroClass;
     _SoundDeath = SoundDeath;
     _SoundAttack = SoundAttack;
     _Energy = Energy;
     _EnergyGrowth = EnergyGrowth;
     _Story = Story;
    }
  } // class HeroesDataRow
  public class HeroesData
  {
    private HeroesData()
    {
      Rows.Add(new HeroesDataRow("H_0","No Hero",0,"M","No Hero",1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,"0","NONE","NONE","NONE","NONE","NONE","NONE","NONE",1,1,""));
      Rows.Add(new HeroesDataRow("H_1","Sword Man",1,"M","",1050,100,500,10,150,5,120,4,110,2,130,3,100,100,100,10,10,60,10,60,10,50,10,50,10,50,10,50,50,50,50,50,50,10,10,10,10,10,10,"1=6=7=8=9","ForestFairy","Swordman_Casting","Swordman_Casting","HeroFace_1","TANK","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_2","Sword Woman",2,"F","",950,100,500,10,140,5,120,4,120,2,130,3,100,100,100,10,10,80,10,80,10,60,10,50,10,50,10,60,50,50,50,50,50,10,10,10,10,10,10,"1=6=7=8=9","Human2","Swordman_Casting","Swordman_Casting","HeroFace_2","TANK","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_3","Cleric",3,"F","",1000,100,1200,20,100,2,100,3,140,5,130,4,90,70,100,10,10,60,10,100,20,100,10,100,10,100,10,100,100,100,100,100,100,10,10,10,10,10,10,"3=4=10=11=12","Human3","Swordman_Casting","Swordman_Casting","HeroFace_3","HEAL","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_4","Healer",4,"M","",1000,100,1200,20,90,2,90,3,150,5,140,4,90,70,100,10,10,60,10,100,20,100,10,100,10,100,10,100,100,100,100,100,100,10,10,10,10,10,10,"3=4=10=11=12","Human4","Swordman_Casting","Swordman_Casting","HeroFace_4","HEAL","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_5","Monk",5,"M","",1250,100,1250,20,110,2,100,4,140,5,130,3,90,50,40,10,10,70,10,90,20,100,10,100,10,100,10,100,100,100,100,100,100,10,10,10,10,10,10,"3=5=13=10","Human5","Swordman_Casting","Swordman_Casting","HeroFace_5","HEAL","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_6","Nun",6,"F","",1150,100,1350,20,100,2,110,4,130,5,120,3,90,40,50,10,10,80,10,100,20,100,10,100,10,100,10,100,100,100,100,100,100,10,10,10,10,10,10,"3=5=13=10","Human6","Swordman_Casting","Swordman_Casting","HeroFace_6","HEAL","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_7","Spear Man",7,"M","",800,80,800,80,50,5,50,5,70,4,50,5,100,90,110,10,10,75,15,75,15,75,10,75,10,75,10,80,80,80,80,80,80,10,10,10,10,10,10,"1=18=19","Human7","Swordman_Casting","Swordman_Casting","HeroFace_7","DPS","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_8","Spear Woman",8,"F","",800,80,800,80,50,5,50,5,50,5,70,4,100,110,90,10,10,75,15,75,15,75,10,75,10,75,10,80,80,80,80,80,80,10,10,10,10,10,10,"1=20=19","Human8","Swordman_Casting","Swordman_Casting","HeroFace_8","DPS","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_9","Dart Thrower",9,"M","",950,100,1050,40,120,3,150,5,120,2,100,4,110,100,100,10,10,70,10,70,10,50,10,60,10,40,10,80,80,80,80,80,80,10,10,10,10,10,10,"2=15","Human9","Swordman_Casting","Swordman_Casting","HeroFace_9","DPS","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_10","Archer",10,"F","",900,100,1250,40,130,3,150,5,130,2,90,4,110,100,100,10,10,70,10,70,10,60,10,50,10,40,10,80,80,80,80,80,80,10,10,10,10,10,10,"2=16","Human10","Swordman_Casting","Swordman_Casting","HeroFace_10","DPS","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_11","Ice Wizard",11,"M","",800,80,1050,55,100,2,110,4,150,5,135,3,85,40,70,10,10,80,10,100,15,100,10,120,15,100,10,100,100,100,100,100,100,10,12,10,10,12,10,"3","Human11","Swordman_Casting","Swordman_Casting","HeroFace_1","DPS","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_12","Ice Mage",12,"F","",700,85,1150,50,90,2,110,4,150,5,135,3,85,40,70,10,10,80,10,100,15,100,10,120,15,100,10,100,100,100,100,100,100,10,12,10,10,12,10,"3","Human12","Swordman_Casting","Swordman_Casting","HeroFace_2","MAGE","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_13","Wizard of Flame",13,"M","",800,80,1050,50,100,2,110,4,145,5,155,3,90,40,70,10,10,80,10,100,15,120,15,100,10,100,10,100,100,100,100,100,100,12,10,10,12,10,10,"3","Human13","Swordman_Casting","Swordman_Casting","HeroFace_3","MAGE","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_14","Pyrotechic",14,"F","",700,80,1150,50,90,2,110,4,150,5,135,3,90,40,70,10,10,80,10,100,15,120,15,100,10,100,10,100,100,100,100,100,100,12,10,10,12,10,10,"3","Human14","Swordman_Casting","Swordman_Casting","HeroFace_4","MAGE","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_15","Thunder Summoneer",15,"M","",800,80,1050,55,100,2,110,4,150,5,135,3,80,40,70,10,10,80,10,100,15,100,10,100,10,120,15,100,100,100,100,100,100,10,10,12,10,10,12,"3","Human15","Swordman_Casting","Swordman_Casting","HeroFace_5","MAGE","NONE","NONE",50,10,""));
      Rows.Add(new HeroesDataRow("H_16","Lightning",16,"F","",700,85,1150,50,90,2,110,4,160,5,125,3,80,40,70,10,10,80,10,100,15,100,10,100,10,120,15,100,100,100,100,100,100,10,10,12,10,10,12,"3","Human16","Swordman_Casting","Swordman_Casting","HeroFace_6","MAGE","NONE","NONE",50,10,""));
    }

    private class NestedHeroesData
    {
      static NestedHeroesData(){}
      internal static readonly HeroesData instance = new HeroesData();
    }

    public static HeroesData instance
    {
      get { return NestedHeroesData.instance;}
    }

    public List<HeroesDataRow> Rows = new List<HeroesDataRow>();

  } // class HeroesData
} // namespace AntTool

