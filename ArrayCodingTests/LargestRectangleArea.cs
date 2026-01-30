namespace ArrayCodingTests
{
    [TestClass]
    public sealed class LargestRectangleArea
    {
        [TestMethod]
        public void LargestRectangleAreaTest()
        {

            //int[] heights = { 2, 1, 5, 6, 2, 3 };
            int[] heights = { 4, 4, 4, 4 };
            int maxArea = LargestRectangleAreaMethod(heights);
            maxArea = MyLargestRectangleAreaMethod(heights);
            Console.WriteLine(maxArea); // Output: 10
        }

        private int MyLargestRectangleAreaMethod(int[] heights)
        {
            var stack = new Stack<int>();
            int i = 0;

            while (i < heights.Length)
            {
                for (int j = i; j < heights.Length; j++)
                {
                    var minBar = Math.Min(heights[i], heights[j]);
                    var maxArea = minBar * (j - i + 1);
                    var stackValue = stack.Count > 0 ? stack.Peek() : 0;
                    if (maxArea > stackValue)
                    {
                        stack.Clear();
                        stack.Push(maxArea);
                    }
                }
                i++;
            }

            return stack.Pop();
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
