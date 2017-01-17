using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class UnityEngine
    {

    }

    public class MonoBehaviour
    {

    }

    public class Debug
    {
        public static void Log(object o)
        {
            Console.WriteLine("[LOG] " + o.ToString());
        }

        public static void LogError(object o)
        {
            Console.WriteLine("[ERROR] " + o.ToString());
        }

        public static void LogWarning(object o)
        {
            Console.WriteLine("[WARNING] " + o.ToString());
        }
    }
}
