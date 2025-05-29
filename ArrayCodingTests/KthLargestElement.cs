namespace ArrayCodingTests
{
    [TestClass]
    public sealed class KthLargestElement
    {
        [TestMethod]
        public void KthLargestElementTest()
        {
            //Top 6 Coding Interview Concepts(Data Structures & Algorithms)
            //given an array of integers arr and an integer k, find the kth largest element.
            //To find the kth largest element in an array of integers, you have a few options. The most efficient way(especially when the array is large) is to use a Min-Heap(PriorityQueue) or Quickselect algorithm.

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 6, 8, 7, 3, 2 };
            int k = 4;

            int result = FindKthLargest(arr, k);
            Console.WriteLine($"{k}th largest element is: {result}"); // Output: 5
        }

        int FindKthLargest(int[] arr, int k)
        {
            // in .NET 6 and later, the built-in PriorityQueue<TElement, TPriority> is a min-heap by default (i.e., lowest priority dequeued first).
            // To use it as a max-heap, just invert the priority (e.g., by using -priority).
            // Min-heap of size k
            PriorityQueue<int, int> minHeap = new(); //Default
            //var minHeap = new PriorityQueue<int, int>();

            foreach (int num in arr)
            {
                minHeap.Enqueue(num, priority: num);

                // Keep the size of heap at most k
                if (minHeap.Count > k)
                    minHeap.Dequeue();
            }

            // The root of the heap is the kth largest
            return minHeap.Peek();
        }


    }
}
