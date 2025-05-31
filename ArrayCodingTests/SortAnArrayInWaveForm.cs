
using Ds.Common.Lib;

namespace ArrayCodingTests
{
    [TestClass]
    public sealed class SortAnArrayInWaveForm
    {
        [TestMethod]
        public void SortAnArrayInWaveFormTest()
        {
            //int[] arr = { 10, 90, 49, 2, 1, 5, 23 };
            int[] arr = { 10, 5, 6, 3, 2, 20, 100, 80 };
            //2 1 10 5 49 23 90 
            BubbleSort(arr);

            SortInWave(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

        }

        private void SortInWave(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i +=2)
            {
                ArrayUtil.Swap(arr, i, i+1);

            }

        }

        private void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        ArrayUtil.Swap(arr, i, j);
                    }

                }
            }

        }

    }
}
