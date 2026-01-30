using Ds.Common.Lib;
using System.Text;
namespace ArrayCodingTests
{
    [TestClass]
    public sealed class KthPermutation
    {
        [TestMethod]
        public void KthPermutationTest1()
        {
            //Here's a C# implementation to find the k-th permutation of the numbers 1 to n in lexicographic order.
            int n = 4;
            int k = 9;

            //For n = 4 and k = 9, the permutations in lexicographic order are:
            string result = GetPermutation(n, k);
            Console.WriteLine($"The {k}th permutation of 1 to {n} is: {result}");

        }

        public void AllPermutationOptionsTest()
        {
            //All Permutation options
            string input = "ABCD";
            Permute(input.ToCharArray(), 0, input.Length-1);

        }

        static void Permute(char[] chars, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(new string(chars));
                return;
            }

            for (int i = left; i <= right; i++)
            {
                ArrayUtil.Swap(chars, left, i);                       // Make a choice
                Permute(chars, left + 1, right);                        // Explore
                ArrayUtil.Swap(chars, left, i);                       // Undo (backtrack)
            }
        }

        

        private string GetPermutation(int n, int k)
        {
            var nums = new List<int>();
            for (int i = 1; i <= n; i++) 
                nums.Add(i);

            var factorial = new int[n];
            factorial[0] = 1;
            for (int i = 1; i < n; i++)
                factorial[i] = factorial[i - 1] * i;

            k--;  // Convert to 0-based index
            var sb = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                int idx = k / factorial[i - 1];
                sb.Append(nums[idx]);
                nums.RemoveAt(idx);
                k %= factorial[i - 1];
            }

            return sb.ToString();
        }

    }
}
