using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class SkillDataRow
  {
    public string _SkillIndex;
    public string _Name;
    public int _ID;
    public string _Description;
    public int _Level;
    public string _AttackType;
    public string _TargetType;
    public string _AnimationType;
    public string _SoundFile;
    public string _SpriteAnimation;
    public string _SpriteIcon;
    public string _SkillFomular;
    public int _Turns;
    public int _Hits;
    public int _HPFlat;
    public int _HPPercent;
    public int _MPFlat;
    public int _MPPercent;
    public int _Energy;
    public int _ShieldPercent;
    public int _ShieldFlat;
    public int _AttFlat;
    public int _AttPercent;
    public int _DefFlat;
    public int _DefPercent;
    public int _MAttFlat;
    public int _MAttPercent;
    public int _MDefFlat;
    public int _MDefPercent;
    public int _STRFlat;
    public int _STRPercent;
    public int _DEXFlat;
    public int _DEXPercent;
    public int _INTFlat;
    public int _INTPercent;
    public int _LUKFlat;
    public int _LUKPercent;
    public int _SpeedFlat;
    public int _SpeedPercent;
    public int _ExpFlat;
    public int _ExpPercent;
    public int _DropFlat;
    public int _DropPercent;
    public int _Completion;
    public int _Quality;
    public int _Steps;
    string _end;
    public SkillDataRow(string SkillIndex,string Name,int ID,string Description,int Level,string AttackType,string TargetType,string AnimationType,string SoundFile,string SpriteAnimation,string SpriteIcon,string SkillFomular,int Turns,int Hits,int HPFlat,int HPPercent,int MPFlat,int MPPercent,int Energy,int ShieldPercent,int ShieldFlat,int AttFlat,int AttPercent,int DefFlat,int DefPercent,int MAttFlat,int MAttPercent,int MDefFlat,int MDefPercent,int STRFlat,int STRPercent,int DEXFlat,int DEXPercent,int INTFlat,int INTPercent,int LUKFlat,int LUKPercent,int SpeedFlat,int SpeedPercent,int ExpFlat,int ExpPercent,int DropFlat,int DropPercent,int Completion,int Quality,int Steps,string end)
    {
     _SkillIndex = SkillIndex;
     _Name = Name;
     _ID = ID;
     _Description = Description;
     _Level = Level;
     _AttackType = AttackType;
     _TargetType = TargetType;
     _AnimationType = AnimationType;
     _SoundFile = SoundFile;
     _SpriteAnimation = SpriteAnimation;
     _SpriteIcon = SpriteIcon;
     _SkillFomular = SkillFomular;
     _Turns = Turns;
     _Hits = Hits;
     _HPFlat = HPFlat;
     _HPPercent = HPPercent;
     _MPFlat = MPFlat;
     _MPPercent = MPPercent;
     _Energy = Energy;
     _ShieldPercent = ShieldPercent;
     _ShieldFlat = ShieldFlat;
     _AttFlat = AttFlat;
     _AttPercent = AttPercent;
     _DefFlat = DefFlat;
     _DefPercent = DefPercent;
     _MAttFlat = MAttFlat;
     _MAttPercent = MAttPercent;
     _MDefFlat = MDefFlat;
     _MDefPercent = MDefPercent;
     _STRFlat = STRFlat;
     _STRPercent = STRPercent;
     _DEXFlat = DEXFlat;
     _DEXPercent = DEXPercent;
     _INTFlat = INTFlat;
     _INTPercent = INTPercent;
     _LUKFlat = LUKFlat;
     _LUKPercent = LUKPercent;
     _SpeedFlat = SpeedFlat;
     _SpeedPercent = SpeedPercent;
     _ExpFlat = ExpFlat;
     _ExpPercent = ExpPercent;
     _DropFlat = DropFlat;
     _DropPercent = DropPercent;
     _Completion = Completion;
     _Quality = Quality;
     _Steps = Steps;
     _end = end;
    }
  } // class SkillDataRow
  public class SkillData
  {
    private SkillData()
    {
      Rows.Add(new SkillDataRow("S_1","Attack (Melee)",1,"Attack an enemy with a melee weapon",1,"AttackType_PATT","TargetType_Target","AnimType_MeleeTarget","NONE","NONE","NONE","{PSTR}+{PPATT}-{EPDEF}",0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_2","Attack (Range)",2,"Attack an enemy with a ranged weapon",1,"AttackType_PATT","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","{PSTR}+{PPATT}-{EPDEF}",0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_3","Magic Bolt",3,"Attack an enemy with a Magic bolt",1,"AttackType_MATT","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","{PINT}+{PMATT}-{EMDEF}",0,1,0,0,10,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_4","Heal",4,"Heals a Target",2,"AttackType_MATT","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","0-{PINT}-{PMATT}-{PMDEF}",0,1,0,0,50,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_5","Protect",5,"Shields a Target",1,"AttackType_BUFF","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","0-0",5,1,0,0,200,0,1,100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_6","Fire Sword",6,"Attacks an enemy with a fire sword",9,"AttackType_PATT","TargetType_Target","AnimType_MeleeTarget","NONE","NONE","NONE","{PSTR}+{PPATT}+{PMATT}+{PFATT}-{EPDEF}-{EMDEF}+{EFDEF}",0,1,0,0,50,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_7","Guard Position",7,"Physical Defence Doubled!",6,"AttackType_BUFF","TargetType_Target","AnimType_Self","NONE","NONE","NONE","0-0",0,1,0,0,50,0,1,0,0,0,0,0,200,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_8","Berserk",8,"Attack Doubled, Defence Halfed",45,"AttackType_BUFF","TargetType_Target","AnimType_Self","NONE","NONE","NONE","0-0",0,1,0,0,200,0,1,0,0,0,200,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_9","Blood Sacrifice",9,"Passes HP to an Ally",32,"AttackType_BUFF","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","0-{PSTR}-{PPATT}-{PMATT}",0,1,0,50,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_10","Heal All",10,"Heals all allies",28,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0-{PINT}",0,1,0,0,250,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_11","Regeneration",11,"Heals a Target Over Time",4,"AttackType_BUFF","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","(0-{PINT}-{PMATT}-{PMDEF})/3",5,1,0,0,80,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_12","Sacrifice",12,"Heals all allies to full by sacrificing life",48,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0-9999",0,1,0,100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_13","Shell",13,"Doubles Mdef of allies",28,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",5,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,200,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_14","Dispel",14,"Removes all Buffs",41,"AttackType_BUFF","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","{SPECIAL}{REMOVEBUFFS}",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_15","PowerShot (T)",15,"iploremsum...",1,"AttackType_PATT","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_16","PowerShot (F)",16,"iploremsum...",1,"AttackType_PATT","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_17","PowerShot (I)",17,"iploremsum...",1,"AttackType_PATT","TargetType_Target","AnimType_RangeTarget","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_18","dummyskill",18,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_19","dummyskill",19,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_20","dummyskill",20,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_21","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_22","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_23","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_24","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_25","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_26","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_27","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_28","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_29","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_30","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_31","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_32","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_33","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_34","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_35","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_36","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_37","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_38","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_39","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_40","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_41","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
      Rows.Add(new SkillDataRow("S_42","dummyskill",21,"iploremsum...",1,"AttackType_BUFF","TargetType_Multiple","AnimType_Ally","NONE","NONE","NONE","0",0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,"end"));
    }

    private class NestedSkillData
    {
      static NestedSkillData(){}
      internal static readonly SkillData instance = new SkillData();
    }

    public static SkillData instance
    {
      get { return NestedSkillData.instance;}
    }

    public List<SkillDataRow> Rows = new List<SkillDataRow>();

  } // class SkillData
} // namespace AntTool

