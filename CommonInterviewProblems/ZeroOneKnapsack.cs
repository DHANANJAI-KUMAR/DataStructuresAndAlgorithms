namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ZeroOneKnapsack
    {
        [TestMethod]
        public void KnapsackTest()
        {
            //Brute force decision tree
            int target = 22;
            int[] nums = { 2, 7, 11, 15 };
            var result = TwoSum(nums, target);

            Console.WriteLine(string.Join(" ", result));

        }

        static int[] TwoSum(int[] nums, int target)
        {
            var complementMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (complementMap.ContainsKey(complement))
                {
                    return new int[] { complementMap[complement], i };
                }

                complementMap.Add(nums[i], i);
            }
            return new int[0];

        }


    }
}
