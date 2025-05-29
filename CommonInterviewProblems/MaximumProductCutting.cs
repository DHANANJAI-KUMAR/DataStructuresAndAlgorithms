namespace CommonInterviewProblems
{
    [TestClass]
    public class MaximumProductCutting
    {
        //https://www.geeksforgeeks.org/maximum-product-cutting-dp-36/

        [TestMethod]
        public void MaximumProductCuttingTest()
        {
            //Given a rope of length n meters, cut the rope in different parts of integer lengths in a way that maximizes product of
            //lengths of all parts. You must make at least one cut. Assume that the length of rope is more than 2 meters. 
            //MaximumProductCutting
            Console.WriteLine("Maximum Product is " + maxProd1(13));
        }

        int maxProd1(int n)
        {
            int[] val = new int[n + 1];
            val[0] = val[1] = 0;

            // Build the table val[] in bottom up manner and return
            // the last entry from the table
            for (int i = 1; i <= n; i++)
            {
                int max_val = 0;
                for (int j = 1; j <= i; j++) {
                    var m = Math.Max((i - j) * j, j * val[i - j]);
                    max_val = Math.Max(max_val, m);
                }
                val[i] = max_val;
            }
            return val[n];
        }

    }

}