namespace CommonInterviewProblems
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
            exchange(arr, mid, n - 1);
            // Reverse the second half of the array
            Array.Reverse(arr, mid, n - mid - 1);
            return arr;   //1,2,5,3,4
        }


        void exchange(int[] data, int m, int n)
        {
            int temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }


    }
}
