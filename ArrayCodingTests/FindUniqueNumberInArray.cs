namespace ArrayCodingTests
{
    [TestClass]
    public sealed class FindUniqueNumberInArray
    {
        [TestMethod]
        public void FindUniqueNumberInArrayTest()
        {
            int[] arr = { 1, 2, 5, 3, 8, 3, 2, 1, 5 };
            int result = 0;
            foreach (int num in arr)
            {
                result ^= num; // XOR each number
            }
            Console.WriteLine(result); // This is the unique number


        }
    }
}
