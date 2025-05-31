

namespace ArrayCodingTests
{
    [TestClass]
    public sealed class Demo
    {
        [TestMethod]
        public void DemoTest()
        {
            //Input: [1, 2, 4]
            //Output: 125
            //Explanation: 124 + 1 = 125
            int n = 5674;
            int a = SingleDigit(n);
            Console.WriteLine(a);
            //https://www.geeksforgeeks.org/remove-element/
            //Remove All Occurrences of an Element in an Array

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
                if (i == arr.Length - 1) ++add;

                carry = add / 10;
                returnArr.Add(add % 10);
            }
            if(carry > 0) returnArr.Add(carry);

            returnArr.Reverse();
            return returnArr.ToArray();
        }
    }
}
