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
	public class MapDataRow : IGoogle2uRow
	{
		public int _ID;
		public string _LevelData;
		public string _Story;
		public MapDataRow(string __Name, string __ID, string __LevelData, string __Story) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_LevelData = __LevelData.Trim();
			_Story = __Story.Trim();
		}

		public int Length { get { return 3; } }

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
					ret = _LevelData.ToString();
					break;
				case 2:
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
				case "ID":
					ret = _ID.ToString();
					break;
				case "LevelData":
					ret = _LevelData.ToString();
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
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "LevelData" + " : " + _LevelData.ToString() + "} ";
			ret += "{" + "Story" + " : " + _Story.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MapData : IGoogle2uDB
	{
		public enum rowIds {
			Forest
		};
		public string [] rowNames = {
			"Forest"
		};
		public System.Collections.Generic.List<MapDataRow> Rows = new System.Collections.Generic.List<MapDataRow>();

		public static MapData Instance
		{
			get { return NestedMapData.instance; }
		}

		private class NestedMapData
		{
			static NestedMapData() { }
			internal static readonly MapData instance = new MapData();
		}

		private MapData()
		{
			Rows.Add( new MapDataRow("Forest", "1", "1,2", ""));
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
		public MapDataRow GetRow(rowIds in_RowID)
		{
			MapDataRow ret = null;
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
		public MapDataRow GetRow(string in_RowString)
		{
			MapDataRow ret = null;
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
