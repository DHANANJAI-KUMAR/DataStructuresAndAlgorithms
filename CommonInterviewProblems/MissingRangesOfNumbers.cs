using DataStructures.BaseClass;
using System.Collections.Generic;

namespace CommonInterviewProblems
{
    [TestClass]
    public class MissingRangesOfNumbers
    {
        //https://www.geeksforgeeks.org/missing-ranges-of-numbers/

        [TestMethod]
        public void MissingRangesOfNumbersTest()
        {
            //Input: arr[] = [14, 15, 20, 30, 31, 45], lower = 10, upper = 50
            //Output: [[10, 13], [16, 19], [21, 29], [32, 44], [46, 50]]
            int lower = 10;
            int upper = 50;
            int[] arr = { 14, 15, 20, 30, 31, 45 };
            List<List<int>> res = MissingRanges(arr, lower, upper);

            foreach (var range in res)
            {
                Console.WriteLine($"{range[0]} {range[1]}");
            }

        }

        private List<List<int>> MissingRanges(int[] arr, int lower, int upper)
        {
            List<List<int>> mainList = new List<List<int>>();
            int[] freq = new int[Math.Abs(upper - lower)];
            for (int i = lower; i <= upper; i++)
            {
                if (!arr.Contains(i))
                {
                    //freq
                }
                //List<int> subList = new List<int>();
                
                
                //for (int j = 0; j < arr.Length; j++)
                //{
                //    if (i == arr[j])
                //    {
                //        break;
                //    }
                //}
                
            }
            return mainList;


        }
    }

}