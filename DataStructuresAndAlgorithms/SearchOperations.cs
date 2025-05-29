using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Algorithms
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
            int[] data = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 115, 125, 135, 145, 155, 178, 198 };

            //IntArrayShellSortBetter(data);
            
            var searchItem = 155;
            int foundPos = IntArrayBinarySearch(data, searchItem);
            if (foundPos < 0)
                Console.WriteLine("Item {0} not found", searchItem);
            else
                Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
            
        }

        public static int IntArrayBinarySearch(int[] arr, int target)
        {
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // Found the target, return index

                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Not found
        }

        public static int IntArrayLinearSearch(int[] data, int item, int start = 0)
        {
            int N = data.Length;
            if (start < 0)
                return -1;
            for (int i = start; i < N; i++)
                if (data[i] == item)
                    return i;
            return -1;
        }
        
    }
}
