
using Ds.Common.Lib;

namespace ArrayCodingTests
{
    [TestClass]
    public sealed class RotateAnArrayByd
    {
        [TestMethod]
        public void RotateAnArrayToLeftBydTest()
        {
            //https://www.geeksforgeeks.org/array-rotation/
            //Input: arr[] = { 1, 2, 3, 4, 5, 6 }, d = 2
            //Output:        { 3, 4, 5, 6, 1, 2}

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int d = 2;

            RotateArr(arr, d);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        private void RotateArr(int[] arr, int d)
        {
            //Counter clockwise or Left
            int j = 0;
            while (j < d) {

                for (int i = 1; i < arr.Length; i++)
                {
                    ArrayUtil.Swap(arr, i-1, i);

                }
                j++;
            }
        }

    }
}
