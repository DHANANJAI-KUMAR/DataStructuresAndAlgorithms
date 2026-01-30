
namespace ArrayCodingTests
{
    [TestClass]
    public sealed class InsertAdjacentDuplicateForAllOccurrences
    {
        [TestMethod]
        public void InsertAdjacentDuplicateForAllOccurrencesTest()
        {
            //Insert an adjacent duplicate for all occurrences of a given element
            /*If you want to rewrite the adjacent duplicate insertion code without using List<>, you'll need to use arrays. Since arrays have fixed sizes in C#, you'll either:
                Pre-calculate the new array size, or
                Use temporary arrays and resize manually.
            */
            int[] arr = { 1, 6, 2, 3, 6, 4, 5, 6 };
            int k = 6;
            //op => 1 6 6 2 3 6 6 4 
            int[] ans = DuplicateK(arr, k);

            foreach (int i in ans)
            {
                Console.Write(i + " ");
            }

        }

        private int[] DuplicateK(int[] arr, int k)
        {
            //Pre-calculate the new array size, or
            var duplicateItems = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                    duplicateItems++;
            }

            int[] temp = new int[arr.Length + duplicateItems];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp[j++] = arr[i]; 
                if (arr[i] == k)
                {
                    temp[j++] = arr[i];
                }
            }
            Array.Resize(ref temp, arr.Length);
            return temp;
        }

        [TestMethod]
        public void InsertAdjacentDuplicateForAllOccurrencesUsingListTest()
        {
            //Insert an adjacent duplicate for all occurrences of a given element using List
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4 };
            int target = 2;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == target)
                {
                    numbers.Insert(i + 1, target); // Insert duplicate
                    i++; // Skip the inserted duplicate to avoid infinite loop
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
        
    }
}
