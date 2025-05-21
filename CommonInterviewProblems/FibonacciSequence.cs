namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class FibonacciSequence
    {
        [TestMethod]
        public void FibonacciSequenceTest()
        {
            //F(n)=F(n−1)+F(n−2)
            //Index(n):     0   1   2   3   4   5   6   7   8   9   10
            //Value:        0   1   1   2   3   5   8   13  21  34  55


            int n = 10;
            Console.WriteLine($"Fibonacci({n}) = {Fibonacci(n)}");
        }
         
        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else 
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
