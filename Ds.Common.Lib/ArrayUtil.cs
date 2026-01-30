using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Common.Lib
{
    public static class ArrayUtil
    {
        public static void Swap<T>(T[] arr, int i, int j)
        {
            if (i == j) return;
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
    
}
