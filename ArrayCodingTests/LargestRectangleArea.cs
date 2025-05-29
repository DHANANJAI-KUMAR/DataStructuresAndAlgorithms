namespace ArrayCodingTests
{
    [TestClass]
    public sealed class LargestRectangleArea
    {
        [TestMethod]
        public void LargestRectangleAreaTest()
        {

            int[] heights = { 2, 1, 5, 6, 2, 3 };
            int maxArea = LargestRectangleAreaMethod(heights);
            Console.WriteLine(maxArea); // Output: 10
        }

        private int LargestRectangleAreaMethod(int[] heights)
        {
            int n = heights.Length;
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;

            Console.WriteLine("Input Heights: [" + string.Join(", ", heights) + "]\n");

            for (int i = 0; i <= n; i++)
            {
                int currentHeight = (i == n) ? 0 : heights[i];
                Console.WriteLine($"---\nProcessing index {i} (height: {currentHeight})");

                while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
                {
                    int poppedIndex = stack.Pop();
                    int height = heights[poppedIndex];
                    int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                    int area = height * width;
                    maxArea = Math.Max(maxArea, area);

                    Console.WriteLine($"📤 Popped index {poppedIndex} (height: {height})");
                    Console.WriteLine($"   Width: {width}, Area: {area}, MaxArea: {maxArea}");
                }

                stack.Push(i);
                Console.WriteLine($"📥 Pushed index {i}");
                Console.WriteLine("   Current Stack: [" + string.Join(", ", stack) + "]");
            }

            return maxArea;
        }



    }
}
