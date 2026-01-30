namespace ArrayCodingTests
{
    [TestClass]
    public sealed class FirstAndLastPositionofTarget
    {
        [TestMethod]
        public void FirstAndLastPositionofTargetTest()
        {
            //given a sorted array of integers arr and an integer target, find the index of the first and last position of target in arr. retrun [-1, -1] if not found

            int[] arr = { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            int[] result = SearchRange(arr, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]"); // Output: [3, 4]
        }

        int[] SearchRange(int[] arr, int target)
        {
            int first = FindBound(arr, target, true);
            int last = FindBound(arr, target, false);
            return new int[] { first, last };
        }

        int FindBound(int[] arr, int target, bool findFirst)
        {
            int left = 0;
            int right = arr.Length-1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    if (findFirst)
                        right = mid - 1;  // Move left
                    else
                        left = mid + 1;   // Move right
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }


    }
}
