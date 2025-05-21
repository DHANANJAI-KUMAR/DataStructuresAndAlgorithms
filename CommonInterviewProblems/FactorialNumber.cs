namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class FactorialNumber
    {
        [TestMethod]
        public void FactorialNumberTest()
        {
            int n = 5;
            Console.WriteLine($"{n}! = {Factorial(n)}");
        }

        private long Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n* Factorial(n - 1);
        }

    }
}
