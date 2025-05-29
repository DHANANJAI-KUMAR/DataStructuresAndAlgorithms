using Ds.Common.Lib;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public class LongestCommonPrefix
    {
        [TestMethod]
        public void LongestCommonPrefixTest()
        {
            //Output: "gee"
            string[] arr = {  "geeks", "geek", "geezer", "geeksforgeeks" };
            Console.WriteLine($"Original arr {JsonConvert.SerializeObject(arr)}");

            
            var str3 = LongestCommonPrefixUsingCharByCharMatching(arr);
            Console.WriteLine($"longestCommonPrefixUsingCharByCharMatching: {str3}");
            
            //var str = LongestCommonPrefixUsingSorting(arr);
            //Console.WriteLine($"LongestCommonPrefixUsingSorting: {str}");

            //var str1 = LongestCommonPrefixUsingBinarySearch(arr);
            //Console.WriteLine($"LongestCommonPrefixUsingBinarySearch: {str1}");

            var str2 = LongestCommonPrefixsingDivideAndConquer(arr, 0, arr.Length - 1);
            Console.WriteLine($"LongestCommonPrefixsingDivideAndConquer: {str2}");

            

        }

        // C# program to find the longest common prefix using Character by Character Matching
        private string LongestCommonPrefixUsingCharByCharMatching(string[] arr)
        {
            //Character-by-character matching works faster than word-by-word matching.
            //As we immediately stops the matching when a mismatch is found. It is efficient, especially when there’s a
            //short or no common prefix.
            //On the other hand, word-by-word matching goes through each word entirely, even if there’s no common prefix at all.

            // Find length of smallest string
            int minLen = arr[0].Length;
            foreach (string str in arr)
                minLen = Math.Min(minLen, str.Length);

            string res = "";
            for (int i = 0; i < minLen; i++)
            {
                // Current character (must be the same // in all strings to be a part of result)
                char ch = arr[0][i];

                foreach (string str in arr)
                {
                    if (str[i] != ch)
                    {
                        return res;
                    }
                }

                // Append to result
                res += ch;
            }
            return res;
        }

        // Divide and Conquer function to find the longest common prefix, This is similar to the merge sort technique
        private string LongestCommonPrefixsingDivideAndConquer(string[] arr, int l, int r)
        {

            // Base Case: common prefix for a set of single string is string itself
            if (l == r)
                return arr[l];

            if (l < r)
            {
                int mid = l + (r - l) / 2;

                // Find Longest Common Prefix of first part
                string p1 = LongestCommonPrefixsingDivideAndConquer(arr, l, mid);

                // Find Longest Common Prefix of second part
                string p2 = LongestCommonPrefixsingDivideAndConquer(arr, mid + 1, r);

                // Find and return the Longest Common Prefix of sub array arr[l ... r]
                return StringUtil.CommonPrefix1(p1, p2);
                //return StringUtil.CommonPrefixFromString2(p1, p2);

            }
            return "";
        }


        // A Function that returns the longest common prefix from the array of strings
        private string LongestCommonPrefixUsingBinarySearch(string[] arr)
        {
            int minLen = arr[0].Length;
            // Find length of shortest string
            foreach (string str in arr)
            {
                minLen = Math.Min(minLen, str.Length);
            }

            // We will do an in-place binary search on the indices to find the length of longest common prefix
            int lo = 0, hi = minLen - 1;
            int prefixLen = 0;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (allContainSubstring(arr, lo, mid))
                {
                    // If all the strings in the input array contain common prefix till mid index
                    // then update prefixLen with mid + 1 
                    prefixLen = mid + 1;

                    // And then check in the right part
                    lo = mid + 1;
                }
                else
                {   // Otherwise check in the left part
                    hi = mid - 1;
                }
            }

            // Return the common prefix by taking substring from the first string 
            return arr[0].Substring(0, prefixLen);
        }

        // Function to check if the substring between the indexes [left ... right] was common among all strings or not
        private bool allContainSubstring(string[] arr, int left, int right)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = left; j <= right; j++)
                {
                    if (arr[i][j] != arr[0][j])
                        return false;
                }
            }
            return true;
        }

        private string LongestCommonPrefixUsingSorting(string[] arr)
        {
            /*The idea is to sort the array of strings and find the common prefix of the first and last string of the sorted array. 
            * Sorting is used in this approach because it makes it easier to find the longest common prefix. When we sort the strings, 
            * the first and last strings in the sorted list will be the most different from each other in terms of their characters. 
            * So, the longest common prefix for all the strings must be a prefix of both the first and the last strings in the sorted list.
            */
            
            Array.Sort(arr);
            Console.WriteLine($"After sorting arr {JsonConvert.SerializeObject(arr)}");

            // Get the first and last strings after sorting
            var first = arr[0];
            var last = arr[arr.Length - 1];

            //var sb = StringUtil.CommonPrefixFromString1(first, last);
            var sb = StringUtil.CommonPrefix1(first, last);

            return sb.ToString();

        }

        

    }

}