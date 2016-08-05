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
	public class ExpTableRow : IGoogle2uRow
	{
		public int _Level;
		public int _ExpNeeded;
		public int _TotalExp;
		public ExpTableRow(string __Name, string __Level, string __ExpNeeded, string __TotalExp) 
		{
			{
			int res;
				if(int.TryParse(__Level, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Level = res;
				else
					Debug.LogError("Failed To Convert _Level string: "+ __Level +" to int");
			}
			{
			int res;
				if(int.TryParse(__ExpNeeded, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ExpNeeded = res;
				else
					Debug.LogError("Failed To Convert _ExpNeeded string: "+ __ExpNeeded +" to int");
			}
			{
			int res;
				if(int.TryParse(__TotalExp, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TotalExp = res;
				else
					Debug.LogError("Failed To Convert _TotalExp string: "+ __TotalExp +" to int");
			}
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
					ret = _Level.ToString();
					break;
				case 1:
					ret = _ExpNeeded.ToString();
					break;
				case 2:
					ret = _TotalExp.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Level":
					ret = _Level.ToString();
					break;
				case "ExpNeeded":
					ret = _ExpNeeded.ToString();
					break;
				case "TotalExp":
					ret = _TotalExp.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Level" + " : " + _Level.ToString() + "} ";
			ret += "{" + "ExpNeeded" + " : " + _ExpNeeded.ToString() + "} ";
			ret += "{" + "TotalExp" + " : " + _TotalExp.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ExpTable : IGoogle2uDB
	{
		public enum rowIds {
			EXP_1, EXP_2, EXP_3, EXP_4, EXP_5, EXP_6, EXP_7, EXP_8, EXP_9, EXP_10, EXP_11, EXP_12, EXP_13, EXP_14, EXP_15, EXP_16, EXP_17, EXP_18
			, EXP_19, EXP_20, EXP_21, EXP_22, EXP_23, EXP_24, EXP_25, EXP_26, EXP_27, EXP_28, EXP_29, EXP_30, EXP_31, EXP_32, EXP_33, EXP_34, EXP_35, EXP_36, EXP_37, EXP_38
			, EXP_39, EXP_40, EXP_41, EXP_42, EXP_43, EXP_44, EXP_45, EXP_46, EXP_47, EXP_48, EXP_49, EXP_50, EXP_51, EXP_52, EXP_53, EXP_54, EXP_55, EXP_56, EXP_57, EXP_58
			, EXP_59, EXP_60, EXP_61, EXP_62, EXP_63, EXP_64, EXP_65, EXP_66, EXP_67, EXP_68, EXP_69, EXP_70, EXP_71, EXP_72, EXP_73, EXP_74, EXP_75, EXP_76, EXP_77, EXP_78
			, EXP_79, EXP_80, EXP_81, EXP_82, EXP_83, EXP_84, EXP_85, EXP_86, EXP_87, EXP_88, EXP_89, EXP_90, EXP_91, EXP_92, EXP_93, EXP_94, EXP_95, EXP_96, EXP_97, EXP_98
			, EXP_99, EXP_100
		};
		public string [] rowNames = {
			"EXP_1", "EXP_2", "EXP_3", "EXP_4", "EXP_5", "EXP_6", "EXP_7", "EXP_8", "EXP_9", "EXP_10", "EXP_11", "EXP_12", "EXP_13", "EXP_14", "EXP_15", "EXP_16", "EXP_17", "EXP_18"
			, "EXP_19", "EXP_20", "EXP_21", "EXP_22", "EXP_23", "EXP_24", "EXP_25", "EXP_26", "EXP_27", "EXP_28", "EXP_29", "EXP_30", "EXP_31", "EXP_32", "EXP_33", "EXP_34", "EXP_35", "EXP_36", "EXP_37", "EXP_38"
			, "EXP_39", "EXP_40", "EXP_41", "EXP_42", "EXP_43", "EXP_44", "EXP_45", "EXP_46", "EXP_47", "EXP_48", "EXP_49", "EXP_50", "EXP_51", "EXP_52", "EXP_53", "EXP_54", "EXP_55", "EXP_56", "EXP_57", "EXP_58"
			, "EXP_59", "EXP_60", "EXP_61", "EXP_62", "EXP_63", "EXP_64", "EXP_65", "EXP_66", "EXP_67", "EXP_68", "EXP_69", "EXP_70", "EXP_71", "EXP_72", "EXP_73", "EXP_74", "EXP_75", "EXP_76", "EXP_77", "EXP_78"
			, "EXP_79", "EXP_80", "EXP_81", "EXP_82", "EXP_83", "EXP_84", "EXP_85", "EXP_86", "EXP_87", "EXP_88", "EXP_89", "EXP_90", "EXP_91", "EXP_92", "EXP_93", "EXP_94", "EXP_95", "EXP_96", "EXP_97", "EXP_98"
			, "EXP_99", "EXP_100"
		};
		public System.Collections.Generic.List<ExpTableRow> Rows = new System.Collections.Generic.List<ExpTableRow>();

		public static ExpTable Instance
		{
			get { return NestedExpTable.instance; }
		}

		private class NestedExpTable
		{
			static NestedExpTable() { }
			internal static readonly ExpTable instance = new ExpTable();
		}

		private ExpTable()
		{
			Rows.Add( new ExpTableRow("EXP_1", "1", "10", "10"));
			Rows.Add( new ExpTableRow("EXP_2", "2", "40", "50"));
			Rows.Add( new ExpTableRow("EXP_3", "3", "90", "140"));
			Rows.Add( new ExpTableRow("EXP_4", "4", "160", "300"));
			Rows.Add( new ExpTableRow("EXP_5", "5", "250", "550"));
			Rows.Add( new ExpTableRow("EXP_6", "6", "360", "910"));
			Rows.Add( new ExpTableRow("EXP_7", "7", "490", "1400"));
			Rows.Add( new ExpTableRow("EXP_8", "8", "640", "2040"));
			Rows.Add( new ExpTableRow("EXP_9", "9", "810", "2850"));
			Rows.Add( new ExpTableRow("EXP_10", "10", "1000", "3850"));
			Rows.Add( new ExpTableRow("EXP_11", "11", "1210", "5060"));
			Rows.Add( new ExpTableRow("EXP_12", "12", "1440", "6500"));
			Rows.Add( new ExpTableRow("EXP_13", "13", "1690", "8190"));
			Rows.Add( new ExpTableRow("EXP_14", "14", "1960", "10150"));
			Rows.Add( new ExpTableRow("EXP_15", "15", "2250", "12400"));
			Rows.Add( new ExpTableRow("EXP_16", "16", "2560", "14960"));
			Rows.Add( new ExpTableRow("EXP_17", "17", "2890", "17850"));
			Rows.Add( new ExpTableRow("EXP_18", "18", "3240", "21090"));
			Rows.Add( new ExpTableRow("EXP_19", "19", "3610", "24700"));
			Rows.Add( new ExpTableRow("EXP_20", "20", "4000", "28700"));
			Rows.Add( new ExpTableRow("EXP_21", "21", "4410", "33110"));
			Rows.Add( new ExpTableRow("EXP_22", "22", "4840", "37950"));
			Rows.Add( new ExpTableRow("EXP_23", "23", "5290", "43240"));
			Rows.Add( new ExpTableRow("EXP_24", "24", "5760", "49000"));
			Rows.Add( new ExpTableRow("EXP_25", "25", "6250", "55250"));
			Rows.Add( new ExpTableRow("EXP_26", "26", "6760", "62010"));
			Rows.Add( new ExpTableRow("EXP_27", "27", "7290", "69300"));
			Rows.Add( new ExpTableRow("EXP_28", "28", "7840", "77140"));
			Rows.Add( new ExpTableRow("EXP_29", "29", "8410", "85550"));
			Rows.Add( new ExpTableRow("EXP_30", "30", "9000", "94550"));
			Rows.Add( new ExpTableRow("EXP_31", "31", "9610", "104160"));
			Rows.Add( new ExpTableRow("EXP_32", "32", "10240", "114400"));
			Rows.Add( new ExpTableRow("EXP_33", "33", "10890", "125290"));
			Rows.Add( new ExpTableRow("EXP_34", "34", "11560", "136850"));
			Rows.Add( new ExpTableRow("EXP_35", "35", "12250", "149100"));
			Rows.Add( new ExpTableRow("EXP_36", "36", "12960", "162060"));
			Rows.Add( new ExpTableRow("EXP_37", "37", "13690", "175750"));
			Rows.Add( new ExpTableRow("EXP_38", "38", "14440", "190190"));
			Rows.Add( new ExpTableRow("EXP_39", "39", "15210", "205400"));
			Rows.Add( new ExpTableRow("EXP_40", "40", "16000", "221400"));
			Rows.Add( new ExpTableRow("EXP_41", "41", "16810", "238210"));
			Rows.Add( new ExpTableRow("EXP_42", "42", "17640", "255850"));
			Rows.Add( new ExpTableRow("EXP_43", "43", "18490", "274340"));
			Rows.Add( new ExpTableRow("EXP_44", "44", "19360", "293700"));
			Rows.Add( new ExpTableRow("EXP_45", "45", "20250", "313950"));
			Rows.Add( new ExpTableRow("EXP_46", "46", "21160", "335110"));
			Rows.Add( new ExpTableRow("EXP_47", "47", "22090", "357200"));
			Rows.Add( new ExpTableRow("EXP_48", "48", "23040", "380240"));
			Rows.Add( new ExpTableRow("EXP_49", "49", "24010", "404250"));
			Rows.Add( new ExpTableRow("EXP_50", "50", "25000", "429250"));
			Rows.Add( new ExpTableRow("EXP_51", "51", "26010", "455260"));
			Rows.Add( new ExpTableRow("EXP_52", "52", "27040", "482300"));
			Rows.Add( new ExpTableRow("EXP_53", "53", "28090", "510390"));
			Rows.Add( new ExpTableRow("EXP_54", "54", "29160", "539550"));
			Rows.Add( new ExpTableRow("EXP_55", "55", "30250", "569800"));
			Rows.Add( new ExpTableRow("EXP_56", "56", "31360", "601160"));
			Rows.Add( new ExpTableRow("EXP_57", "57", "32490", "633650"));
			Rows.Add( new ExpTableRow("EXP_58", "58", "33640", "667290"));
			Rows.Add( new ExpTableRow("EXP_59", "59", "34810", "702100"));
			Rows.Add( new ExpTableRow("EXP_60", "60", "36000", "738100"));
			Rows.Add( new ExpTableRow("EXP_61", "61", "37210", "775310"));
			Rows.Add( new ExpTableRow("EXP_62", "62", "38440", "813750"));
			Rows.Add( new ExpTableRow("EXP_63", "63", "39690", "853440"));
			Rows.Add( new ExpTableRow("EXP_64", "64", "40960", "894400"));
			Rows.Add( new ExpTableRow("EXP_65", "65", "42250", "936650"));
			Rows.Add( new ExpTableRow("EXP_66", "66", "43560", "980210"));
			Rows.Add( new ExpTableRow("EXP_67", "67", "44890", "1025100"));
			Rows.Add( new ExpTableRow("EXP_68", "68", "46240", "1071340"));
			Rows.Add( new ExpTableRow("EXP_69", "69", "47610", "1118950"));
			Rows.Add( new ExpTableRow("EXP_70", "70", "49000", "1167950"));
			Rows.Add( new ExpTableRow("EXP_71", "71", "50410", "1218360"));
			Rows.Add( new ExpTableRow("EXP_72", "72", "51840", "1270200"));
			Rows.Add( new ExpTableRow("EXP_73", "73", "53290", "1323490"));
			Rows.Add( new ExpTableRow("EXP_74", "74", "54760", "1378250"));
			Rows.Add( new ExpTableRow("EXP_75", "75", "56250", "1434500"));
			Rows.Add( new ExpTableRow("EXP_76", "76", "57760", "1492260"));
			Rows.Add( new ExpTableRow("EXP_77", "77", "59290", "1551550"));
			Rows.Add( new ExpTableRow("EXP_78", "78", "60840", "1612390"));
			Rows.Add( new ExpTableRow("EXP_79", "79", "62410", "1674800"));
			Rows.Add( new ExpTableRow("EXP_80", "80", "64000", "1738800"));
			Rows.Add( new ExpTableRow("EXP_81", "81", "65610", "1804410"));
			Rows.Add( new ExpTableRow("EXP_82", "82", "67240", "1871650"));
			Rows.Add( new ExpTableRow("EXP_83", "83", "68890", "1940540"));
			Rows.Add( new ExpTableRow("EXP_84", "84", "70560", "2011100"));
			Rows.Add( new ExpTableRow("EXP_85", "85", "72250", "2083350"));
			Rows.Add( new ExpTableRow("EXP_86", "86", "73960", "2157310"));
			Rows.Add( new ExpTableRow("EXP_87", "87", "75690", "2233000"));
			Rows.Add( new ExpTableRow("EXP_88", "88", "77440", "2310440"));
			Rows.Add( new ExpTableRow("EXP_89", "89", "79210", "2389650"));
			Rows.Add( new ExpTableRow("EXP_90", "90", "81000", "2470650"));
			Rows.Add( new ExpTableRow("EXP_91", "91", "82810", "2553460"));
			Rows.Add( new ExpTableRow("EXP_92", "92", "84640", "2638100"));
			Rows.Add( new ExpTableRow("EXP_93", "93", "86490", "2724590"));
			Rows.Add( new ExpTableRow("EXP_94", "94", "88360", "2812950"));
			Rows.Add( new ExpTableRow("EXP_95", "95", "90250", "2903200"));
			Rows.Add( new ExpTableRow("EXP_96", "96", "92160", "2995360"));
			Rows.Add( new ExpTableRow("EXP_97", "97", "94090", "3089450"));
			Rows.Add( new ExpTableRow("EXP_98", "98", "96040", "3185490"));
			Rows.Add( new ExpTableRow("EXP_99", "99", "98010", "3283500"));
			Rows.Add( new ExpTableRow("EXP_100", "100", "100000", "3383500"));
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
		public ExpTableRow GetRow(rowIds in_RowID)
		{
			ExpTableRow ret = null;
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
		public ExpTableRow GetRow(string in_RowString)
		{
			ExpTableRow ret = null;
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
