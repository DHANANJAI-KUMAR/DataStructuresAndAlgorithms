

namespace ArrayCodingTests
{
    [TestClass]
    public sealed class MissingAndRepeating
    {
        //https://www.geeksforgeeks.org/find-a-repeating-and-a-missing-number/
        [TestMethod]
        public void MissingAndRepeatingTest()
        {
            /*
             * You are given an array of size n containing numbers from 1 to n. One number is missing, and one number is repeating. Find both.
             * input: arr[] = {3, 1, 3}
                Output: 3, 2
                Explanation: In the array, 2 is missing and 3 occurs twice.

                Input: arr[] = {4, 3, 6, 2, 1, 1}
                Output: 1, 5
                Explanation: 5 is missing and 1 is repeating.
            */

            int[] arr = { 3, 1, 3 };
            //int[] arr = { 4, 3, 6, 2, 1, 1 };
            List<int> ans = findTwoElement(arr);

            Console.WriteLine(ans[0] + " " + ans[1]);


        }

        private List<int> findTwoElement(int[] arr)
        {
            var freq = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                int no = arr[i];
                freq[no] = freq[no] + 1;
            }

            List<int> ans = new List<int>();
            for (int i = 1; i < freq.Length; i++)
            {
                if (freq[i] == 0)
                {
                    //missing number
                    ans.Add(i);
                }
                else if (freq[i] > 1)
                {
                    //repeating number
                    ans.Add(i);
                }
            }

            return ans;
        }
    }
}
