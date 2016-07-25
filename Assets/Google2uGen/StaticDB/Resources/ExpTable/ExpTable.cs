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
		public ExpTableRow(string __Name, string __Level, string __ExpNeeded) 
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
					ret = _Level.ToString();
					break;
				case 1:
					ret = _ExpNeeded.ToString();
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
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Level" + " : " + _Level.ToString() + "} ";
			ret += "{" + "ExpNeeded" + " : " + _ExpNeeded.ToString() + "} ";
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
			Rows.Add( new ExpTableRow("EXP_1", "1", "1"));
			Rows.Add( new ExpTableRow("EXP_2", "2", "4"));
			Rows.Add( new ExpTableRow("EXP_3", "3", "9"));
			Rows.Add( new ExpTableRow("EXP_4", "4", "16"));
			Rows.Add( new ExpTableRow("EXP_5", "5", "25"));
			Rows.Add( new ExpTableRow("EXP_6", "6", "36"));
			Rows.Add( new ExpTableRow("EXP_7", "7", "49"));
			Rows.Add( new ExpTableRow("EXP_8", "8", "64"));
			Rows.Add( new ExpTableRow("EXP_9", "9", "81"));
			Rows.Add( new ExpTableRow("EXP_10", "10", "100"));
			Rows.Add( new ExpTableRow("EXP_11", "11", "121"));
			Rows.Add( new ExpTableRow("EXP_12", "12", "144"));
			Rows.Add( new ExpTableRow("EXP_13", "13", "169"));
			Rows.Add( new ExpTableRow("EXP_14", "14", "196"));
			Rows.Add( new ExpTableRow("EXP_15", "15", "225"));
			Rows.Add( new ExpTableRow("EXP_16", "16", "256"));
			Rows.Add( new ExpTableRow("EXP_17", "17", "289"));
			Rows.Add( new ExpTableRow("EXP_18", "18", "324"));
			Rows.Add( new ExpTableRow("EXP_19", "19", "361"));
			Rows.Add( new ExpTableRow("EXP_20", "20", "400"));
			Rows.Add( new ExpTableRow("EXP_21", "21", "441"));
			Rows.Add( new ExpTableRow("EXP_22", "22", "484"));
			Rows.Add( new ExpTableRow("EXP_23", "23", "529"));
			Rows.Add( new ExpTableRow("EXP_24", "24", "576"));
			Rows.Add( new ExpTableRow("EXP_25", "25", "625"));
			Rows.Add( new ExpTableRow("EXP_26", "26", "676"));
			Rows.Add( new ExpTableRow("EXP_27", "27", "729"));
			Rows.Add( new ExpTableRow("EXP_28", "28", "784"));
			Rows.Add( new ExpTableRow("EXP_29", "29", "841"));
			Rows.Add( new ExpTableRow("EXP_30", "30", "900"));
			Rows.Add( new ExpTableRow("EXP_31", "31", "961"));
			Rows.Add( new ExpTableRow("EXP_32", "32", "1024"));
			Rows.Add( new ExpTableRow("EXP_33", "33", "1089"));
			Rows.Add( new ExpTableRow("EXP_34", "34", "1156"));
			Rows.Add( new ExpTableRow("EXP_35", "35", "1225"));
			Rows.Add( new ExpTableRow("EXP_36", "36", "1296"));
			Rows.Add( new ExpTableRow("EXP_37", "37", "1369"));
			Rows.Add( new ExpTableRow("EXP_38", "38", "1444"));
			Rows.Add( new ExpTableRow("EXP_39", "39", "1521"));
			Rows.Add( new ExpTableRow("EXP_40", "40", "1600"));
			Rows.Add( new ExpTableRow("EXP_41", "41", "1681"));
			Rows.Add( new ExpTableRow("EXP_42", "42", "1764"));
			Rows.Add( new ExpTableRow("EXP_43", "43", "1849"));
			Rows.Add( new ExpTableRow("EXP_44", "44", "1936"));
			Rows.Add( new ExpTableRow("EXP_45", "45", "2025"));
			Rows.Add( new ExpTableRow("EXP_46", "46", "2116"));
			Rows.Add( new ExpTableRow("EXP_47", "47", "2209"));
			Rows.Add( new ExpTableRow("EXP_48", "48", "2304"));
			Rows.Add( new ExpTableRow("EXP_49", "49", "2401"));
			Rows.Add( new ExpTableRow("EXP_50", "50", "2500"));
			Rows.Add( new ExpTableRow("EXP_51", "51", "2601"));
			Rows.Add( new ExpTableRow("EXP_52", "52", "2704"));
			Rows.Add( new ExpTableRow("EXP_53", "53", "2809"));
			Rows.Add( new ExpTableRow("EXP_54", "54", "2916"));
			Rows.Add( new ExpTableRow("EXP_55", "55", "3025"));
			Rows.Add( new ExpTableRow("EXP_56", "56", "3136"));
			Rows.Add( new ExpTableRow("EXP_57", "57", "3249"));
			Rows.Add( new ExpTableRow("EXP_58", "58", "3364"));
			Rows.Add( new ExpTableRow("EXP_59", "59", "3481"));
			Rows.Add( new ExpTableRow("EXP_60", "60", "3600"));
			Rows.Add( new ExpTableRow("EXP_61", "61", "3721"));
			Rows.Add( new ExpTableRow("EXP_62", "62", "3844"));
			Rows.Add( new ExpTableRow("EXP_63", "63", "3969"));
			Rows.Add( new ExpTableRow("EXP_64", "64", "4096"));
			Rows.Add( new ExpTableRow("EXP_65", "65", "4225"));
			Rows.Add( new ExpTableRow("EXP_66", "66", "4356"));
			Rows.Add( new ExpTableRow("EXP_67", "67", "4489"));
			Rows.Add( new ExpTableRow("EXP_68", "68", "4624"));
			Rows.Add( new ExpTableRow("EXP_69", "69", "4761"));
			Rows.Add( new ExpTableRow("EXP_70", "70", "4900"));
			Rows.Add( new ExpTableRow("EXP_71", "71", "5041"));
			Rows.Add( new ExpTableRow("EXP_72", "72", "5184"));
			Rows.Add( new ExpTableRow("EXP_73", "73", "5329"));
			Rows.Add( new ExpTableRow("EXP_74", "74", "5476"));
			Rows.Add( new ExpTableRow("EXP_75", "75", "5625"));
			Rows.Add( new ExpTableRow("EXP_76", "76", "5776"));
			Rows.Add( new ExpTableRow("EXP_77", "77", "5929"));
			Rows.Add( new ExpTableRow("EXP_78", "78", "6084"));
			Rows.Add( new ExpTableRow("EXP_79", "79", "6241"));
			Rows.Add( new ExpTableRow("EXP_80", "80", "6400"));
			Rows.Add( new ExpTableRow("EXP_81", "81", "6561"));
			Rows.Add( new ExpTableRow("EXP_82", "82", "6724"));
			Rows.Add( new ExpTableRow("EXP_83", "83", "6889"));
			Rows.Add( new ExpTableRow("EXP_84", "84", "7056"));
			Rows.Add( new ExpTableRow("EXP_85", "85", "7225"));
			Rows.Add( new ExpTableRow("EXP_86", "86", "7396"));
			Rows.Add( new ExpTableRow("EXP_87", "87", "7569"));
			Rows.Add( new ExpTableRow("EXP_88", "88", "7744"));
			Rows.Add( new ExpTableRow("EXP_89", "89", "7921"));
			Rows.Add( new ExpTableRow("EXP_90", "90", "8100"));
			Rows.Add( new ExpTableRow("EXP_91", "91", "8281"));
			Rows.Add( new ExpTableRow("EXP_92", "92", "8464"));
			Rows.Add( new ExpTableRow("EXP_93", "93", "8649"));
			Rows.Add( new ExpTableRow("EXP_94", "94", "8836"));
			Rows.Add( new ExpTableRow("EXP_95", "95", "9025"));
			Rows.Add( new ExpTableRow("EXP_96", "96", "9216"));
			Rows.Add( new ExpTableRow("EXP_97", "97", "9409"));
			Rows.Add( new ExpTableRow("EXP_98", "98", "9604"));
			Rows.Add( new ExpTableRow("EXP_99", "99", "9801"));
			Rows.Add( new ExpTableRow("EXP_100", "100", "10000"));
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
