using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    //http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html#shell-sort
    public class SortOperations
    {
        public SortOperations()
        {
            int[] data = new int[10];
            IntArrayGenerate(data, 2);
            IntArrayBubbleSort(data);

            IntArrayGenerate(data, 2);
            IntArraySelectionSort(data);

            IntArrayGenerate(data, 2);
            IntArrayInsertionSort(data);

            IntArrayGenerate(data, 2);
            IntArrayShellSortNaive(data);

            IntArrayGenerate(data, 2);
            IntArrayShellSortBetter(data);

            IntArrayGenerate(data, 2);
            IntArrayQuickSort(data, 0, data.Length - 1);

        }

        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                    Console.WriteLine("exchange:" + string.Join(",", data));
                }
            }
        }

        public static void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;
            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    exchange(data, i, k);
                Console.WriteLine("exchange:" + string.Join(",", data));
            }
        }

        public static void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
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
                            exchange(data, i, i - interval);
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


        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
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
                    exchange(data, i, j);
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


        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }



    }
}
