namespace ArrayCodingTests
{
    [TestClass]
    public sealed class RemoveDuplicatesFromIntArray
    {
        //I need to work again, on this
        [TestMethod]
        public void RemoveDuplicatesFromIntArrayTest1()
        {
            int[] nums = { 1, 2, 3, 2, 4, 3, 5 };
            int[] unique = new HashSet<int>(nums).ToArray();
            Console.WriteLine(string.Join(" ", unique));
        }


        [TestMethod]
        public void RemoveDuplicatesFromIntArrayTest2()
        {
            int[] nums = { 7, 1, 2, 3, 2, 4, 3, 5, 7 };
            int[] uniqueArray = RemoveDuplicatesWithForLoop(nums);
            int[] uniqueArray1 = RemoveDuplicatesWithLinq(nums);

        }

        [TestMethod]
        public void RemoveDuplicatesFromIntArrayTest3()
        {
            //make sure, Array is shorted
            int[] arr = { 1, 2, 6, 2, 3, 4, 4, 4, 5, 5, 6 };
            Array.Sort(arr);
            int newSize = removeDuplicates(arr);

            for (int i = 0; i < newSize; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

        private int[] RemoveDuplicatesWithLinq(int[] arr)
        {
            int[] unique = arr.Distinct().ToArray();  // New length of unique elements
            return unique;
        }

        private int[] RemoveDuplicatesWithForLoop(int[] numbers)
        {
            List<int> result = new List<int>(); 
            for (int i = 0; i < numbers.Length; i++) 
            { 
                bool exists = false; 
                for (int j = 0; j < result.Count; j++) 
                { 
                    if (result[j] == numbers[i]) 
                    { 
                        exists = true; 
                        break; 
                    } 
                } 
                if (!exists) 
                    result.Add(numbers[i]); 
            }
            return result.ToArray();
        }

        private int removeDuplicates(int[] arr)
        {
            int n = arr.Length;
            if (n <= 1)
                return n;

            // Start from the second element
            int idx = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[idx++] = arr[i];
                }
            }
            return idx;
        }

        

    }
}
