using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Common.Lib
{
    public class ConsoleUtil
    {
        public static void Print(string[] arr, string msg)
        {
            var lst = new List<string>(arr);
            Print(lst, msg);
        }

        public static void Print(List<string> arr, string msg)
        {
            foreach (var str in arr)
            {
                Console.WriteLine($"{msg}: {str}");
            }
        }
    }
}
