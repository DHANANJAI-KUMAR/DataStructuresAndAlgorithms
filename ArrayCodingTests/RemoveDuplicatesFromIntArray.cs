namespace ArrayCodingTests
{
    [TestClass]
    public sealed class RemoveDuplicatesFromIntArray
    {
        [TestMethod]
        public void RemoveDuplicatesFromIntArrayTest()
        {
            int[] nums = { 1, 2, 3, 2, 4, 3, 5 };
            int length = RemoveDuplicates(nums);

        }

        private int RemoveDuplicates(int[] arr)
        {
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < index; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    arr[index++] = arr[i];
                }
            }

            return index; // New length of unique elements
        }
    
    
    }
}
