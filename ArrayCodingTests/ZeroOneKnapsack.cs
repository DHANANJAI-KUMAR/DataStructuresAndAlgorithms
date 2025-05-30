namespace ArrayCodingTests
{
    [TestClass]
    public sealed class ZeroOneKnapsack
    {
        [TestMethod]
        public void KnapsackTest()
        {
            /*Explanation
                Create a dictionary to store each number and its index.
                For each element:
                Calculate its complement (target - nums[i])
                Check if the complement already exists in the dictionary.
                If yes, you've found the pair → return their indices.
            */
            //Brute force decision tree
            int target = 15;
            int[] nums = { 2, 7, 11, 8, 3, 15 };
            var result = TwoSum(nums, target);
            
            result = TwoSumWithTwoPointers(nums, target);
            
            Console.WriteLine(string.Join(" ", result));

        }

        private static int[] TwoSum(int[] nums, int target)
        {
            var cache = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (cache.ContainsKey(complement))
                {
                    return new int[] { cache[complement], i };
                }

                cache.Add(nums[i], i);
            }
            return new int[0];

        }

        private static int[] TwoSumWithTwoPointers(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i +1 ; j < nums.Length; j++)
                {
                    Console.WriteLine($"{{nums[i]}}  {{nums[j]}}");
                    
                    if (target == nums[i] + nums[j])
                    { 
                        return new int[]{ i, j };
                    }
                }
            }

            return new int[0];

        }


    }
}
