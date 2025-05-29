namespace CommonInterviewProblems
{
    [TestClass]
    public class MinimizeStepsExamples
    {
        [TestMethod]
        public void MinimizeStepsToReachKTest()
        {
            int K = 12;
            var minOp = minOperation(K);
            Console.Write(minOp);
        }

        // Function to find minimum operations
        private int minOperation(int k)
        {
            //Minimize steps to reach K from 0 by adding 1 or doubling at each step
            //This is a classic shortest path problem.The optimal approach is to work backwards from K to 0, minimizing operations in reverse.
            //Optimal Strategy (Reverse Greedy Algorithm)
            //Start from K and move backward to 0, using these rules:
            //If K is even → it must have come from K / 2 => take a doubling step in reverse.
            //If K is odd → it must have come from K -1 => take an add 1 step in reverse.
            //Each step counts as 1 operation.
            
            int steps = 0;
            while (k > 0)
            {
                if (k % 2 == 0)
                {
                    k = k/2;
                }
                else
                {
                    k = k - 1;
                }
                steps++;
            }
            return steps;
        }

    }

}