using Ds.Common.Lib;

namespace DataStructureTests
{
    [TestClass]
    public sealed class SortOperationsTest
    {
        int[] data = new int[10];

        [TestMethod]
        public void IntArrayBubbleSortTest()
        {
            SortOperations.IntArrayGenerate(data, 2);
            SortOperations.IntArrayBubbleSort(data);
        }

        [TestMethod]
        public void IntArraySelectionSortTest()
        {
            SortOperations.IntArrayGenerate(data, 2);
            SortOperations.IntArraySelectionSort(data);
        }

        [TestMethod]
        public void IntArrayInsertionSortTest()
        {
            SortOperations.IntArrayGenerate(data, 2);
            SortOperations.IntArrayInsertionSort(data);
        }

        [TestMethod]
        public void IntArrayShellSortNaiveTest()
        {
            SortOperations.IntArrayGenerate(data, 2);
            SortOperations.IntArrayShellSortNaive(data);
        }

        [TestMethod]
        public void IntArrayShellSortBetterTest()
        {
            SortOperations.IntArrayGenerate(data, 2);
            SortOperations.IntArrayShellSortBetter(data);
        }

        [TestMethod]
        public void IntArrayQuickSortTest()
        {
            SortOperations.IntArrayGenerate(data, 2);
            SortOperations.IntArrayQuickSort(data, 0, data.Length - 1);
        }


    }

    //http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html#shell-sort
    public class SortOperations
    {
        public static void IntArrayBubbleSort(int[] data)
        {
            //Bubble Sort is rather unimpressive as expected. In fact, this algorithm is never used in practice but is of historical interest.
            //Like the brute-force style of searching, it does way too much work to come up with the right answer!
            
            //Loop 0 to 9
            for (int i = 0; i < data.Length - 1; i++)
            {
                //Loop 0 to 9
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                        ArrayUtil.Swap(data, j, j + 1);

                    Console.WriteLine("exchange:" + string.Join(",", data));
                }
                Console.WriteLine("outer loop starter:" + string.Join(",", data));
            }
        }

        public static void IntArraySelectionSort(int[] data)
        {
            //Selection Sort and Insertion Sort are also rather unimpressive on their own. Even though Selection Sort can in
            //theory do a lot less data movement, it must make a large number of comparisons to find the minimum value to be
            //moved. Again it is way too much work. Insertion Sort, while unimpressive, fares a bit better and turns out to be
            //a nice building block (if modified) for the Shell Sort. Varying the interval size drastically reduces the amount
            //of data movement (and the distance it has to move).
            for (int i = 0; i < data.Length - 1; i++)
            {
                int min = IntArrayMin(data, i);
                if (i != min)
                    ArrayUtil.Swap(data, i, min);
                Console.WriteLine("exchange:" + string.Join(",", data));
            }
        }
        private static int IntArrayMin(int[] data, int i)
        {
            int minPos = i;
            for (int j = i + 1; j < data.Length; j++)
                if (data[j] < data[minPos])
                    minPos = j;
            return minPos;
        }

        public static void IntArrayInsertionSort(int[] data)
        {
            for (int j = 1; j < data.Length; j++)
            {
                for (int i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    ArrayUtil.Swap(data, i, i - 1);
                    Console.WriteLine("exchange:" + string.Join(",", data));
                }
            }
        }

        public static void IntArrayShellSortNaive(int[] data)
        {
            int[] intervals = { 1, 2, 4, 8 };
            IntArrayShellSort(data, intervals);
        }

        public static void IntArrayShellSort(int[] data, int[] intervals)
        {
            //Shell Sort does rather well, especially when we pick the right intervals.
            //In practice, the intervals also need to be adjusted based on the size of the array,
            //which is what we do as larger array sizes are considered. This is no trivial
            //task but a great deal of work has already been done in the past to determine
            //functions that generate good intervals.

            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            ArrayUtil.Swap(data, i, i - interval);
                        }
                    }
                }
            }
        }

        public static void IntArrayShellSortBetter(int[] data)
        {
            int[] intervals = GenerateIntervals(data.Length);
            IntArrayShellSort(data, intervals);
        }

        static int[] GenerateIntervals(int n)
        {
            if (n < 2)
            {  // no sorting will be needed
                return new int[0];
            }
            int t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            int[] intervals = new int[t];
            intervals[0] = 1;
            for (int i = 1; i < t; i++)
                intervals[i] = 3 * intervals[i - 1] + 1;
            return intervals;
        }

        public static void IntArrayGenerate(int[] data, int randomSeed)
        {
            Array.Copy(new int[] { 2, 10, 5, 3, 7, 4, 9, 0, 6, 1 }, data, data.Length);
            Console.Clear();
            Console.WriteLine("Original Array:" + string.Join(",", data));

            //int[] series = { 2, 10, 5, 3, 7, 4, 9, 0, 6, 1 };
            //Random r = new Random(randomSeed);
            //for (int i = 0; i < data.Length; i++)
            //    data[i] = r.Next(data.Length * 2);
        }

        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            //The Quicksort is generally fastest. It is by far the most commonly used sorting algorithm. Yet there are signs that Shell sort
            //is making a comeback in embedded systems, because it concise to code and is still quite fast.See[WikipediaShellSort],
            //where it is mentioned that the[uClibc] library makes use of Shell sort in its qsort() implementation, rather than implementing
            //the library sort with the more common quicksort.
                
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    ArrayUtil.Swap(data, i, j);
                    i++;
                    j--;
                }
                Console.WriteLine("Array:" + string.Join(",", data));
                if (i > j)
                    break;
            }
            
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }
   
    }
}
