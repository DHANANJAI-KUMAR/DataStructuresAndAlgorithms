using Newtonsoft.Json.Linq;
using System.Drawing;

namespace CommonInterviewProblems
{
    [TestClass]
    public class CountNumberOfWaysToCoverADistance
    {
        [TestMethod]
        public void CountNumberOfWaysToCoverADistanceTest()
        {
            //Count number of ways to cover a distance
            //https://www.geeksforgeeks.org/count-number-of-ways-to-cover-a-distance/
            //Given a distance 'dist', count total number of ways to cover the distance with 1, 2 and 3 steps. 
            int dist = 7;
            Console.WriteLine(PrintCountRec(dist));
            Console.WriteLine(PrintCountDP(dist));
        }

        private int PrintCountRec(int dist)
        {
            // Base cases
            if (dist < 0)
                return 0;
            if (dist == 0)
                return 1;

            // Recur for all previous 3 and add the results
            return PrintCountRec(dist - 1) + PrintCountRec(dist - 2) + PrintCountRec(dist - 3);
        }
        private int PrintCountDP(int dist)
        {
            //We start by initializing the base cases for covering distances 0, 1, and 2.For distance 0, there is only one way to cover
            //it(do nothing). For distance 1, there is also only one way to cover it(take a step of size 1).For distance 2, there are
            //two ways to cover it(take two steps of size 1 or take a step of size 2).

            //We use a bottom-up approach to fill in the count[] array.For each entry count[i], we compute the number of
            //ways to cover distance i by adding the number of ways to cover distances i - 1, i - 2, and i-3.

            //Finally, we return the value of count[dist], which represents the number of ways to cover the given distance.
            
            int[] count = new int[dist + 1];

            // Initialize base values. There is one way to cover 0 and 1 distances and two ways to cover 2 distance 
            count[0] = 1;
            count[1] = 1;
            count[2] = 2;

            // Fill the count array  in bottom up manner
            for (int i = 3; i <= dist; i++)
                count[i] = count[i - 1] + count[i - 2] + count[i - 3];

            return count[dist];
        }



    }

}