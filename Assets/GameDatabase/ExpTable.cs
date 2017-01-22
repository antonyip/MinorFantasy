using System;
using System.Collections.Generic;
using System.Linq;

namespace AntTool
{
  public class ExpTableRow
  {
    public string _Name;
    public int _Level;
    public int _ExpNeeded;
    public int _TotalExp;
    public ExpTableRow(string Name,int Level,int ExpNeeded,int TotalExp)
    {
     _Name = Name;
     _Level = Level;
     _ExpNeeded = ExpNeeded;
     _TotalExp = TotalExp;
    }
  } // class ExpTableRow
  public class ExpTable
  {
    private ExpTable()
    {
      Rows.Add(new ExpTableRow("EXP_0000",0,0,0));
      Rows.Add(new ExpTableRow("EXP_0001",1,10,10));
      Rows.Add(new ExpTableRow("EXP_0002",2,40,50));
      Rows.Add(new ExpTableRow("EXP_0003",3,90,140));
      Rows.Add(new ExpTableRow("EXP_0004",4,160,300));
      Rows.Add(new ExpTableRow("EXP_0005",5,250,550));
      Rows.Add(new ExpTableRow("EXP_0006",6,360,910));
      Rows.Add(new ExpTableRow("EXP_0007",7,490,1400));
      Rows.Add(new ExpTableRow("EXP_0008",8,640,2040));
      Rows.Add(new ExpTableRow("EXP_0009",9,810,2850));
      Rows.Add(new ExpTableRow("EXP_0010",10,1000,3850));
      Rows.Add(new ExpTableRow("EXP_0011",11,1210,5060));
      Rows.Add(new ExpTableRow("EXP_0012",12,1440,6500));
      Rows.Add(new ExpTableRow("EXP_0013",13,1690,8190));
      Rows.Add(new ExpTableRow("EXP_0014",14,1960,10150));
      Rows.Add(new ExpTableRow("EXP_0015",15,2250,12400));
      Rows.Add(new ExpTableRow("EXP_0016",16,2560,14960));
      Rows.Add(new ExpTableRow("EXP_0017",17,2890,17850));
      Rows.Add(new ExpTableRow("EXP_0018",18,3240,21090));
      Rows.Add(new ExpTableRow("EXP_0019",19,3610,24700));
      Rows.Add(new ExpTableRow("EXP_0020",20,4000,28700));
      Rows.Add(new ExpTableRow("EXP_0021",21,4410,33110));
      Rows.Add(new ExpTableRow("EXP_0022",22,4840,37950));
      Rows.Add(new ExpTableRow("EXP_0023",23,5290,43240));
      Rows.Add(new ExpTableRow("EXP_0024",24,5760,49000));
      Rows.Add(new ExpTableRow("EXP_0025",25,6250,55250));
      Rows.Add(new ExpTableRow("EXP_0026",26,6760,62010));
      Rows.Add(new ExpTableRow("EXP_0027",27,7290,69300));
      Rows.Add(new ExpTableRow("EXP_0028",28,7840,77140));
      Rows.Add(new ExpTableRow("EXP_0029",29,8410,85550));
      Rows.Add(new ExpTableRow("EXP_0030",30,9000,94550));
      Rows.Add(new ExpTableRow("EXP_0031",31,9610,104160));
      Rows.Add(new ExpTableRow("EXP_0032",32,10240,114400));
      Rows.Add(new ExpTableRow("EXP_0033",33,10890,125290));
      Rows.Add(new ExpTableRow("EXP_0034",34,11560,136850));
      Rows.Add(new ExpTableRow("EXP_0035",35,12250,149100));
      Rows.Add(new ExpTableRow("EXP_0036",36,12960,162060));
      Rows.Add(new ExpTableRow("EXP_0037",37,13690,175750));
      Rows.Add(new ExpTableRow("EXP_0038",38,14440,190190));
      Rows.Add(new ExpTableRow("EXP_0039",39,15210,205400));
      Rows.Add(new ExpTableRow("EXP_0040",40,16000,221400));
      Rows.Add(new ExpTableRow("EXP_0041",41,16810,238210));
      Rows.Add(new ExpTableRow("EXP_0042",42,17640,255850));
      Rows.Add(new ExpTableRow("EXP_0043",43,18490,274340));
      Rows.Add(new ExpTableRow("EXP_0044",44,19360,293700));
      Rows.Add(new ExpTableRow("EXP_0045",45,20250,313950));
      Rows.Add(new ExpTableRow("EXP_0046",46,21160,335110));
      Rows.Add(new ExpTableRow("EXP_0047",47,22090,357200));
      Rows.Add(new ExpTableRow("EXP_0048",48,23040,380240));
      Rows.Add(new ExpTableRow("EXP_0049",49,24010,404250));
      Rows.Add(new ExpTableRow("EXP_0050",50,25000,429250));
      Rows.Add(new ExpTableRow("EXP_0051",51,26010,455260));
      Rows.Add(new ExpTableRow("EXP_0052",52,27040,482300));
      Rows.Add(new ExpTableRow("EXP_0053",53,28090,510390));
      Rows.Add(new ExpTableRow("EXP_0054",54,29160,539550));
      Rows.Add(new ExpTableRow("EXP_0055",55,30250,569800));
      Rows.Add(new ExpTableRow("EXP_0056",56,31360,601160));
      Rows.Add(new ExpTableRow("EXP_0057",57,32490,633650));
      Rows.Add(new ExpTableRow("EXP_0058",58,33640,667290));
      Rows.Add(new ExpTableRow("EXP_0059",59,34810,702100));
      Rows.Add(new ExpTableRow("EXP_0060",60,36000,738100));
      Rows.Add(new ExpTableRow("EXP_0061",61,37210,775310));
      Rows.Add(new ExpTableRow("EXP_0062",62,38440,813750));
      Rows.Add(new ExpTableRow("EXP_0063",63,39690,853440));
      Rows.Add(new ExpTableRow("EXP_0064",64,40960,894400));
      Rows.Add(new ExpTableRow("EXP_0065",65,42250,936650));
      Rows.Add(new ExpTableRow("EXP_0066",66,43560,980210));
      Rows.Add(new ExpTableRow("EXP_0067",67,44890,1025100));
      Rows.Add(new ExpTableRow("EXP_0068",68,46240,1071340));
      Rows.Add(new ExpTableRow("EXP_0069",69,47610,1118950));
      Rows.Add(new ExpTableRow("EXP_0070",70,49000,1167950));
      Rows.Add(new ExpTableRow("EXP_0071",71,50410,1218360));
      Rows.Add(new ExpTableRow("EXP_0072",72,51840,1270200));
      Rows.Add(new ExpTableRow("EXP_0073",73,53290,1323490));
      Rows.Add(new ExpTableRow("EXP_0074",74,54760,1378250));
      Rows.Add(new ExpTableRow("EXP_0075",75,56250,1434500));
      Rows.Add(new ExpTableRow("EXP_0076",76,57760,1492260));
      Rows.Add(new ExpTableRow("EXP_0077",77,59290,1551550));
      Rows.Add(new ExpTableRow("EXP_0078",78,60840,1612390));
      Rows.Add(new ExpTableRow("EXP_0079",79,62410,1674800));
      Rows.Add(new ExpTableRow("EXP_0080",80,64000,1738800));
      Rows.Add(new ExpTableRow("EXP_0081",81,65610,1804410));
      Rows.Add(new ExpTableRow("EXP_0082",82,67240,1871650));
      Rows.Add(new ExpTableRow("EXP_0083",83,68890,1940540));
      Rows.Add(new ExpTableRow("EXP_0084",84,70560,2011100));
      Rows.Add(new ExpTableRow("EXP_0085",85,72250,2083350));
      Rows.Add(new ExpTableRow("EXP_0086",86,73960,2157310));
      Rows.Add(new ExpTableRow("EXP_0087",87,75690,2233000));
      Rows.Add(new ExpTableRow("EXP_0088",88,77440,2310440));
      Rows.Add(new ExpTableRow("EXP_0089",89,79210,2389650));
      Rows.Add(new ExpTableRow("EXP_0090",90,81000,2470650));
      Rows.Add(new ExpTableRow("EXP_0091",91,82810,2553460));
      Rows.Add(new ExpTableRow("EXP_0092",92,84640,2638100));
      Rows.Add(new ExpTableRow("EXP_0093",93,86490,2724590));
      Rows.Add(new ExpTableRow("EXP_0094",94,88360,2812950));
      Rows.Add(new ExpTableRow("EXP_0095",95,90250,2903200));
      Rows.Add(new ExpTableRow("EXP_0096",96,92160,2995360));
      Rows.Add(new ExpTableRow("EXP_0097",97,94090,3089450));
      Rows.Add(new ExpTableRow("EXP_0098",98,96040,3185490));
      Rows.Add(new ExpTableRow("EXP_0099",99,98010,3283500));
      Rows.Add(new ExpTableRow("EXP_0100",100,100000,3383500));
    }

    private class NestedExpTable
    {
      static NestedExpTable(){}
      internal static readonly ExpTable instance = new ExpTable();
    }

    public static ExpTable instance
    {
      get { return NestedExpTable.instance;}
    }

    public List<ExpTableRow> Rows = new List<ExpTableRow>();

  } // class ExpTable
} // namespace AntTool

