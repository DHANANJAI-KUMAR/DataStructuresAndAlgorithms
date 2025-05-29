namespace ArrayCodingTests
{
    [TestClass]
    public class NthLargestElement
    {
        [TestMethod]
        public void NthLargestElementTest()
        {
            int[] arr = { 12, 35, 1, 10, 34, 1 };
            Console.WriteLine(getSecondLargest(arr));

        }

        public static int getSecondLargest(int[] arr)
        {
            int n = arr.Length;

            // Sort the array in non-decreasing order
            Array.Sort(arr);

            // start from second last element as last element is the largest
            for (int i = n - 2; i >= 0; i--)
            {
                // return the first element which is not equal to the 
                // largest element
                if (arr[i] != arr[n - 1])
                {
                    return arr[i];
                }
            }

            // If no second largest element was found, return -1
            return -1;
        }


    }
}
