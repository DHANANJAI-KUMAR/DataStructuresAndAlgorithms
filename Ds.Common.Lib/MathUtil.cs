using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Common.Lib
{
    public class MathUtil
    {
        public MathUtil()
        {
            int a = 17;
            int b = 5;

            int quotient = a / b;   // 17 / 5 = 3
            int remainder = a % b;  // 17 % 5 = 2

            //x %= 5; => x = x % 5;



        }

        public static void Exchange(int[] arr, int i, int j)
        {
            if (i == j) return; 
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Swap(char[] arr, int i, int j)
        {
            if (i == j) return;
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
    
}
