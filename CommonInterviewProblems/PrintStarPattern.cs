namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class PrintStarPattern
    {
        [TestMethod]
        public void PrintStarPatternTest()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars + spaces);
            }

        }
    }
}
