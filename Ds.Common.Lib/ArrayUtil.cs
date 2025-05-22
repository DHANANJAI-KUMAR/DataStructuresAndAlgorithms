using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Common.Lib
{
    public class ArrayUtil
    {
        public static void Exchange(int[] data, int m, int n)
        {
            int temp = data[m];
            data[m] = data[n];
            data[n] = temp;
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
