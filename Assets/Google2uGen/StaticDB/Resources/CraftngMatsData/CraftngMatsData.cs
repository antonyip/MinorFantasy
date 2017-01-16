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
	public class CraftngMatsDataRow : IGoogle2uRow
	{
		public int _ID;
		public string _Sprite;
		public CraftngMatsDataRow(string __Name, string __ID, string __Sprite) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Sprite = __Sprite.Trim();
		}

		public int Length { get { return 2; } }

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
				case "ID":
					ret = _ID.ToString();
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
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Sprite" + " : " + _Sprite.ToString() + "} ";
			return ret;
		}
	}
	public sealed class CraftngMatsData : IGoogle2uDB
	{
		public enum rowIds {
			Tree_Log
		};
		public string [] rowNames = {
			"Tree_Log"
		};
		public System.Collections.Generic.List<CraftngMatsDataRow> Rows = new System.Collections.Generic.List<CraftngMatsDataRow>();

		public static CraftngMatsData Instance
		{
			get { return NestedCraftngMatsData.instance; }
		}

		private class NestedCraftngMatsData
		{
			static NestedCraftngMatsData() { }
			internal static readonly CraftngMatsData instance = new CraftngMatsData();
		}

		private CraftngMatsData()
		{
			Rows.Add( new CraftngMatsDataRow("Tree_Log", "1", "Tree_Log_Image"));
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
		public CraftngMatsDataRow GetRow(rowIds in_RowID)
		{
			CraftngMatsDataRow ret = null;
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
		public CraftngMatsDataRow GetRow(string in_RowString)
		{
			CraftngMatsDataRow ret = null;
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
