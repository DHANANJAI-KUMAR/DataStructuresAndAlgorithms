
namespace ArrayCodingTests
{
    [TestClass]
    public sealed class ReverseAnArrayInGroups
    {
        [TestMethod]
        public void ReverseAnArrayInGroupsTest()
        {
            //https://www.geeksforgeeks.org/reverse-an-array-in-groups-of-given-size/
            int[] arr = new int[] {1, 2, 3,   4, 5, 6,  7, 8};
            //output - 3 2 1   6 5 4   8 7 

            int k = 3;
            
            reverse(arr, k);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private void reverse(int[] arr, int k)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
                if ( (i+1) % k == 0 || i == arr.Length-1) 
                {
                    while (stack.Count > 0)
                    {
                        int j = i + 1 - stack.Count;
                        arr[j] = stack.Pop();
                    }
                    stack.Clear();
                }
            
            }
        }
    }
}
