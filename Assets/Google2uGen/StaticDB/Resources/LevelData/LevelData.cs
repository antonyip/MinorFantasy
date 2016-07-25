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
	public class LevelDataRow : IGoogle2uRow
	{
		public int _ID;
		public string _Battle1;
		public string _Battle2;
		public string _Battle3;
		public string _Battle4;
		public string _Battle5;
		public string _Loot;
		public string _Description;
		public LevelDataRow(string __Name, string __ID, string __Battle1, string __Battle2, string __Battle3, string __Battle4, string __Battle5, string __Loot, string __Description) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Battle1 = __Battle1.Trim();
			_Battle2 = __Battle2.Trim();
			_Battle3 = __Battle3.Trim();
			_Battle4 = __Battle4.Trim();
			_Battle5 = __Battle5.Trim();
			_Loot = __Loot.Trim();
			_Description = __Description.Trim();
		}

		public int Length { get { return 8; } }

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
				case 1:
					ret = _Battle1.ToString();
					break;
				case 2:
					ret = _Battle2.ToString();
					break;
				case 3:
					ret = _Battle3.ToString();
					break;
				case 4:
					ret = _Battle4.ToString();
					break;
				case 5:
					ret = _Battle5.ToString();
					break;
				case 6:
					ret = _Loot.ToString();
					break;
				case 7:
					ret = _Description.ToString();
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
				case "Battle1":
					ret = _Battle1.ToString();
					break;
				case "Battle2":
					ret = _Battle2.ToString();
					break;
				case "Battle3":
					ret = _Battle3.ToString();
					break;
				case "Battle4":
					ret = _Battle4.ToString();
					break;
				case "Battle5":
					ret = _Battle5.ToString();
					break;
				case "Loot":
					ret = _Loot.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Battle1" + " : " + _Battle1.ToString() + "} ";
			ret += "{" + "Battle2" + " : " + _Battle2.ToString() + "} ";
			ret += "{" + "Battle3" + " : " + _Battle3.ToString() + "} ";
			ret += "{" + "Battle4" + " : " + _Battle4.ToString() + "} ";
			ret += "{" + "Battle5" + " : " + _Battle5.ToString() + "} ";
			ret += "{" + "Loot" + " : " + _Loot.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			return ret;
		}
	}
	public sealed class LevelData : IGoogle2uDB
	{
		public enum rowIds {
			Forest_Beginner, Forest_Advance
		};
		public string [] rowNames = {
			"Forest_Beginner", "Forest_Advance"
		};
		public System.Collections.Generic.List<LevelDataRow> Rows = new System.Collections.Generic.List<LevelDataRow>();

		public static LevelData Instance
		{
			get { return NestedLevelData.instance; }
		}

		private class NestedLevelData
		{
			static NestedLevelData() { }
			internal static readonly LevelData instance = new LevelData();
		}

		private LevelData()
		{
			Rows.Add( new LevelDataRow("Forest_Beginner", "1", "1", "", "", "", "", "", ""));
			Rows.Add( new LevelDataRow("Forest_Advance", "2", "1", "1,1,1", "", "", "", "", ""));
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
		public LevelDataRow GetRow(rowIds in_RowID)
		{
			LevelDataRow ret = null;
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
		public LevelDataRow GetRow(string in_RowString)
		{
			LevelDataRow ret = null;
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
