using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class HeroesDataRow
  {
    string _IndexName;
    string _Name;
    string _ID;
    string _Gender;
    string _Description;
    string _HP;
    string _HPGrowth;
    string _MP;
    string _MPGrowth;
    string _STR;
    string _STRGrowth;
    string _DEX;
    string _DEXGrowth;
    string _INT;
    string _INTGrowth;
    string _LUK;
    string _LUKGrowth;
    string _Speed;
    string _Att;
    string _Def;
    string _AttGrowth;
    string _DefGrowth;
    string _MAtt;
    string _MAttGrowth;
    string _MDef;
    string _MDefGrowth;
    string _FAtt;
    string _FAttGrowth;
    string _IAtt;
    string _IAttGrowth;
    string _TAtt;
    string _TAttGrowth;
    string _FDef;
    string _IDef;
    string _TDef;
    string _FRes;
    string _IRes;
    string _TRes;
    string _FDefGrowth;
    string _IDefGrowth;
    string _TDefGrowth;
    string _FResGrowth;
    string _IResGrowth;
    string _TResGrowth;
    string _Skills;
    string _SpriteIdle;
    string _SpriteAttack;
    string _SpriteMagic;
    string _SpriteFace;
    string _HeroClass;
    string _SoundDeath;
    string _SoundAttack;
    string _Energy;
    string _EnergyGrowth;
    string _Story;
    string _end;
    public HeroesDataRow(string IndexName,string Name,string ID,string Gender,string Description,string HP,string HPGrowth,string MP,string MPGrowth,string STR,string STRGrowth,string DEX,string DEXGrowth,string INT,string INTGrowth,string LUK,string LUKGrowth,string Speed,string Att,string Def,string AttGrowth,string DefGrowth,string MAtt,string MAttGrowth,string MDef,string MDefGrowth,string FAtt,string FAttGrowth,string IAtt,string IAttGrowth,string TAtt,string TAttGrowth,string FDef,string IDef,string TDef,string FRes,string IRes,string TRes,string FDefGrowth,string IDefGrowth,string TDefGrowth,string FResGrowth,string IResGrowth,string TResGrowth,string Skills,string SpriteIdle,string SpriteAttack,string SpriteMagic,string SpriteFace,string HeroClass,string SoundDeath,string SoundAttack,string Energy,string EnergyGrowth,string Story,string end)
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
     _end = end;
    }
  } // class HeroesDataRow
  public class HeroesData
  {
    private HeroesData()
    {
      Rows.Add(new HeroesDataRow("H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","H_0","end"));
      Rows.Add(new HeroesDataRow("Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","Sword Man","end"));
      Rows.Add(new HeroesDataRow("2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","2","end"));
      Rows.Add(new HeroesDataRow("F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","end"));
      Rows.Add(new HeroesDataRow("","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","end"));
      Rows.Add(new HeroesDataRow("1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","1250","end"));
      Rows.Add(new HeroesDataRow("100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","100","end"));
      Rows.Add(new HeroesDataRow("800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","800","end"));
      Rows.Add(new HeroesDataRow("80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","80","end"));
      Rows.Add(new HeroesDataRow("120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","120","end"));
      Rows.Add(new HeroesDataRow("3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","end"));
      Rows.Add(new HeroesDataRow("110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","110","end"));
      Rows.Add(new HeroesDataRow("4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","4","end"));
      Rows.Add(new HeroesDataRow("145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","145","end"));
      Rows.Add(new HeroesDataRow("5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","5","end"));
      Rows.Add(new HeroesDataRow("135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","135","end"));
      Rows.Add(new HeroesDataRow("3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","3","end"));
    }

    private class NestedHeroesData
    {
      static NestedHeroesData(){}
      internal static readonly HeroesData instance = new HeroesData();
    }

    private static HeroesData instance
    {
      get { return NestedHeroesData.instance;}
    }

    public List<HeroesDataRow> Rows = new List<HeroesDataRow>();

  } // class HeroesData
} // namespace AntTool

