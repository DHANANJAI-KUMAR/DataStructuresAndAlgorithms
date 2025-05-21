namespace CommonInterviewProblems
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

            int[] arr = { 3, 2, 1, 5, 6, 4 };
            int k = 2;

            int result = FindKthLargest(arr, k);
            Console.WriteLine($"{k}th largest element is: {result}"); // Output: 5
        }

        int FindKthLargest(int[] arr, int k)
        {
            // Min-heap of size k
            PriorityQueue<int, int> minHeap = new();

            foreach (int num in arr)
            {
                minHeap.Enqueue(num, num);

                // Keep the size of heap at most k
                if (minHeap.Count > k)
                    minHeap.Dequeue();
            }

            // The root of the heap is the kth largest
            return minHeap.Peek();
        }


    }
}
