namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class UniqueElementArray
    {
        [TestMethod]
        public void UniqueElementArrayTest()
        {
            int[] nums = { 1, 2, 3, 2, 4, 3, 5 };
            int[] unique = new HashSet<int>(nums).ToArray();
            Console.WriteLine(string.Join(" ", unique));
        }
    }
}
