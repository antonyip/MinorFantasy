//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class SkillDataRow : IGoogle2uRow
	{
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
		public SkillDataRow(string __SkillIndex, string __Name, string __ID, string __Description, string __Level, string __AttackType, string __TargetType, string __AnimationType, string __SoundFile, string __SpriteAnimation, string __SpriteIcon, string __SkillFomular, string __Turns, string __Hits, string __HPFlat, string __HPPercent, string __MPFlat, string __MPPercent, string __Energy, string __ShieldPercent, string __ShieldFlat, string __AttFlat, string __AttPercent, string __DefFlat, string __DefPercent, string __MAttFlat, string __MAttPercent, string __MDefFlat, string __MDefPercent, string __STRFlat, string __STRPercent, string __DEXFlat, string __DEXPercent, string __INTFlat, string __INTPercent, string __LUKFlat, string __LUKPercent, string __SpeedFlat, string __SpeedPercent, string __ExpFlat, string __ExpPercent, string __DropFlat, string __DropPercent, string __Completion, string __Quality, string __Steps) 
		{
			_Name = __Name.Trim();
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Description = __Description.Trim();
			{
			int res;
				if(int.TryParse(__Level, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Level = res;
				else
					Debug.LogError("Failed To Convert _Level string: "+ __Level +" to int");
			}
			_AttackType = __AttackType.Trim();
			_TargetType = __TargetType.Trim();
			_AnimationType = __AnimationType.Trim();
			_SoundFile = __SoundFile.Trim();
			_SpriteAnimation = __SpriteAnimation.Trim();
			_SpriteIcon = __SpriteIcon.Trim();
			_SkillFomular = __SkillFomular.Trim();
			{
			int res;
				if(int.TryParse(__Turns, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Turns = res;
				else
					Debug.LogError("Failed To Convert _Turns string: "+ __Turns +" to int");
			}
			{
			int res;
				if(int.TryParse(__Hits, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Hits = res;
				else
					Debug.LogError("Failed To Convert _Hits string: "+ __Hits +" to int");
			}
			{
			int res;
				if(int.TryParse(__HPFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPFlat = res;
				else
					Debug.LogError("Failed To Convert _HPFlat string: "+ __HPFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__HPPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPPercent = res;
				else
					Debug.LogError("Failed To Convert _HPPercent string: "+ __HPPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__MPFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MPFlat = res;
				else
					Debug.LogError("Failed To Convert _MPFlat string: "+ __MPFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__MPPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MPPercent = res;
				else
					Debug.LogError("Failed To Convert _MPPercent string: "+ __MPPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__Energy, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Energy = res;
				else
					Debug.LogError("Failed To Convert _Energy string: "+ __Energy +" to int");
			}
			{
			int res;
				if(int.TryParse(__ShieldPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ShieldPercent = res;
				else
					Debug.LogError("Failed To Convert _ShieldPercent string: "+ __ShieldPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__ShieldFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ShieldFlat = res;
				else
					Debug.LogError("Failed To Convert _ShieldFlat string: "+ __ShieldFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__AttFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AttFlat = res;
				else
					Debug.LogError("Failed To Convert _AttFlat string: "+ __AttFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__AttPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AttPercent = res;
				else
					Debug.LogError("Failed To Convert _AttPercent string: "+ __AttPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__DefFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DefFlat = res;
				else
					Debug.LogError("Failed To Convert _DefFlat string: "+ __DefFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__DefPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DefPercent = res;
				else
					Debug.LogError("Failed To Convert _DefPercent string: "+ __DefPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__MAttFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MAttFlat = res;
				else
					Debug.LogError("Failed To Convert _MAttFlat string: "+ __MAttFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__MAttPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MAttPercent = res;
				else
					Debug.LogError("Failed To Convert _MAttPercent string: "+ __MAttPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__MDefFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MDefFlat = res;
				else
					Debug.LogError("Failed To Convert _MDefFlat string: "+ __MDefFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__MDefPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MDefPercent = res;
				else
					Debug.LogError("Failed To Convert _MDefPercent string: "+ __MDefPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__STRFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_STRFlat = res;
				else
					Debug.LogError("Failed To Convert _STRFlat string: "+ __STRFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__STRPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_STRPercent = res;
				else
					Debug.LogError("Failed To Convert _STRPercent string: "+ __STRPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__DEXFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DEXFlat = res;
				else
					Debug.LogError("Failed To Convert _DEXFlat string: "+ __DEXFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__DEXPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DEXPercent = res;
				else
					Debug.LogError("Failed To Convert _DEXPercent string: "+ __DEXPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__INTFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_INTFlat = res;
				else
					Debug.LogError("Failed To Convert _INTFlat string: "+ __INTFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__INTPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_INTPercent = res;
				else
					Debug.LogError("Failed To Convert _INTPercent string: "+ __INTPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__LUKFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_LUKFlat = res;
				else
					Debug.LogError("Failed To Convert _LUKFlat string: "+ __LUKFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__LUKPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_LUKPercent = res;
				else
					Debug.LogError("Failed To Convert _LUKPercent string: "+ __LUKPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpeedFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpeedFlat = res;
				else
					Debug.LogError("Failed To Convert _SpeedFlat string: "+ __SpeedFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpeedPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpeedPercent = res;
				else
					Debug.LogError("Failed To Convert _SpeedPercent string: "+ __SpeedPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__ExpFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ExpFlat = res;
				else
					Debug.LogError("Failed To Convert _ExpFlat string: "+ __ExpFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__ExpPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ExpPercent = res;
				else
					Debug.LogError("Failed To Convert _ExpPercent string: "+ __ExpPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__DropFlat, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DropFlat = res;
				else
					Debug.LogError("Failed To Convert _DropFlat string: "+ __DropFlat +" to int");
			}
			{
			int res;
				if(int.TryParse(__DropPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DropPercent = res;
				else
					Debug.LogError("Failed To Convert _DropPercent string: "+ __DropPercent +" to int");
			}
			{
			int res;
				if(int.TryParse(__Completion, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Completion = res;
				else
					Debug.LogError("Failed To Convert _Completion string: "+ __Completion +" to int");
			}
			{
			int res;
				if(int.TryParse(__Quality, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Quality = res;
				else
					Debug.LogError("Failed To Convert _Quality string: "+ __Quality +" to int");
			}
			{
			int res;
				if(int.TryParse(__Steps, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Steps = res;
				else
					Debug.LogError("Failed To Convert _Steps string: "+ __Steps +" to int");
			}
		}

		public int Length { get { return 45; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _Name.ToString();
					break;
				case 1:
					ret = _ID.ToString();
					break;
				case 2:
					ret = _Description.ToString();
					break;
				case 3:
					ret = _Level.ToString();
					break;
				case 4:
					ret = _AttackType.ToString();
					break;
				case 5:
					ret = _TargetType.ToString();
					break;
				case 6:
					ret = _AnimationType.ToString();
					break;
				case 7:
					ret = _SoundFile.ToString();
					break;
				case 8:
					ret = _SpriteAnimation.ToString();
					break;
				case 9:
					ret = _SpriteIcon.ToString();
					break;
				case 10:
					ret = _SkillFomular.ToString();
					break;
				case 11:
					ret = _Turns.ToString();
					break;
				case 12:
					ret = _Hits.ToString();
					break;
				case 13:
					ret = _HPFlat.ToString();
					break;
				case 14:
					ret = _HPPercent.ToString();
					break;
				case 15:
					ret = _MPFlat.ToString();
					break;
				case 16:
					ret = _MPPercent.ToString();
					break;
				case 17:
					ret = _Energy.ToString();
					break;
				case 18:
					ret = _ShieldPercent.ToString();
					break;
				case 19:
					ret = _ShieldFlat.ToString();
					break;
				case 20:
					ret = _AttFlat.ToString();
					break;
				case 21:
					ret = _AttPercent.ToString();
					break;
				case 22:
					ret = _DefFlat.ToString();
					break;
				case 23:
					ret = _DefPercent.ToString();
					break;
				case 24:
					ret = _MAttFlat.ToString();
					break;
				case 25:
					ret = _MAttPercent.ToString();
					break;
				case 26:
					ret = _MDefFlat.ToString();
					break;
				case 27:
					ret = _MDefPercent.ToString();
					break;
				case 28:
					ret = _STRFlat.ToString();
					break;
				case 29:
					ret = _STRPercent.ToString();
					break;
				case 30:
					ret = _DEXFlat.ToString();
					break;
				case 31:
					ret = _DEXPercent.ToString();
					break;
				case 32:
					ret = _INTFlat.ToString();
					break;
				case 33:
					ret = _INTPercent.ToString();
					break;
				case 34:
					ret = _LUKFlat.ToString();
					break;
				case 35:
					ret = _LUKPercent.ToString();
					break;
				case 36:
					ret = _SpeedFlat.ToString();
					break;
				case 37:
					ret = _SpeedPercent.ToString();
					break;
				case 38:
					ret = _ExpFlat.ToString();
					break;
				case 39:
					ret = _ExpPercent.ToString();
					break;
				case 40:
					ret = _DropFlat.ToString();
					break;
				case 41:
					ret = _DropPercent.ToString();
					break;
				case 42:
					ret = _Completion.ToString();
					break;
				case 43:
					ret = _Quality.ToString();
					break;
				case 44:
					ret = _Steps.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Name":
					ret = _Name.ToString();
					break;
				case "ID":
					ret = _ID.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "Level":
					ret = _Level.ToString();
					break;
				case "AttackType":
					ret = _AttackType.ToString();
					break;
				case "TargetType":
					ret = _TargetType.ToString();
					break;
				case "AnimationType":
					ret = _AnimationType.ToString();
					break;
				case "SoundFile":
					ret = _SoundFile.ToString();
					break;
				case "SpriteAnimation":
					ret = _SpriteAnimation.ToString();
					break;
				case "SpriteIcon":
					ret = _SpriteIcon.ToString();
					break;
				case "SkillFomular":
					ret = _SkillFomular.ToString();
					break;
				case "Turns":
					ret = _Turns.ToString();
					break;
				case "Hits":
					ret = _Hits.ToString();
					break;
				case "HPFlat":
					ret = _HPFlat.ToString();
					break;
				case "HPPercent":
					ret = _HPPercent.ToString();
					break;
				case "MPFlat":
					ret = _MPFlat.ToString();
					break;
				case "MPPercent":
					ret = _MPPercent.ToString();
					break;
				case "Energy":
					ret = _Energy.ToString();
					break;
				case "ShieldPercent":
					ret = _ShieldPercent.ToString();
					break;
				case "ShieldFlat":
					ret = _ShieldFlat.ToString();
					break;
				case "AttFlat":
					ret = _AttFlat.ToString();
					break;
				case "AttPercent":
					ret = _AttPercent.ToString();
					break;
				case "DefFlat":
					ret = _DefFlat.ToString();
					break;
				case "DefPercent":
					ret = _DefPercent.ToString();
					break;
				case "MAttFlat":
					ret = _MAttFlat.ToString();
					break;
				case "MAttPercent":
					ret = _MAttPercent.ToString();
					break;
				case "MDefFlat":
					ret = _MDefFlat.ToString();
					break;
				case "MDefPercent":
					ret = _MDefPercent.ToString();
					break;
				case "STRFlat":
					ret = _STRFlat.ToString();
					break;
				case "STRPercent":
					ret = _STRPercent.ToString();
					break;
				case "DEXFlat":
					ret = _DEXFlat.ToString();
					break;
				case "DEXPercent":
					ret = _DEXPercent.ToString();
					break;
				case "INTFlat":
					ret = _INTFlat.ToString();
					break;
				case "INTPercent":
					ret = _INTPercent.ToString();
					break;
				case "LUKFlat":
					ret = _LUKFlat.ToString();
					break;
				case "LUKPercent":
					ret = _LUKPercent.ToString();
					break;
				case "SpeedFlat":
					ret = _SpeedFlat.ToString();
					break;
				case "SpeedPercent":
					ret = _SpeedPercent.ToString();
					break;
				case "ExpFlat":
					ret = _ExpFlat.ToString();
					break;
				case "ExpPercent":
					ret = _ExpPercent.ToString();
					break;
				case "DropFlat":
					ret = _DropFlat.ToString();
					break;
				case "DropPercent":
					ret = _DropPercent.ToString();
					break;
				case "Completion":
					ret = _Completion.ToString();
					break;
				case "Quality":
					ret = _Quality.ToString();
					break;
				case "Steps":
					ret = _Steps.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "Level" + " : " + _Level.ToString() + "} ";
			ret += "{" + "AttackType" + " : " + _AttackType.ToString() + "} ";
			ret += "{" + "TargetType" + " : " + _TargetType.ToString() + "} ";
			ret += "{" + "AnimationType" + " : " + _AnimationType.ToString() + "} ";
			ret += "{" + "SoundFile" + " : " + _SoundFile.ToString() + "} ";
			ret += "{" + "SpriteAnimation" + " : " + _SpriteAnimation.ToString() + "} ";
			ret += "{" + "SpriteIcon" + " : " + _SpriteIcon.ToString() + "} ";
			ret += "{" + "SkillFomular" + " : " + _SkillFomular.ToString() + "} ";
			ret += "{" + "Turns" + " : " + _Turns.ToString() + "} ";
			ret += "{" + "Hits" + " : " + _Hits.ToString() + "} ";
			ret += "{" + "HPFlat" + " : " + _HPFlat.ToString() + "} ";
			ret += "{" + "HPPercent" + " : " + _HPPercent.ToString() + "} ";
			ret += "{" + "MPFlat" + " : " + _MPFlat.ToString() + "} ";
			ret += "{" + "MPPercent" + " : " + _MPPercent.ToString() + "} ";
			ret += "{" + "Energy" + " : " + _Energy.ToString() + "} ";
			ret += "{" + "ShieldPercent" + " : " + _ShieldPercent.ToString() + "} ";
			ret += "{" + "ShieldFlat" + " : " + _ShieldFlat.ToString() + "} ";
			ret += "{" + "AttFlat" + " : " + _AttFlat.ToString() + "} ";
			ret += "{" + "AttPercent" + " : " + _AttPercent.ToString() + "} ";
			ret += "{" + "DefFlat" + " : " + _DefFlat.ToString() + "} ";
			ret += "{" + "DefPercent" + " : " + _DefPercent.ToString() + "} ";
			ret += "{" + "MAttFlat" + " : " + _MAttFlat.ToString() + "} ";
			ret += "{" + "MAttPercent" + " : " + _MAttPercent.ToString() + "} ";
			ret += "{" + "MDefFlat" + " : " + _MDefFlat.ToString() + "} ";
			ret += "{" + "MDefPercent" + " : " + _MDefPercent.ToString() + "} ";
			ret += "{" + "STRFlat" + " : " + _STRFlat.ToString() + "} ";
			ret += "{" + "STRPercent" + " : " + _STRPercent.ToString() + "} ";
			ret += "{" + "DEXFlat" + " : " + _DEXFlat.ToString() + "} ";
			ret += "{" + "DEXPercent" + " : " + _DEXPercent.ToString() + "} ";
			ret += "{" + "INTFlat" + " : " + _INTFlat.ToString() + "} ";
			ret += "{" + "INTPercent" + " : " + _INTPercent.ToString() + "} ";
			ret += "{" + "LUKFlat" + " : " + _LUKFlat.ToString() + "} ";
			ret += "{" + "LUKPercent" + " : " + _LUKPercent.ToString() + "} ";
			ret += "{" + "SpeedFlat" + " : " + _SpeedFlat.ToString() + "} ";
			ret += "{" + "SpeedPercent" + " : " + _SpeedPercent.ToString() + "} ";
			ret += "{" + "ExpFlat" + " : " + _ExpFlat.ToString() + "} ";
			ret += "{" + "ExpPercent" + " : " + _ExpPercent.ToString() + "} ";
			ret += "{" + "DropFlat" + " : " + _DropFlat.ToString() + "} ";
			ret += "{" + "DropPercent" + " : " + _DropPercent.ToString() + "} ";
			ret += "{" + "Completion" + " : " + _Completion.ToString() + "} ";
			ret += "{" + "Quality" + " : " + _Quality.ToString() + "} ";
			ret += "{" + "Steps" + " : " + _Steps.ToString() + "} ";
			return ret;
		}
	}
	public sealed class SkillData : IGoogle2uDB
	{
		public enum rowIds {
			S_1, S_2, S_3, S_4, S_5, S_6, S_7, S_8, S_9, S_10, S_11, S_12, S_13, S_14, S_15, S_16, S_17, S_18
			, S_19, S_20, S_21, S_22, S_23, S_24, S_25, S_26, S_27, S_28, S_29, S_30, S_31, S_32, S_33, S_34, S_35, S_36, S_37, S_38
			, S_39, S_40, S_41, S_42
		};
		public string [] rowNames = {
			"S_1", "S_2", "S_3", "S_4", "S_5", "S_6", "S_7", "S_8", "S_9", "S_10", "S_11", "S_12", "S_13", "S_14", "S_15", "S_16", "S_17", "S_18"
			, "S_19", "S_20", "S_21", "S_22", "S_23", "S_24", "S_25", "S_26", "S_27", "S_28", "S_29", "S_30", "S_31", "S_32", "S_33", "S_34", "S_35", "S_36", "S_37", "S_38"
			, "S_39", "S_40", "S_41", "S_42"
		};
		public System.Collections.Generic.List<SkillDataRow> Rows = new System.Collections.Generic.List<SkillDataRow>();

		public static SkillData Instance
		{
			get { return NestedSkillData.instance; }
		}

		private class NestedSkillData
		{
			static NestedSkillData() { }
			internal static readonly SkillData instance = new SkillData();
		}

		private SkillData()
		{
			Rows.Add( new SkillDataRow("S_1", "Attack (Melee)", "1", "Attack an enemy with a melee weapon", "1", "AttackType_PATT", "TargetType_Target", "AnimType_MeleeTarget", "NONE", "NONE", "NONE", "{PSTR}+{PPATT}-{EPDEF}", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_2", "Attack (Range)", "2", "Attack an enemy with a ranged weapon", "1", "AttackType_PATT", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "{PSTR}+{PPATT}-{EPDEF}", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_3", "Magic Bolt", "3", "Attack an enemy with a Magic bolt", "1", "AttackType_MATT", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "{PINT}+{PMATT}-{EMDEF}", "0", "1", "0", "0", "10", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_4", "Heal", "4", "Heals a Target", "2", "AttackType_MATT", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "0-{PINT}-{PMATT}-{PMDEF}", "0", "1", "0", "0", "50", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_5", "Protect", "5", "Shields a Target", "1", "AttackType_BUFF", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "0-0", "5", "1", "0", "0", "200", "0", "1", "100", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_6", "Fire Sword", "6", "Attacks an enemy with a fire sword", "9", "AttackType_PATT", "TargetType_Target", "AnimType_MeleeTarget", "NONE", "NONE", "NONE", "{PSTR}+{PPATT}+{PMATT}+{PFATT}-{EPDEF}-{EMDEF}+{EFDEF}", "0", "1", "0", "0", "50", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_7", "Guard Position", "7", "Physical Defence Doubled!", "6", "AttackType_BUFF", "TargetType_Target", "AnimType_Self", "NONE", "NONE", "NONE", "0-0", "0", "1", "0", "0", "50", "0", "1", "0", "0", "0", "0", "0", "200", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_8", "Berserk", "8", "Attack Doubled, Defence Halfed", "45", "AttackType_BUFF", "TargetType_Target", "AnimType_Self", "NONE", "NONE", "NONE", "0-0", "0", "1", "0", "0", "200", "0", "1", "0", "0", "0", "200", "0", "50", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_9", "Blood Sacrifice", "9", "Passes HP to an Ally", "32", "AttackType_BUFF", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "0-{PSTR}-{PPATT}-{PMATT}", "0", "1", "0", "50", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_10", "Heal All", "10", "Heals all allies", "28", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0-{PINT}", "0", "1", "0", "0", "250", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_11", "Regeneration", "11", "Heals a Target Over Time", "4", "AttackType_BUFF", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "(0-{PINT}-{PMATT}-{PMDEF})/3", "5", "1", "0", "0", "80", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_12", "Sacrifice", "12", "Heals all allies to full by sacrificing life", "48", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0-9999", "0", "1", "0", "100", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_13", "Shell", "13", "Doubles Mdef of allies", "28", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "5", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "200", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_14", "Dispel", "14", "Removes all Buffs", "41", "AttackType_BUFF", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "{SPECIAL}{REMOVEBUFFS}", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_15", "PowerShot (T)", "15", "iploremsum...", "1", "AttackType_PATT", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_16", "PowerShot (F)", "16", "iploremsum...", "1", "AttackType_PATT", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_17", "PowerShot (I)", "17", "iploremsum...", "1", "AttackType_PATT", "TargetType_Target", "AnimType_RangeTarget", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_18", "dummyskill", "18", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_19", "dummyskill", "19", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_20", "dummyskill", "20", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_21", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_22", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_23", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_24", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_25", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_26", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_27", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_28", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_29", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_30", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_31", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_32", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_33", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_34", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_35", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_36", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_37", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_38", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_39", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_40", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_41", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new SkillDataRow("S_42", "dummyskill", "21", "iploremsum...", "1", "AttackType_BUFF", "TargetType_Multiple", "AnimType_Ally", "NONE", "NONE", "NONE", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public SkillDataRow GetRow(rowIds in_RowID)
		{
			SkillDataRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public SkillDataRow GetRow(string in_RowString)
		{
			SkillDataRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
