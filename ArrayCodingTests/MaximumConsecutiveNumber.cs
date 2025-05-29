namespace ArrayCodingTests
{
    [TestClass]
    public class MaximumConsecutiveNumber
    {
        [TestMethod]
        public void MaximumConsecutiveNumberTest()
        {
            var arr = new List<int> { 0, 1, 1, 0, 0,0,0,0,0,0, 1, 0, 1, 0, 1,1,1,1,1, 1, 1, 1 };
            var maxCount = MaxConsecutiveCount(arr);
            Console.WriteLine(maxCount);
        }


        private int MaxConsecutiveCount(List<int> arr)
        {
            int maxCount = 0, count = 1;

            for (int i = 1; i < arr.Count; i++)
            { 
                var current = arr[i];
                var previous = arr[i-1];
                if (current == previous)
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                }
                else 
                {
                    count = 1;
                    //arr[i -1] = current;
                }
            }
            return maxCount;
        }

    }

}