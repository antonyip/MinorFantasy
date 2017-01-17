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
	public class TowersRow : IGoogle2uRow
	{
		public string _T_NAME;
		public string _T_COLOR;
		public int _T_MINDAMAGE;
		public int _T_MAXDAMAGE;
		public float _T_ATTACKSPEED;
		public float _T_BURN;
		public float _T_POISON;
		public float _T_FREEZE;
		public float _T_STUN;
		public float _T_ARMOR;
		public float _T_AOE;
		public TowersRow(string __T_ID, string __T_NAME, string __T_COLOR, string __T_MINDAMAGE, string __T_MAXDAMAGE, string __T_ATTACKSPEED, string __T_BURN, string __T_POISON, string __T_FREEZE, string __T_STUN, string __T_ARMOR, string __T_AOE) 
		{
			_T_NAME = __T_NAME.Trim();
			_T_COLOR = __T_COLOR.Trim();
			{
			int res;
				if(int.TryParse(__T_MINDAMAGE, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_MINDAMAGE = res;
				else
					Debug.LogError("Failed To Convert _T_MINDAMAGE string: "+ __T_MINDAMAGE +" to int");
			}
			{
			int res;
				if(int.TryParse(__T_MAXDAMAGE, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_MAXDAMAGE = res;
				else
					Debug.LogError("Failed To Convert _T_MAXDAMAGE string: "+ __T_MAXDAMAGE +" to int");
			}
			{
			float res;
				if(float.TryParse(__T_ATTACKSPEED, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_ATTACKSPEED = res;
				else
					Debug.LogError("Failed To Convert _T_ATTACKSPEED string: "+ __T_ATTACKSPEED +" to float");
			}
			{
			float res;
				if(float.TryParse(__T_BURN, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_BURN = res;
				else
					Debug.LogError("Failed To Convert _T_BURN string: "+ __T_BURN +" to float");
			}
			{
			float res;
				if(float.TryParse(__T_POISON, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_POISON = res;
				else
					Debug.LogError("Failed To Convert _T_POISON string: "+ __T_POISON +" to float");
			}
			{
			float res;
				if(float.TryParse(__T_FREEZE, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_FREEZE = res;
				else
					Debug.LogError("Failed To Convert _T_FREEZE string: "+ __T_FREEZE +" to float");
			}
			{
			float res;
				if(float.TryParse(__T_STUN, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_STUN = res;
				else
					Debug.LogError("Failed To Convert _T_STUN string: "+ __T_STUN +" to float");
			}
			{
			float res;
				if(float.TryParse(__T_ARMOR, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_ARMOR = res;
				else
					Debug.LogError("Failed To Convert _T_ARMOR string: "+ __T_ARMOR +" to float");
			}
			{
			float res;
				if(float.TryParse(__T_AOE, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_T_AOE = res;
				else
					Debug.LogError("Failed To Convert _T_AOE string: "+ __T_AOE +" to float");
			}
		}

		public int Length { get { return 11; } }

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
					ret = _T_NAME.ToString();
					break;
				case 1:
					ret = _T_COLOR.ToString();
					break;
				case 2:
					ret = _T_MINDAMAGE.ToString();
					break;
				case 3:
					ret = _T_MAXDAMAGE.ToString();
					break;
				case 4:
					ret = _T_ATTACKSPEED.ToString();
					break;
				case 5:
					ret = _T_BURN.ToString();
					break;
				case 6:
					ret = _T_POISON.ToString();
					break;
				case 7:
					ret = _T_FREEZE.ToString();
					break;
				case 8:
					ret = _T_STUN.ToString();
					break;
				case 9:
					ret = _T_ARMOR.ToString();
					break;
				case 10:
					ret = _T_AOE.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "T_NAME":
					ret = _T_NAME.ToString();
					break;
				case "T_COLOR":
					ret = _T_COLOR.ToString();
					break;
				case "T_MINDAMAGE":
					ret = _T_MINDAMAGE.ToString();
					break;
				case "T_MAXDAMAGE":
					ret = _T_MAXDAMAGE.ToString();
					break;
				case "T_ATTACKSPEED":
					ret = _T_ATTACKSPEED.ToString();
					break;
				case "T_BURN":
					ret = _T_BURN.ToString();
					break;
				case "T_POISON":
					ret = _T_POISON.ToString();
					break;
				case "T_FREEZE":
					ret = _T_FREEZE.ToString();
					break;
				case "T_STUN":
					ret = _T_STUN.ToString();
					break;
				case "T_ARMOR":
					ret = _T_ARMOR.ToString();
					break;
				case "T_AOE":
					ret = _T_AOE.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "T_NAME" + " : " + _T_NAME.ToString() + "} ";
			ret += "{" + "T_COLOR" + " : " + _T_COLOR.ToString() + "} ";
			ret += "{" + "T_MINDAMAGE" + " : " + _T_MINDAMAGE.ToString() + "} ";
			ret += "{" + "T_MAXDAMAGE" + " : " + _T_MAXDAMAGE.ToString() + "} ";
			ret += "{" + "T_ATTACKSPEED" + " : " + _T_ATTACKSPEED.ToString() + "} ";
			ret += "{" + "T_BURN" + " : " + _T_BURN.ToString() + "} ";
			ret += "{" + "T_POISON" + " : " + _T_POISON.ToString() + "} ";
			ret += "{" + "T_FREEZE" + " : " + _T_FREEZE.ToString() + "} ";
			ret += "{" + "T_STUN" + " : " + _T_STUN.ToString() + "} ";
			ret += "{" + "T_ARMOR" + " : " + _T_ARMOR.ToString() + "} ";
			ret += "{" + "T_AOE" + " : " + _T_AOE.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Towers : IGoogle2uDB
	{
		public enum rowIds {
			T01, T02, T03, T04, T05, T06, T07, T08, T09, T10, T11, T12, T13, T14, T15, T16, T17, T18
			, T19, T20, T21, T22, T23, T24
		};
		public string [] rowNames = {
			"T01", "T02", "T03", "T04", "T05", "T06", "T07", "T08", "T09", "T10", "T11", "T12", "T13", "T14", "T15", "T16", "T17", "T18"
			, "T19", "T20", "T21", "T22", "T23", "T24"
		};
		public System.Collections.Generic.List<TowersRow> Rows = new System.Collections.Generic.List<TowersRow>();

		public static Towers Instance
		{
			get { return NestedTowers.instance; }
		}

		private class NestedTowers
		{
			static NestedTowers() { }
			internal static readonly Towers instance = new Towers();
		}

		private Towers()
		{
			Rows.Add( new TowersRow("T01", "Base Red", "RED", "3", "5", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T02", "Rapid Fire", "RED", "2", "2", "0.5", "2", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T03", "Slow Burn", "RED", "1", "1", "0.5", "3", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T04", "Fire Boost", "RED", "0", "0", "1", "1", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T05", "Base Blue", "BLUE", "3", "5", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T06", "Glacial Wall", "BLUE", "2", "2", "0.5", "0", "0", "1", "0", "0", "0"));
			Rows.Add( new TowersRow("T07", "Blizzard Storm", "BLUE", "2", "2", "0.5", "0", "0", "2", "0", "0", "0"));
			Rows.Add( new TowersRow("T08", "Ice Boost", "BLUE", "0", "0", "1", "0", "0", "1", "0", "0", "0"));
			Rows.Add( new TowersRow("T09", "Base Yellow", "YELLOW", "3", "5", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T10", "Shock Tower", "YELLOW", "2", "8", "0.4", "0", "0", "0", "0.2", "0", "0"));
			Rows.Add( new TowersRow("T11", "Charged Stun", "YELLOW", "4", "10", "0.5", "0", "0", "0", "0.4", "0", "0"));
			Rows.Add( new TowersRow("T12", "Stun Boost", "YELLOW", "0", "0", "1", "0", "0", "0", "0.1", "0", "0"));
			Rows.Add( new TowersRow("T13", "Base Green", "GREEN", "3", "5", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T14", "Posion Ivy", "GREEN", "3", "5", "1", "0", "3", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T15", "Gasious Tower", "GREEN", "2", "4", "0.5", "0", "4", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T16", "Poison Boost", "GREEN", "0", "0", "1", "0", "2", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T17", "Base Purple", "PURPLE", "3", "5", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T18", "Armor Reductor", "PURPLE", "2", "4", "1", "0", "0", "0", "0", "1", "0"));
			Rows.Add( new TowersRow("T19", "Null Zone", "PURPLE", "2", "2", "0.5", "0", "0", "0", "0", "1", "0"));
			Rows.Add( new TowersRow("T20", "Attack Boost", "PURPLE", "0", "0", "1", "0", "0", "0", "0", "1", "0"));
			Rows.Add( new TowersRow("T21", "Base Orange", "ORANGE", "3", "5", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T22", "Pure Damage", "ORANGE", "4", "6", "0.5", "0", "0", "0", "0", "0", "0"));
			Rows.Add( new TowersRow("T23", "Pure Nuke", "ORANGE", "6", "10", "3", "0", "0", "0", "0", "0", "1"));
			Rows.Add( new TowersRow("T24", "Damage Boost", "ORANGE", "0", "0", "1", "0", "0", "0", "0", "0", "2"));
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
		public TowersRow GetRow(rowIds in_RowID)
		{
			TowersRow ret = null;
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
		public TowersRow GetRow(string in_RowString)
		{
			TowersRow ret = null;
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
