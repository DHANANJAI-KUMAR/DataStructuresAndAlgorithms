using Ds.Common.Lib;
namespace ArrayCodingTests
{
    [TestClass]
    public sealed class ZigZagSequence
    {
        [TestMethod]
        public void ZigZagSequenceTest()
        {
            int[] input = { 2, 3, 5, 1, 4 };
            //int[] input = { 1, 2, 3, 4, 5, 6, 7 };
            int[] result1 = ZigZagSequenceMethod(input);

        }


        private int[] ZigZagSequenceMethod(int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length;
            int mid = (n - 1) / 2;
            // Swap the middle element with the last element
            ArrayUtil.Exchange(arr, mid, n - 1);
            // Reverse the second half of the array
            Array.Reverse(arr, mid, n - mid - 1);
            return arr;   //1,2,5,3,4
        }

    }
}
