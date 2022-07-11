using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class SearchOperations
    {
        //http://anh.cs.luc.edu/170/notes/CSharpHtml/searching.html
        public SearchOperations()
        {
            //LinearSearch();
            BinarySearch();
        }

        public static void LinearSearch()
        {
            //http://anh.cs.luc.edu/170/notes/CSharpHtml/searching.html
            Console.WriteLine("Please enter some integers, separated by spaces:");
            string input = "10   20   30   40   50   60   70   80   90   100  115  125  135  145  155  178  198";
            string[] integers = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < integers.Length; i++)
                Console.WriteLine("i={0} integers[i]={1}", i, integers[i]);
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(integers[i]);

            for (int i = 0; i < data.Length; i++)
                Console.WriteLine("i={0} data[i]={1}", i, data[i]);

            while (true)
            {
                Console.WriteLine("Please enter a number you want to find (blank line to end):");
                input = Console.ReadLine();
                if (input.Length == 0)
                    break;
                int searchItem = int.Parse(input);
                Console.WriteLine("Please enter a position to start searching from (0 for beginning): ");
                input = Console.ReadLine();
                int searchPos = int.Parse(input);
                int foundPos = IntArrayLinearSearch(data, searchItem, searchPos);
                if (foundPos < 0)
                    Console.WriteLine("Item {0} not found", searchItem);
                else
                    Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
            }
        }

        public static void BinarySearch()
        {
            //http://anh.cs.luc.edu/170/notes/CSharpHtml/binarysearching.html
            Console.WriteLine("Please enter some integers, separated by spaces:");
            string input = "10   20   30   40   50   60   70   80   90   100  115  125  135  145  155  178  198";
            string[] integers = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(integers[i]);

            //IntArrayShellSortBetter(data);
            while (true)
            {
                Console.WriteLine("Please enter a number you want to find (blank line to end):");
                input = Console.ReadLine();
                if (input.Length == 0)
                    break;
                int searchItem = int.Parse(input);
                int foundPos = IntArrayBinarySearch(data, searchItem);
                if (foundPos < 0)
                    Console.WriteLine("Item {0} not found", searchItem);
                else
                    Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
            }
        }

        public static int IntArrayBinarySearch(int[] data, int item)
        {
            int min = 0;
            int max = data.Length - 1;
            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;

                if (data[mid] == item)
                    return mid;
                //if (min > max)
                //   break;
            } while (min <= max);
            return -1;
        }

        public static int IntArrayLinearSearch(int[] data, int item, int start)
        {
            int N = data.Length;
            if (start < 0)
                return -1;
            for (int i = start; i < N; i++)
                if (data[i] == item)
                    return i;
            return -1;
        }

        public static int IntArrayLinearSearch(int[] data, int item)
        {
            int N = data.Length;
            for (int i = 0; i < N; i++)
                if (data[i] == item)
                    return i;
            return -1;
        }
    }
}
