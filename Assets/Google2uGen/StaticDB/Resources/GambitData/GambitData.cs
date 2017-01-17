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
	public class GambitDataRow : IGoogle2uRow
	{
		public string _Name;
		public string _Type;
		public int _ID;
		public string _Description;
		public string _Sprite;
		public GambitDataRow(string __GamditIndex, string __Name, string __Type, string __ID, string __Description, string __Sprite) 
		{
			_Name = __Name.Trim();
			_Type = __Type.Trim();
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Description = __Description.Trim();
			_Sprite = __Sprite.Trim();
		}

		public int Length { get { return 5; } }

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
					ret = _Type.ToString();
					break;
				case 2:
					ret = _ID.ToString();
					break;
				case 3:
					ret = _Description.ToString();
					break;
				case 4:
					ret = _Sprite.ToString();
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
				case "Type":
					ret = _Type.ToString();
					break;
				case "ID":
					ret = _ID.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "Sprite":
					ret = _Sprite.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Type" + " : " + _Type.ToString() + "} ";
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "Sprite" + " : " + _Sprite.ToString() + "} ";
			return ret;
		}
	}
	public sealed class GambitData : IGoogle2uDB
	{
		public enum rowIds {
			G_1, G_2, G_3, G_4, G_5, G_6, G_7, G_8, G_9, G_10, G_11, G_12, G_13, G_14, G_15, G_16, G_17, G_18
			, G_19, G_20
		};
		public string [] rowNames = {
			"G_1", "G_2", "G_3", "G_4", "G_5", "G_6", "G_7", "G_8", "G_9", "G_10", "G_11", "G_12", "G_13", "G_14", "G_15", "G_16", "G_17", "G_18"
			, "G_19", "G_20"
		};
		public System.Collections.Generic.List<GambitDataRow> Rows = new System.Collections.Generic.List<GambitDataRow>();

		public static GambitData Instance
		{
			get { return NestedGambitData.instance; }
		}

		private class NestedGambitData
		{
			static NestedGambitData() { }
			internal static readonly GambitData instance = new GambitData();
		}

		private GambitData()
		{
			Rows.Add( new GambitDataRow("G_1", "Any_Enemy", "Gambit_Target", "1", "Selects an Enemy at random", "NONE"));
			Rows.Add( new GambitDataRow("G_2", "Enemy > 75%", "Gambit_Target", "2", "Enemy > 75%", "NONE"));
			Rows.Add( new GambitDataRow("G_3", "Enemy > 50%", "Gambit_Target", "3", "Enemy > 50%", "NONE"));
			Rows.Add( new GambitDataRow("G_4", "Enemy > 25%", "Gambit_Target", "4", "Enemy > 25%", "NONE"));
			Rows.Add( new GambitDataRow("G_5", "Ally > 75%", "Gambit_Target", "5", "Ally > 75%", "NONE"));
			Rows.Add( new GambitDataRow("G_6", "Ally > 50%", "Gambit_Target", "6", "Ally > 50%", "NONE"));
			Rows.Add( new GambitDataRow("G_7", "Ally > 25%", "Gambit_Target", "7", "Ally > 25%", "NONE"));
			Rows.Add( new GambitDataRow("G_8", "Any_Ally", "Gambit_Target", "8", "Any_Ally", "NONE"));
			Rows.Add( new GambitDataRow("G_9", "Enemy Team", "Gambit_Team", "9", "Enemy Team", "NONE"));
			Rows.Add( new GambitDataRow("G_10", "Ally Team", "Gambit_Team", "10", "Ally Team", "NONE"));
			Rows.Add( new GambitDataRow("G_11", "Burnt Ally", "Gambit_Target", "11", "Burnt Ally", "NONE"));
			Rows.Add( new GambitDataRow("G_12", "Frozen Ally", "Gambit_Target", "12", "Frozen Ally", "NONE"));
			Rows.Add( new GambitDataRow("G_13", "Shocked Ally", "Gambit_Target", "13", "Shocked Ally", "NONE"));
			Rows.Add( new GambitDataRow("G_14", "Burnt Enemy", "Gambit_Target", "14", "Burnt Enemy", "NONE"));
			Rows.Add( new GambitDataRow("G_15", "Frozen Enemy", "Gambit_Target", "15", "Frozen Enemy", "NONE"));
			Rows.Add( new GambitDataRow("G_16", "Shocked Enemy", "Gambit_Target", "16", "Shocked Enemy", "NONE"));
			Rows.Add( new GambitDataRow("G_17", "Do Once Per Battle", "Gambit_Team", "17", "Do Once Per Battle", "NONE"));
			Rows.Add( new GambitDataRow("G_18", "Every Other Turn", "Gambit_Team", "18", "Every Other Turn", "NONE"));
			Rows.Add( new GambitDataRow("G_19", "Every 5 turns", "Gambit_Team", "19", "Every 5 turns", "NONE"));
			Rows.Add( new GambitDataRow("G_20", "Every Turn", "Gambit_Team", "20", "Every Turn", "NONE"));
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
		public GambitDataRow GetRow(rowIds in_RowID)
		{
			GambitDataRow ret = null;
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
		public GambitDataRow GetRow(string in_RowString)
		{
			GambitDataRow ret = null;
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
