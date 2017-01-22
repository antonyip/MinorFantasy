using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameDatabaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: GameDatabaseConverter.exe <inputfile.csv> <outputfile.cs> <ClassName>");
                return;
            }

            StreamReader sr = new StreamReader(args[0]);

            // first line is headers;
            string headers = sr.ReadLine();
            var headerArray = headers.Split(';').ToList();

            // 2nd line is types
            string types = sr.ReadLine();
            var typeArray = types.Split(';').ToList();

            // the rest are data
            string dataString = "";
            List<string> dataStrings = new List<string>();
            do
            {
                dataString = sr.ReadLine();
                dataStrings.Add(dataString);
                // handle generation of data
            } while (!string.IsNullOrWhiteSpace(dataString));

            // write out file
            StreamWriter sw = new StreamWriter(args[1]);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Linq;");
            sw.WriteLine("");

            // generate of Class Row
            sw.WriteLine("namespace AntTool");
            sw.WriteLine("{");
            sw.WriteLine("  public class " + args[2] + "Row");
            sw.WriteLine("  {");

            for (int i = 0; i < headerArray.Count; i++)
            {
                sw.WriteLine("    public "+ typeArray[i].ToLower() +" _" + headerArray[i].ToString() + ";");
            }
            //sw.WriteLine("    string _" + "end" + ";");

            sw.Write("    public " + args[2] + "Row(");

            string ConstructorVars = "";
            for (int i = 0; i < headerArray.Count; i++)
            {
                ConstructorVars += (typeArray[i].ToLower() + " " + headerArray[i].ToString() + ",");
            }
            ConstructorVars = ConstructorVars.Substring(0, ConstructorVars.LastIndexOf(','));

            sw.Write(ConstructorVars);
            sw.WriteLine(")");
            sw.WriteLine("    {");

            for (int i = 0; i < headerArray.Count; i++)
            {
                sw.WriteLine("     _" + headerArray[i].ToString() + " = " + headerArray[i].ToString() + ";");
            }

            //sw.WriteLine("     _end = end;");

            sw.WriteLine("    }");
            sw.WriteLine("  } // class " + args[2] + "Row");
            sw.WriteLine("  public class " + args[2]);
            sw.WriteLine("  {");

            sw.WriteLine("    private " + args[2] + "()");
            sw.WriteLine("    {");

            // generate rows here into the nested class
            for (int i = 0; i < dataStrings.Count; i++)
            {
                // error checking
                if (string.IsNullOrWhiteSpace(dataStrings[i]))
                    continue;

                sw.Write("      Rows.Add(new " + args[2] + "Row(");
                List<string> PrintString = new List<string>();

                if (dataStrings[i].Contains(';'))
                {
                    PrintString = dataStrings[i].Split(';').ToList();
                }
                else
                {
                    PrintString.Add(dataStrings[i]);
                }

                ConstructorVars = "";

                for (int j = 0; j < PrintString.Count; j++)
                {
                    if (typeArray[j].ToLower().Equals("int"))
                    {
                        ConstructorVars += (PrintString[j]);
                        ConstructorVars += (",");
                    }
                    else
                    {
                        ConstructorVars += ("\"");
                        ConstructorVars += (PrintString[j]);
                        ConstructorVars += ("\"");
                        ConstructorVars += (",");
                    }
                }
                ConstructorVars = ConstructorVars.Substring(0, ConstructorVars.LastIndexOf(','));

                //sw.Write("\"end\"");
                sw.Write(ConstructorVars);
                sw.Write("));");
                sw.WriteLine("");
            }

            sw.WriteLine("    }");
            sw.WriteLine("");

            // private nested class
            sw.WriteLine("    private class Nested" + args[2]);
            sw.WriteLine("    {");
            sw.WriteLine("      static Nested" + args[2] + "(){}");
            sw.WriteLine("      internal static readonly " + args[2] + " instance = new " + args[2] + "();");
            sw.WriteLine("    }");
            sw.WriteLine("");

            // instance
            sw.WriteLine("    public static " + args[2] + " instance");
            sw.WriteLine("    {");
            sw.WriteLine("      get { return Nested" + args[2] + ".instance;}");
            sw.WriteLine("    }");
            sw.WriteLine("");
            // Rows
            sw.WriteLine("    public List<" + args[2] + "Row> Rows = new List<" + args[2] + "Row>();");
            sw.WriteLine("");

            sw.WriteLine("  } // class " + args[2]);
            sw.WriteLine("} // namespace AntTool");
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }
    }
}

