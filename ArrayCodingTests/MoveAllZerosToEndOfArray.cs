using Ds.Common.Lib;
using System;

namespace ArrayCodingTests
{
    [TestClass]
    public class MoveAllZerosToEndOfArray
    {
        [TestMethod]
        public void MoveAllZerosToEndOfArrayTest()
        {
            int[] arr = { 0, 1, 2, 0, 4, 3, 0, 5, 0, 6 };
            //int[] arr = { 0, 0 };

            pushZerosToEndBetter(arr);

            // Print the modified array
            foreach (int num in arr)
                Console.Write(num + " ");
        }


        private void pushZerosToEnd(int[] arr)
        {
            Console.Write("LOOP START");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    int j = i;
                    while (j < arr.Length - 1 && arr[j] == 0)
                    {
                        //if (arr[j] != 0) 
                        ArrayUtil.Swap<int>(arr, j, j + 1);
                        j++;
                    }
                }

                Console.Write("LOOP DONE ");

            }
        }


        private void pushZerosToEndBetter(int[] arr)
        {
            //Reverse approch
            //The idea is similar to the previous approach where we took a pointer, say count to track where the
            //next non-zero element should be placed. However, on encountering a non-zero element,
            //instead of directly placing the non-zero element at arr[count], we will swap the non-zero
            //element with arr[count]. This will ensure that if there is any zero present at arr[count],
            //it is pushed towards the end of array and is not overwritten.

            Console.Write("LOOP START");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // If the current element is non-zero
                if (arr[i] != 0)
                {
                    // Swap the current element with the 0 at index 'count'
                    ArrayUtil.Swap<int>(arr, i, count);

                    // Move 'count' pointer to the next position
                    count++;
                }

                Console.Write("LOOP DONE ");
            }

        }

    }
}