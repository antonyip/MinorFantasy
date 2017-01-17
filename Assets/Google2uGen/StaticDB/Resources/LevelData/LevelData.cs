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
		public string _Name;
		public int _ID;
		public string _Battle1;
		public string _Battle2;
		public string _Battle3;
		public string _Battle4;
		public string _Battle5;
		public string _Loot;
		public string _Description;
		public int _EnergyRequirement;
		public LevelDataRow(string __NameIndex, string __Name, string __ID, string __Battle1, string __Battle2, string __Battle3, string __Battle4, string __Battle5, string __Loot, string __Description, string __EnergyRequirement) 
		{
			_Name = __Name.Trim();
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
			{
			int res;
				if(int.TryParse(__EnergyRequirement, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EnergyRequirement = res;
				else
					Debug.LogError("Failed To Convert _EnergyRequirement string: "+ __EnergyRequirement +" to int");
			}
		}

		public int Length { get { return 10; } }

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
					ret = _Battle1.ToString();
					break;
				case 3:
					ret = _Battle2.ToString();
					break;
				case 4:
					ret = _Battle3.ToString();
					break;
				case 5:
					ret = _Battle4.ToString();
					break;
				case 6:
					ret = _Battle5.ToString();
					break;
				case 7:
					ret = _Loot.ToString();
					break;
				case 8:
					ret = _Description.ToString();
					break;
				case 9:
					ret = _EnergyRequirement.ToString();
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
				case "EnergyRequirement":
					ret = _EnergyRequirement.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Battle1" + " : " + _Battle1.ToString() + "} ";
			ret += "{" + "Battle2" + " : " + _Battle2.ToString() + "} ";
			ret += "{" + "Battle3" + " : " + _Battle3.ToString() + "} ";
			ret += "{" + "Battle4" + " : " + _Battle4.ToString() + "} ";
			ret += "{" + "Battle5" + " : " + _Battle5.ToString() + "} ";
			ret += "{" + "Loot" + " : " + _Loot.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "EnergyRequirement" + " : " + _EnergyRequirement.ToString() + "} ";
			return ret;
		}
	}
	public sealed class LevelData : IGoogle2uDB
	{
		public enum rowIds {
			L_1, L_2, L_3, L_4, L_5, L_6, L_7, L_8, L_9, L_10, L_11, L_12, L_13, L_14, L_15, L_16, L_17, L_18
			, L_19, L_20
		};
		public string [] rowNames = {
			"L_1", "L_2", "L_3", "L_4", "L_5", "L_6", "L_7", "L_8", "L_9", "L_10", "L_11", "L_12", "L_13", "L_14", "L_15", "L_16", "L_17", "L_18"
			, "L_19", "L_20"
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
			Rows.Add( new LevelDataRow("L_1", "NONAMEYET", "1", "1", "1,1", "", "", "", "", "", "2"));
			Rows.Add( new LevelDataRow("L_2", "NONAMEYET", "2", "1", "1,1,1", "", "", "", "", "", "2"));
			Rows.Add( new LevelDataRow("L_3", "NONAMEYET", "3", "1,2,1", "2,1,2", "", "", "", "", "", "3"));
			Rows.Add( new LevelDataRow("L_4", "NONAMEYET", "4", "2,2", "1,2,1,1", "", "", "", "", "", "3"));
			Rows.Add( new LevelDataRow("L_5", "NONAMEYET", "5", "2,2,2", "1,1,1,1", "2,3,2", "", "", "", "", "3"));
			Rows.Add( new LevelDataRow("L_6", "NONAMEYET", "6", "2,1,1,2", "1,3,1", "", "", "", "", "", "4"));
			Rows.Add( new LevelDataRow("L_7", "NONAMEYET", "7", "2,3,3,2", "1,2,1,2,1", "", "", "", "", "", "4"));
			Rows.Add( new LevelDataRow("L_8", "NONAMEYET", "8", "1,1,1", "1,1,4,1,1", "", "", "", "", "", "4"));
			Rows.Add( new LevelDataRow("L_9", "NONAMEYET", "9", "2,1,4,1", "2,3,3,3,2", "", "", "", "", "", "4"));
			Rows.Add( new LevelDataRow("L_10", "NONAMEYET", "10", "1,1,1,1,1", "1,3,4,3,1", "3,4,5,4,3", "", "", "", "", "5"));
			Rows.Add( new LevelDataRow("L_11", "NONAMEYET", "11", "2,2,2,2", "2,3,4,3,2", "3,1,1,1,3", "", "", "", "", "5"));
			Rows.Add( new LevelDataRow("L_12", "NONAMEYET", "12", "2,1,2,1,2", "4,2,4,2,4", "1,8,3,8,1", "", "", "", "", "5"));
			Rows.Add( new LevelDataRow("L_13", "NONAMEYET", "13", "5,4,1,4,5", "3,3,8,8,3", "2,3,2,3,4", "", "", "", "", "5"));
			Rows.Add( new LevelDataRow("L_14", "NONAMEYET", "14", "1,1,5,8,1,1", "2,1,2,8,8", "1,3,5,5,5", "", "", "", "", "6"));
			Rows.Add( new LevelDataRow("L_15", "NONAMEYET", "15", "1,1,1,1", "2,8,5,8,2", "2,3,4,4,3,2", "1,6,8,6,1", "", "", "", "6"));
			Rows.Add( new LevelDataRow("L_16", "NONAMEYET", "16", "1,1,1,1,1,1", "2,3,4,3,4,8", "1,4,2,6,2,1", "", "", "", "", "6"));
			Rows.Add( new LevelDataRow("L_17", "NONAMEYET", "17", "2,2,2,2,2,2", "3,5,3,5,3", "1,5,5,8,5,5", "", "", "", "", "7"));
			Rows.Add( new LevelDataRow("L_18", "NONAMEYET", "18", "3,3,3,3,3,3", "3,3,8,6,6,9", "2,6,8,9,6,2", "", "", "", "", "7"));
			Rows.Add( new LevelDataRow("L_19", "NONAMEYET", "19", "4,4,4,4,4,4", "7,7,7", "3,4,5,5,4,3", "", "", "", "", "8"));
			Rows.Add( new LevelDataRow("L_20", "NONAMEYET", "20", "5,5,5,5,5,5", "2,1,7,1,2", "2,2,3,3,2,2", "6,8,7,7,6,9", "", "", "", "10"));
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
