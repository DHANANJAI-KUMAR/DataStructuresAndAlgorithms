

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayCodingTests
{
    [TestClass]
    public sealed class Demo
    {
        [TestMethod]
        public void DemoTest()
        {
            int taget = 18; 
            int[] arr = { 16, 17, 4, 8, 5, 2 };
            arr = [1, 2, 3, 4, 5, 5];
            //arr = [4, 3, 2, 1];

            var aa = CanSplit(arr);

            var isExist = SumExisttInArray(arr, taget);
            //Input: [1, 2, 4]
            //Output: 125
            //Explanation: 124 + 1 = 125
            int n = 5674;
            int a = SingleDigit(n);
            Console.WriteLine(a);
            //https://www.geeksforgeeks.org/remove-element/
            //Remove All Occurrences of an Element in an Array

            //int[] arr = { 16, 17, 4, 3, 5, 2 };
            List<int> result = Leaders(arr);

            foreach (int res in result)
            {
                Console.Write(res + " ");
            }
            Console.WriteLine();

        }

        
        public bool CanSplit(int[] arr)
        {
            // code here

            var firstArrSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                firstArrSum = firstArrSum + arr[i];
                var secondArrSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    secondArrSum = secondArrSum + arr[j];
                }
                if (firstArrSum == secondArrSum) 
                    return true;
            }
            return false;
        }

        private bool SumExisttInArray(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return true; // Found a pair
                    }
                }
                
                //int j = i + 1;
                //while (j < nums.Length)
                //{
                //    if (nums[i] + nums[j] == target)
                //    {
                //        return true; 
                //    }
                //    j++;
                //}

            }

            return false;
        }

        private List<int> Leaders(int[] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {

                int j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[j] > arr[i])
                    {
                        break;
                    }
                    j++;
                }
                if (j == arr.Length) result.Add(arr[i]);
            }

            return result;
        }

        private int SingleDigit(int n)
        {
            int sum = 0;

            while (n > 0 || sum > 9)
            {
                if (n == 0) {
                    n = sum;
                    sum = 0;
                }
                sum = sum + n % 10;
                n = (n / 10);
            }
            
            return sum;
        }

        private int[] AddOne(int[] arr)
        {
            var returnArr = new List<int>();
            int carry = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            { 
                int add = arr[i] + carry;
                if (i == arr.Length-1) ++add;

                carry = add / 10;
                returnArr.Add(add % 10);
            }
            if(carry > 0) returnArr.Add(carry);

            returnArr.Reverse();
            return returnArr.ToArray();
        }
    }
}
