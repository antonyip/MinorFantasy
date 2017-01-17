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
	public class LevelsRow : IGoogle2uRow
	{
		public string _L_NAME;
		public int _L_UPWARD;
		public int _L_RIGHTWARD;
		public string _L_FLOOR;
		public string _L_TOWER;
		public LevelsRow(string __L_ID, string __L_NAME, string __L_UPWARD, string __L_RIGHTWARD, string __L_FLOOR, string __L_TOWER) 
		{
			_L_NAME = __L_NAME.Trim();
			{
			int res;
				if(int.TryParse(__L_UPWARD, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_L_UPWARD = res;
				else
					Debug.LogError("Failed To Convert _L_UPWARD string: "+ __L_UPWARD +" to int");
			}
			{
			int res;
				if(int.TryParse(__L_RIGHTWARD, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_L_RIGHTWARD = res;
				else
					Debug.LogError("Failed To Convert _L_RIGHTWARD string: "+ __L_RIGHTWARD +" to int");
			}
			_L_FLOOR = __L_FLOOR.Trim();
			_L_TOWER = __L_TOWER.Trim();
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
					ret = _L_NAME.ToString();
					break;
				case 1:
					ret = _L_UPWARD.ToString();
					break;
				case 2:
					ret = _L_RIGHTWARD.ToString();
					break;
				case 3:
					ret = _L_FLOOR.ToString();
					break;
				case 4:
					ret = _L_TOWER.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "L_NAME":
					ret = _L_NAME.ToString();
					break;
				case "L_UPWARD":
					ret = _L_UPWARD.ToString();
					break;
				case "L_RIGHTWARD":
					ret = _L_RIGHTWARD.ToString();
					break;
				case "L_FLOOR":
					ret = _L_FLOOR.ToString();
					break;
				case "L_TOWER":
					ret = _L_TOWER.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "L_NAME" + " : " + _L_NAME.ToString() + "} ";
			ret += "{" + "L_UPWARD" + " : " + _L_UPWARD.ToString() + "} ";
			ret += "{" + "L_RIGHTWARD" + " : " + _L_RIGHTWARD.ToString() + "} ";
			ret += "{" + "L_FLOOR" + " : " + _L_FLOOR.ToString() + "} ";
			ret += "{" + "L_TOWER" + " : " + _L_TOWER.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Levels : IGoogle2uDB
	{
		public enum rowIds {
			L01
		};
		public string [] rowNames = {
			"L01"
		};
		public System.Collections.Generic.List<LevelsRow> Rows = new System.Collections.Generic.List<LevelsRow>();

		public static Levels Instance
		{
			get { return NestedLevels.instance; }
		}

		private class NestedLevels
		{
			static NestedLevels() { }
			internal static readonly Levels instance = new Levels();
		}

		private Levels()
		{
			Rows.Add( new LevelsRow("L01", "a", "6", "8", "NNNENNNWWWWNNWWWWNNWWSWNNWNWWNNNNNNNRBGYPONWNWWN", ""));
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
		public LevelsRow GetRow(rowIds in_RowID)
		{
			LevelsRow ret = null;
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
		public LevelsRow GetRow(string in_RowString)
		{
			LevelsRow ret = null;
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
