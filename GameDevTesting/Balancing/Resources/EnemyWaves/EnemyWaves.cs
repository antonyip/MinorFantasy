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
	public class EnemyWavesRow : IGoogle2uRow
	{
		public int _W_ID;
		public int _W_COUNT;
		public EnemyWavesRow(string __W_NO, string __W_ID, string __W_COUNT) 
		{
			{
			int res;
				if(int.TryParse(__W_ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_W_ID = res;
				else
					Debug.LogError("Failed To Convert _W_ID string: "+ __W_ID +" to int");
			}
			{
			int res;
				if(int.TryParse(__W_COUNT, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_W_COUNT = res;
				else
					Debug.LogError("Failed To Convert _W_COUNT string: "+ __W_COUNT +" to int");
			}
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
					ret = _W_ID.ToString();
					break;
				case 1:
					ret = _W_COUNT.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "W_ID":
					ret = _W_ID.ToString();
					break;
				case "W_COUNT":
					ret = _W_COUNT.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "W_ID" + " : " + _W_ID.ToString() + "} ";
			ret += "{" + "W_COUNT" + " : " + _W_COUNT.ToString() + "} ";
			return ret;
		}
	}
	public sealed class EnemyWaves : IGoogle2uDB
	{
		public enum rowIds {
			W0, W1, W2, W3, W4, W5, W6, W7, W8, W9, W10, W11, W12, W13, W14, W15, W16, W17
			, W18, W19, W20, W21, W22, W23, W24, W25, W26, W27, W28, W29, W30, W31, W32, W33, W34, W35, W36, W37
			, W38, W39, W40, W41, W42, W43, W44, W45, W46, W47, W48, W49, W50
		};
		public string [] rowNames = {
			"W0", "W1", "W2", "W3", "W4", "W5", "W6", "W7", "W8", "W9", "W10", "W11", "W12", "W13", "W14", "W15", "W16", "W17"
			, "W18", "W19", "W20", "W21", "W22", "W23", "W24", "W25", "W26", "W27", "W28", "W29", "W30", "W31", "W32", "W33", "W34", "W35", "W36", "W37"
			, "W38", "W39", "W40", "W41", "W42", "W43", "W44", "W45", "W46", "W47", "W48", "W49", "W50"
		};
		public System.Collections.Generic.List<EnemyWavesRow> Rows = new System.Collections.Generic.List<EnemyWavesRow>();

		public static EnemyWaves Instance
		{
			get { return NestedEnemyWaves.instance; }
		}

		private class NestedEnemyWaves
		{
			static NestedEnemyWaves() { }
			internal static readonly EnemyWaves instance = new EnemyWaves();
		}

		private EnemyWaves()
		{
			Rows.Add( new EnemyWavesRow("W0", "0", "5"));
			Rows.Add( new EnemyWavesRow("W1", "1", "5"));
			Rows.Add( new EnemyWavesRow("W2", "2", "5"));
			Rows.Add( new EnemyWavesRow("W3", "3", "5"));
			Rows.Add( new EnemyWavesRow("W4", "4", "5"));
			Rows.Add( new EnemyWavesRow("W5", "5", "10"));
			Rows.Add( new EnemyWavesRow("W6", "6", "10"));
			Rows.Add( new EnemyWavesRow("W7", "7", "10"));
			Rows.Add( new EnemyWavesRow("W8", "8", "10"));
			Rows.Add( new EnemyWavesRow("W9", "9", "12"));
			Rows.Add( new EnemyWavesRow("W10", "10", "12"));
			Rows.Add( new EnemyWavesRow("W11", "0", "12"));
			Rows.Add( new EnemyWavesRow("W12", "1", "12"));
			Rows.Add( new EnemyWavesRow("W13", "2", "12"));
			Rows.Add( new EnemyWavesRow("W14", "3", "12"));
			Rows.Add( new EnemyWavesRow("W15", "4", "12"));
			Rows.Add( new EnemyWavesRow("W16", "5", "12"));
			Rows.Add( new EnemyWavesRow("W17", "6", "12"));
			Rows.Add( new EnemyWavesRow("W18", "7", "12"));
			Rows.Add( new EnemyWavesRow("W19", "8", "15"));
			Rows.Add( new EnemyWavesRow("W20", "9", "15"));
			Rows.Add( new EnemyWavesRow("W21", "10", "15"));
			Rows.Add( new EnemyWavesRow("W22", "0", "15"));
			Rows.Add( new EnemyWavesRow("W23", "1", "15"));
			Rows.Add( new EnemyWavesRow("W24", "2", "15"));
			Rows.Add( new EnemyWavesRow("W25", "3", "15"));
			Rows.Add( new EnemyWavesRow("W26", "4", "15"));
			Rows.Add( new EnemyWavesRow("W27", "5", "15"));
			Rows.Add( new EnemyWavesRow("W28", "6", "15"));
			Rows.Add( new EnemyWavesRow("W29", "7", "15"));
			Rows.Add( new EnemyWavesRow("W30", "8", "15"));
			Rows.Add( new EnemyWavesRow("W31", "9", "20"));
			Rows.Add( new EnemyWavesRow("W32", "10", "20"));
			Rows.Add( new EnemyWavesRow("W33", "0", "20"));
			Rows.Add( new EnemyWavesRow("W34", "1", "20"));
			Rows.Add( new EnemyWavesRow("W35", "2", "20"));
			Rows.Add( new EnemyWavesRow("W36", "3", "20"));
			Rows.Add( new EnemyWavesRow("W37", "4", "20"));
			Rows.Add( new EnemyWavesRow("W38", "5", "25"));
			Rows.Add( new EnemyWavesRow("W39", "6", "25"));
			Rows.Add( new EnemyWavesRow("W40", "7", "25"));
			Rows.Add( new EnemyWavesRow("W41", "8", "25"));
			Rows.Add( new EnemyWavesRow("W42", "9", "28"));
			Rows.Add( new EnemyWavesRow("W43", "10", "28"));
			Rows.Add( new EnemyWavesRow("W44", "0", "28"));
			Rows.Add( new EnemyWavesRow("W45", "1", "30"));
			Rows.Add( new EnemyWavesRow("W46", "2", "30"));
			Rows.Add( new EnemyWavesRow("W47", "3", "30"));
			Rows.Add( new EnemyWavesRow("W48", "4", "30"));
			Rows.Add( new EnemyWavesRow("W49", "5", "30"));
			Rows.Add( new EnemyWavesRow("W50", "6", "30"));
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
		public EnemyWavesRow GetRow(rowIds in_RowID)
		{
			EnemyWavesRow ret = null;
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
		public EnemyWavesRow GetRow(string in_RowString)
		{
			EnemyWavesRow ret = null;
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
