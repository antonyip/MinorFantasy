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
	public class HeroesDataRow : IGoogle2uRow
	{
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
		public string _SoundDeath;
		public string _SoundAttack;
		public int _Energy;
		public int _EnergyGrowth;
		public string _Story;
		public HeroesDataRow(string __IndexName, string __Name, string __ID, string __Gender, string __Description, string __HP, string __HPGrowth, string __MP, string __MPGrowth, string __STR, string __STRGrowth, string __DEX, string __DEXGrowth, string __INT, string __INTGrowth, string __LUK, string __LUKGrowth, string __Speed, string __Att, string __Def, string __AttGrowth, string __DefGrowth, string __MAtt, string __MAttGrowth, string __MDef, string __MDefGrowth, string __FAtt, string __FAttGrowth, string __IAtt, string __IAttGrowth, string __TAtt, string __TAttGrowth, string __FDef, string __IDef, string __TDef, string __FRes, string __IRes, string __TRes, string __FDefGrowth, string __IDefGrowth, string __TDefGrowth, string __FResGrowth, string __IResGrowth, string __TResGrowth, string __Skills, string __SpriteIdle, string __SpriteAttack, string __SpriteMagic, string __SoundDeath, string __SoundAttack, string __Energy, string __EnergyGrowth, string __Story) 
		{
			_Name = __Name.Trim();
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Gender = __Gender.Trim();
			_Description = __Description.Trim();
			{
			int res;
				if(int.TryParse(__HP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HP = res;
				else
					Debug.LogError("Failed To Convert _HP string: "+ __HP +" to int");
			}
			{
			int res;
				if(int.TryParse(__HPGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPGrowth = res;
				else
					Debug.LogError("Failed To Convert _HPGrowth string: "+ __HPGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__MP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MP = res;
				else
					Debug.LogError("Failed To Convert _MP string: "+ __MP +" to int");
			}
			{
			int res;
				if(int.TryParse(__MPGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MPGrowth = res;
				else
					Debug.LogError("Failed To Convert _MPGrowth string: "+ __MPGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__STR, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_STR = res;
				else
					Debug.LogError("Failed To Convert _STR string: "+ __STR +" to int");
			}
			{
			int res;
				if(int.TryParse(__STRGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_STRGrowth = res;
				else
					Debug.LogError("Failed To Convert _STRGrowth string: "+ __STRGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__DEX, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DEX = res;
				else
					Debug.LogError("Failed To Convert _DEX string: "+ __DEX +" to int");
			}
			{
			int res;
				if(int.TryParse(__DEXGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DEXGrowth = res;
				else
					Debug.LogError("Failed To Convert _DEXGrowth string: "+ __DEXGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__INT, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_INT = res;
				else
					Debug.LogError("Failed To Convert _INT string: "+ __INT +" to int");
			}
			{
			int res;
				if(int.TryParse(__INTGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_INTGrowth = res;
				else
					Debug.LogError("Failed To Convert _INTGrowth string: "+ __INTGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__LUK, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_LUK = res;
				else
					Debug.LogError("Failed To Convert _LUK string: "+ __LUK +" to int");
			}
			{
			int res;
				if(int.TryParse(__LUKGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_LUKGrowth = res;
				else
					Debug.LogError("Failed To Convert _LUKGrowth string: "+ __LUKGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__Speed, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Speed = res;
				else
					Debug.LogError("Failed To Convert _Speed string: "+ __Speed +" to int");
			}
			{
			int res;
				if(int.TryParse(__Att, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Att = res;
				else
					Debug.LogError("Failed To Convert _Att string: "+ __Att +" to int");
			}
			{
			int res;
				if(int.TryParse(__Def, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Def = res;
				else
					Debug.LogError("Failed To Convert _Def string: "+ __Def +" to int");
			}
			{
			int res;
				if(int.TryParse(__AttGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AttGrowth = res;
				else
					Debug.LogError("Failed To Convert _AttGrowth string: "+ __AttGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__DefGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DefGrowth = res;
				else
					Debug.LogError("Failed To Convert _DefGrowth string: "+ __DefGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__MAtt, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MAtt = res;
				else
					Debug.LogError("Failed To Convert _MAtt string: "+ __MAtt +" to int");
			}
			{
			int res;
				if(int.TryParse(__MAttGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MAttGrowth = res;
				else
					Debug.LogError("Failed To Convert _MAttGrowth string: "+ __MAttGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__MDef, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MDef = res;
				else
					Debug.LogError("Failed To Convert _MDef string: "+ __MDef +" to int");
			}
			{
			int res;
				if(int.TryParse(__MDefGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MDefGrowth = res;
				else
					Debug.LogError("Failed To Convert _MDefGrowth string: "+ __MDefGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__FAtt, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FAtt = res;
				else
					Debug.LogError("Failed To Convert _FAtt string: "+ __FAtt +" to int");
			}
			{
			int res;
				if(int.TryParse(__FAttGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FAttGrowth = res;
				else
					Debug.LogError("Failed To Convert _FAttGrowth string: "+ __FAttGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__IAtt, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IAtt = res;
				else
					Debug.LogError("Failed To Convert _IAtt string: "+ __IAtt +" to int");
			}
			{
			int res;
				if(int.TryParse(__IAttGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IAttGrowth = res;
				else
					Debug.LogError("Failed To Convert _IAttGrowth string: "+ __IAttGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__TAtt, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TAtt = res;
				else
					Debug.LogError("Failed To Convert _TAtt string: "+ __TAtt +" to int");
			}
			{
			int res;
				if(int.TryParse(__TAttGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TAttGrowth = res;
				else
					Debug.LogError("Failed To Convert _TAttGrowth string: "+ __TAttGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__FDef, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FDef = res;
				else
					Debug.LogError("Failed To Convert _FDef string: "+ __FDef +" to int");
			}
			{
			int res;
				if(int.TryParse(__IDef, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IDef = res;
				else
					Debug.LogError("Failed To Convert _IDef string: "+ __IDef +" to int");
			}
			{
			int res;
				if(int.TryParse(__TDef, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TDef = res;
				else
					Debug.LogError("Failed To Convert _TDef string: "+ __TDef +" to int");
			}
			{
			int res;
				if(int.TryParse(__FRes, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FRes = res;
				else
					Debug.LogError("Failed To Convert _FRes string: "+ __FRes +" to int");
			}
			{
			int res;
				if(int.TryParse(__IRes, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IRes = res;
				else
					Debug.LogError("Failed To Convert _IRes string: "+ __IRes +" to int");
			}
			{
			int res;
				if(int.TryParse(__TRes, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TRes = res;
				else
					Debug.LogError("Failed To Convert _TRes string: "+ __TRes +" to int");
			}
			{
			int res;
				if(int.TryParse(__FDefGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FDefGrowth = res;
				else
					Debug.LogError("Failed To Convert _FDefGrowth string: "+ __FDefGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__IDefGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IDefGrowth = res;
				else
					Debug.LogError("Failed To Convert _IDefGrowth string: "+ __IDefGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__TDefGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TDefGrowth = res;
				else
					Debug.LogError("Failed To Convert _TDefGrowth string: "+ __TDefGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__FResGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FResGrowth = res;
				else
					Debug.LogError("Failed To Convert _FResGrowth string: "+ __FResGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__IResGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IResGrowth = res;
				else
					Debug.LogError("Failed To Convert _IResGrowth string: "+ __IResGrowth +" to int");
			}
			{
			int res;
				if(int.TryParse(__TResGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TResGrowth = res;
				else
					Debug.LogError("Failed To Convert _TResGrowth string: "+ __TResGrowth +" to int");
			}
			_Skills = __Skills.Trim();
			_SpriteIdle = __SpriteIdle.Trim();
			_SpriteAttack = __SpriteAttack.Trim();
			_SpriteMagic = __SpriteMagic.Trim();
			_SoundDeath = __SoundDeath.Trim();
			_SoundAttack = __SoundAttack.Trim();
			{
			int res;
				if(int.TryParse(__Energy, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Energy = res;
				else
					Debug.LogError("Failed To Convert _Energy string: "+ __Energy +" to int");
			}
			{
			int res;
				if(int.TryParse(__EnergyGrowth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EnergyGrowth = res;
				else
					Debug.LogError("Failed To Convert _EnergyGrowth string: "+ __EnergyGrowth +" to int");
			}
			_Story = __Story.Trim();
		}

		public int Length { get { return 52; } }

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
					ret = _Gender.ToString();
					break;
				case 3:
					ret = _Description.ToString();
					break;
				case 4:
					ret = _HP.ToString();
					break;
				case 5:
					ret = _HPGrowth.ToString();
					break;
				case 6:
					ret = _MP.ToString();
					break;
				case 7:
					ret = _MPGrowth.ToString();
					break;
				case 8:
					ret = _STR.ToString();
					break;
				case 9:
					ret = _STRGrowth.ToString();
					break;
				case 10:
					ret = _DEX.ToString();
					break;
				case 11:
					ret = _DEXGrowth.ToString();
					break;
				case 12:
					ret = _INT.ToString();
					break;
				case 13:
					ret = _INTGrowth.ToString();
					break;
				case 14:
					ret = _LUK.ToString();
					break;
				case 15:
					ret = _LUKGrowth.ToString();
					break;
				case 16:
					ret = _Speed.ToString();
					break;
				case 17:
					ret = _Att.ToString();
					break;
				case 18:
					ret = _Def.ToString();
					break;
				case 19:
					ret = _AttGrowth.ToString();
					break;
				case 20:
					ret = _DefGrowth.ToString();
					break;
				case 21:
					ret = _MAtt.ToString();
					break;
				case 22:
					ret = _MAttGrowth.ToString();
					break;
				case 23:
					ret = _MDef.ToString();
					break;
				case 24:
					ret = _MDefGrowth.ToString();
					break;
				case 25:
					ret = _FAtt.ToString();
					break;
				case 26:
					ret = _FAttGrowth.ToString();
					break;
				case 27:
					ret = _IAtt.ToString();
					break;
				case 28:
					ret = _IAttGrowth.ToString();
					break;
				case 29:
					ret = _TAtt.ToString();
					break;
				case 30:
					ret = _TAttGrowth.ToString();
					break;
				case 31:
					ret = _FDef.ToString();
					break;
				case 32:
					ret = _IDef.ToString();
					break;
				case 33:
					ret = _TDef.ToString();
					break;
				case 34:
					ret = _FRes.ToString();
					break;
				case 35:
					ret = _IRes.ToString();
					break;
				case 36:
					ret = _TRes.ToString();
					break;
				case 37:
					ret = _FDefGrowth.ToString();
					break;
				case 38:
					ret = _IDefGrowth.ToString();
					break;
				case 39:
					ret = _TDefGrowth.ToString();
					break;
				case 40:
					ret = _FResGrowth.ToString();
					break;
				case 41:
					ret = _IResGrowth.ToString();
					break;
				case 42:
					ret = _TResGrowth.ToString();
					break;
				case 43:
					ret = _Skills.ToString();
					break;
				case 44:
					ret = _SpriteIdle.ToString();
					break;
				case 45:
					ret = _SpriteAttack.ToString();
					break;
				case 46:
					ret = _SpriteMagic.ToString();
					break;
				case 47:
					ret = _SoundDeath.ToString();
					break;
				case 48:
					ret = _SoundAttack.ToString();
					break;
				case 49:
					ret = _Energy.ToString();
					break;
				case 50:
					ret = _EnergyGrowth.ToString();
					break;
				case 51:
					ret = _Story.ToString();
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
				case "Gender":
					ret = _Gender.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "HP":
					ret = _HP.ToString();
					break;
				case "HPGrowth":
					ret = _HPGrowth.ToString();
					break;
				case "MP":
					ret = _MP.ToString();
					break;
				case "MPGrowth":
					ret = _MPGrowth.ToString();
					break;
				case "STR":
					ret = _STR.ToString();
					break;
				case "STRGrowth":
					ret = _STRGrowth.ToString();
					break;
				case "DEX":
					ret = _DEX.ToString();
					break;
				case "DEXGrowth":
					ret = _DEXGrowth.ToString();
					break;
				case "INT":
					ret = _INT.ToString();
					break;
				case "INTGrowth":
					ret = _INTGrowth.ToString();
					break;
				case "LUK":
					ret = _LUK.ToString();
					break;
				case "LUKGrowth":
					ret = _LUKGrowth.ToString();
					break;
				case "Speed":
					ret = _Speed.ToString();
					break;
				case "Att":
					ret = _Att.ToString();
					break;
				case "Def":
					ret = _Def.ToString();
					break;
				case "AttGrowth":
					ret = _AttGrowth.ToString();
					break;
				case "DefGrowth":
					ret = _DefGrowth.ToString();
					break;
				case "MAtt":
					ret = _MAtt.ToString();
					break;
				case "MAttGrowth":
					ret = _MAttGrowth.ToString();
					break;
				case "MDef":
					ret = _MDef.ToString();
					break;
				case "MDefGrowth":
					ret = _MDefGrowth.ToString();
					break;
				case "FAtt":
					ret = _FAtt.ToString();
					break;
				case "FAttGrowth":
					ret = _FAttGrowth.ToString();
					break;
				case "IAtt":
					ret = _IAtt.ToString();
					break;
				case "IAttGrowth":
					ret = _IAttGrowth.ToString();
					break;
				case "TAtt":
					ret = _TAtt.ToString();
					break;
				case "TAttGrowth":
					ret = _TAttGrowth.ToString();
					break;
				case "FDef":
					ret = _FDef.ToString();
					break;
				case "IDef":
					ret = _IDef.ToString();
					break;
				case "TDef":
					ret = _TDef.ToString();
					break;
				case "FRes":
					ret = _FRes.ToString();
					break;
				case "IRes":
					ret = _IRes.ToString();
					break;
				case "TRes":
					ret = _TRes.ToString();
					break;
				case "FDefGrowth":
					ret = _FDefGrowth.ToString();
					break;
				case "IDefGrowth":
					ret = _IDefGrowth.ToString();
					break;
				case "TDefGrowth":
					ret = _TDefGrowth.ToString();
					break;
				case "FResGrowth":
					ret = _FResGrowth.ToString();
					break;
				case "IResGrowth":
					ret = _IResGrowth.ToString();
					break;
				case "TResGrowth":
					ret = _TResGrowth.ToString();
					break;
				case "Skills":
					ret = _Skills.ToString();
					break;
				case "SpriteIdle":
					ret = _SpriteIdle.ToString();
					break;
				case "SpriteAttack":
					ret = _SpriteAttack.ToString();
					break;
				case "SpriteMagic":
					ret = _SpriteMagic.ToString();
					break;
				case "SoundDeath":
					ret = _SoundDeath.ToString();
					break;
				case "SoundAttack":
					ret = _SoundAttack.ToString();
					break;
				case "Energy":
					ret = _Energy.ToString();
					break;
				case "EnergyGrowth":
					ret = _EnergyGrowth.ToString();
					break;
				case "Story":
					ret = _Story.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Gender" + " : " + _Gender.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "HP" + " : " + _HP.ToString() + "} ";
			ret += "{" + "HPGrowth" + " : " + _HPGrowth.ToString() + "} ";
			ret += "{" + "MP" + " : " + _MP.ToString() + "} ";
			ret += "{" + "MPGrowth" + " : " + _MPGrowth.ToString() + "} ";
			ret += "{" + "STR" + " : " + _STR.ToString() + "} ";
			ret += "{" + "STRGrowth" + " : " + _STRGrowth.ToString() + "} ";
			ret += "{" + "DEX" + " : " + _DEX.ToString() + "} ";
			ret += "{" + "DEXGrowth" + " : " + _DEXGrowth.ToString() + "} ";
			ret += "{" + "INT" + " : " + _INT.ToString() + "} ";
			ret += "{" + "INTGrowth" + " : " + _INTGrowth.ToString() + "} ";
			ret += "{" + "LUK" + " : " + _LUK.ToString() + "} ";
			ret += "{" + "LUKGrowth" + " : " + _LUKGrowth.ToString() + "} ";
			ret += "{" + "Speed" + " : " + _Speed.ToString() + "} ";
			ret += "{" + "Att" + " : " + _Att.ToString() + "} ";
			ret += "{" + "Def" + " : " + _Def.ToString() + "} ";
			ret += "{" + "AttGrowth" + " : " + _AttGrowth.ToString() + "} ";
			ret += "{" + "DefGrowth" + " : " + _DefGrowth.ToString() + "} ";
			ret += "{" + "MAtt" + " : " + _MAtt.ToString() + "} ";
			ret += "{" + "MAttGrowth" + " : " + _MAttGrowth.ToString() + "} ";
			ret += "{" + "MDef" + " : " + _MDef.ToString() + "} ";
			ret += "{" + "MDefGrowth" + " : " + _MDefGrowth.ToString() + "} ";
			ret += "{" + "FAtt" + " : " + _FAtt.ToString() + "} ";
			ret += "{" + "FAttGrowth" + " : " + _FAttGrowth.ToString() + "} ";
			ret += "{" + "IAtt" + " : " + _IAtt.ToString() + "} ";
			ret += "{" + "IAttGrowth" + " : " + _IAttGrowth.ToString() + "} ";
			ret += "{" + "TAtt" + " : " + _TAtt.ToString() + "} ";
			ret += "{" + "TAttGrowth" + " : " + _TAttGrowth.ToString() + "} ";
			ret += "{" + "FDef" + " : " + _FDef.ToString() + "} ";
			ret += "{" + "IDef" + " : " + _IDef.ToString() + "} ";
			ret += "{" + "TDef" + " : " + _TDef.ToString() + "} ";
			ret += "{" + "FRes" + " : " + _FRes.ToString() + "} ";
			ret += "{" + "IRes" + " : " + _IRes.ToString() + "} ";
			ret += "{" + "TRes" + " : " + _TRes.ToString() + "} ";
			ret += "{" + "FDefGrowth" + " : " + _FDefGrowth.ToString() + "} ";
			ret += "{" + "IDefGrowth" + " : " + _IDefGrowth.ToString() + "} ";
			ret += "{" + "TDefGrowth" + " : " + _TDefGrowth.ToString() + "} ";
			ret += "{" + "FResGrowth" + " : " + _FResGrowth.ToString() + "} ";
			ret += "{" + "IResGrowth" + " : " + _IResGrowth.ToString() + "} ";
			ret += "{" + "TResGrowth" + " : " + _TResGrowth.ToString() + "} ";
			ret += "{" + "Skills" + " : " + _Skills.ToString() + "} ";
			ret += "{" + "SpriteIdle" + " : " + _SpriteIdle.ToString() + "} ";
			ret += "{" + "SpriteAttack" + " : " + _SpriteAttack.ToString() + "} ";
			ret += "{" + "SpriteMagic" + " : " + _SpriteMagic.ToString() + "} ";
			ret += "{" + "SoundDeath" + " : " + _SoundDeath.ToString() + "} ";
			ret += "{" + "SoundAttack" + " : " + _SoundAttack.ToString() + "} ";
			ret += "{" + "Energy" + " : " + _Energy.ToString() + "} ";
			ret += "{" + "EnergyGrowth" + " : " + _EnergyGrowth.ToString() + "} ";
			ret += "{" + "Story" + " : " + _Story.ToString() + "} ";
			return ret;
		}
	}
	public sealed class HeroesData : IGoogle2uDB
	{
		public enum rowIds {
			H_1, H_2, H_3, H_4, H_5, H_6, H_7, H_8, H_9, H_10, H_11, H_12, H_13, H_14, H_15, H_16
		};
		public string [] rowNames = {
			"H_1", "H_2", "H_3", "H_4", "H_5", "H_6", "H_7", "H_8", "H_9", "H_10", "H_11", "H_12", "H_13", "H_14", "H_15", "H_16"
		};
		public System.Collections.Generic.List<HeroesDataRow> Rows = new System.Collections.Generic.List<HeroesDataRow>();

		public static HeroesData Instance
		{
			get { return NestedHeroesData.instance; }
		}

		private class NestedHeroesData
		{
			static NestedHeroesData() { }
			internal static readonly HeroesData instance = new HeroesData();
		}

		private HeroesData()
		{
            Rows.Add( new HeroesDataRow("H_0", "No Hero", "0", "M", "", "1050", "100", "500", "10", "150", "5", "120", "4", "110", "2", "130", "3", "100", "100", "100", "10", "10", "60", "10", "60", "10", "50", "10", "50", "10", "50", "10", "50", "50", "50", "50", "50", "50", "10", "10", "10", "10", "10", "10", "0", "Swordman_Idle", "Swordman_Casting", "Swordman_Casting", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_1", "Sword Man", "1", "M", "", "1050", "100", "500", "10", "150", "5", "120", "4", "110", "2", "130", "3", "100", "100", "100", "10", "10", "60", "10", "60", "10", "50", "10", "50", "10", "50", "10", "50", "50", "50", "50", "50", "50", "10", "10", "10", "10", "10", "10", "0", "Swordman_Idle", "Swordman_Casting", "Swordman_Casting", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_2", "Sword Woman", "2", "F", "", "950", "100", "500", "10", "140", "5", "120", "4", "120", "2", "130", "3", "100", "100", "100", "10", "10", "80", "10", "80", "10", "60", "10", "50", "10", "50", "10", "60", "50", "50", "50", "50", "50", "10", "10", "10", "10", "10", "10", "0", "Swordman_Idle", "Swordman_Casting", "Swordman_Casting", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_3", "Cleric", "3", "F", "", "1000", "100", "1200", "20", "100", "2", "100", "3", "140", "5", "130", "4", "90", "70", "100", "10", "10", "60", "10", "100", "20", "100", "10", "100", "10", "100", "10", "100", "100", "100", "100", "100", "100", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_4", "Healer", "4", "M", "", "1000", "100", "1200", "20", "90", "2", "90", "3", "150", "5", "140", "4", "90", "70", "100", "10", "10", "60", "10", "100", "20", "100", "10", "100", "10", "100", "10", "100", "100", "100", "100", "100", "100", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_5", "Monk", "5", "M", "", "1250", "100", "1250", "20", "110", "2", "100", "4", "140", "5", "130", "3", "90", "50", "40", "10", "10", "70", "10", "90", "20", "100", "10", "100", "10", "100", "10", "100", "100", "100", "100", "100", "100", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_6", "Nun", "6", "F", "", "1150", "100", "1350", "20", "100", "2", "110", "4", "130", "5", "120", "3", "90", "40", "50", "10", "10", "80", "10", "100", "20", "100", "10", "100", "10", "100", "10", "100", "100", "100", "100", "100", "100", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_7", "Spear Man", "7", "M", "", "800", "80", "800", "80", "50", "5", "50", "5", "70", "4", "50", "5", "100", "90", "110", "10", "10", "75", "15", "75", "15", "75", "10", "75", "10", "75", "10", "80", "80", "80", "80", "80", "80", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_8", "Spear Woman", "8", "F", "", "800", "80", "800", "80", "50", "5", "50", "5", "50", "5", "70", "4", "100", "110", "90", "10", "10", "75", "15", "75", "15", "75", "10", "75", "10", "75", "10", "80", "80", "80", "80", "80", "80", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_9", "Dart Thrower", "9", "M", "", "950", "100", "1050", "40", "120", "3", "150", "5", "120", "2", "100", "4", "110", "100", "100", "10", "10", "70", "10", "70", "10", "50", "10", "60", "10", "40", "10", "80", "80", "80", "80", "80", "80", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_10", "Archer", "10", "F", "", "900", "100", "1250", "40", "130", "3", "150", "5", "130", "2", "90", "4", "110", "100", "100", "10", "10", "70", "10", "70", "10", "60", "10", "50", "10", "40", "10", "80", "80", "80", "80", "80", "80", "10", "10", "10", "10", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_11", "Ice Wizard", "11", "M", "", "800", "80", "1050", "55", "100", "2", "110", "4", "150", "5", "135", "3", "85", "40", "70", "10", "10", "80", "10", "100", "15", "100", "10", "120", "15", "100", "10", "100", "100", "100", "100", "100", "100", "10", "12", "10", "10", "12", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_12", "Ice Mage", "12", "F", "", "700", "85", "1150", "50", "90", "2", "110", "4", "150", "5", "135", "3", "85", "40", "70", "10", "10", "80", "10", "100", "15", "100", "10", "120", "15", "100", "10", "100", "100", "100", "100", "100", "100", "10", "12", "10", "10", "12", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_13", "Wizard of Flame", "13", "M", "", "800", "80", "1050", "50", "100", "2", "110", "4", "145", "5", "155", "3", "90", "40", "70", "10", "10", "80", "10", "100", "15", "120", "15", "100", "10", "100", "10", "100", "100", "100", "100", "100", "100", "12", "10", "10", "12", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_14", "Pyrotechic", "14", "F", "", "700", "80", "1150", "50", "90", "2", "110", "4", "150", "5", "135", "3", "90", "40", "70", "10", "10", "80", "10", "100", "15", "120", "15", "100", "10", "100", "10", "100", "100", "100", "100", "100", "100", "12", "10", "10", "12", "10", "10", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_15", "Thunder Summoneer", "15", "M", "", "800", "80", "1050", "55", "100", "2", "110", "4", "150", "5", "135", "3", "80", "40", "70", "10", "10", "80", "10", "100", "15", "100", "10", "100", "10", "120", "15", "100", "100", "100", "100", "100", "100", "10", "10", "12", "10", "10", "12", "", "", "", "", "", "", "50", "10", ""));
			Rows.Add( new HeroesDataRow("H_16", "Lightning", "16", "F", "", "700", "85", "1150", "50", "90", "2", "110", "4", "160", "5", "125", "3", "80", "40", "70", "10", "10", "80", "10", "100", "15", "100", "10", "100", "10", "120", "15", "100", "100", "100", "100", "100", "100", "10", "10", "12", "10", "10", "12", "", "", "", "", "", "", "50", "10", ""));
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
		public HeroesDataRow GetRow(rowIds in_RowID)
		{
			HeroesDataRow ret = null;
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
		public HeroesDataRow GetRow(string in_RowString)
		{
			HeroesDataRow ret = null;
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
