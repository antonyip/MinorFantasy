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
	public class EnumsRow : IGoogle2uRow
	{
		public int _ID;
		public EnumsRow(string __Enum, string __ID) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
		}

		public int Length { get { return 1; } }

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
					ret = _ID.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "ID":
					ret = _ID.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Enums : IGoogle2uDB
	{
		public enum rowIds {
			NONE, AnimType_Target, AnimType_Enemy, AnimType_Ally, AnimType_Object, TargetType_All, TargetType_Equipment, TargetType_Target, AttackType_PATT, AttackType_MATT, AttackType_FATT, AttackType_IATT, AttackType_TATT, AttackType_BUFF, AttackType_DEBUFF, AttackType_OTHER
		};
		public string [] rowNames = {
			"NONE", "AnimType_Target", "AnimType_Enemy", "AnimType_Ally", "AnimType_Object", "TargetType_All", "TargetType_Equipment", "TargetType_Target", "AttackType_PATT", "AttackType_MATT", "AttackType_FATT", "AttackType_IATT", "AttackType_TATT", "AttackType_BUFF", "AttackType_DEBUFF", "AttackType_OTHER"
		};
		public System.Collections.Generic.List<EnumsRow> Rows = new System.Collections.Generic.List<EnumsRow>();

		public static Enums Instance
		{
			get { return NestedEnums.instance; }
		}

		private class NestedEnums
		{
			static NestedEnums() { }
			internal static readonly Enums instance = new Enums();
		}

		private Enums()
		{
			Rows.Add( new EnumsRow("NONE", "0"));
			Rows.Add( new EnumsRow("AnimType_Target", "1"));
			Rows.Add( new EnumsRow("AnimType_Enemy", "2"));
			Rows.Add( new EnumsRow("AnimType_Ally", "3"));
			Rows.Add( new EnumsRow("AnimType_Object", "4"));
			Rows.Add( new EnumsRow("TargetType_All", "5"));
			Rows.Add( new EnumsRow("TargetType_Equipment", "6"));
			Rows.Add( new EnumsRow("TargetType_Target", "7"));
			Rows.Add( new EnumsRow("AttackType_PATT", "8"));
			Rows.Add( new EnumsRow("AttackType_MATT", "9"));
			Rows.Add( new EnumsRow("AttackType_FATT", "10"));
			Rows.Add( new EnumsRow("AttackType_IATT", "11"));
			Rows.Add( new EnumsRow("AttackType_TATT", "12"));
			Rows.Add( new EnumsRow("AttackType_BUFF", "13"));
			Rows.Add( new EnumsRow("AttackType_DEBUFF", "14"));
			Rows.Add( new EnumsRow("AttackType_OTHER", "15"));
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
		public EnumsRow GetRow(rowIds in_RowID)
		{
			EnumsRow ret = null;
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
		public EnumsRow GetRow(string in_RowString)
		{
			EnumsRow ret = null;
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
