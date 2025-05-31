using DataStructures.BaseClass;
using Ds.Common.Lib;

namespace CommonInterviewProblems
{
    [TestClass]
    public class ReversingTheFirstKElementsOfAQueue
    {
        [TestMethod]
        public void ReversingTheFirstKElementsOfAQueueTest()
        {
            /*Input: q = 1 2 3 4 5, k = 3
            //Output: 3 2 1 4 5
                Explanation:  After reversing the first 3 elements from the given queue the resultant queue will be 3 2 1 4 5.
            */
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            int k = 3;
            ReverseFirstK(q, k);
            QueueUtil.Print(q);

        }


        private void ReverseFirstK(Queue<int> q, int k)
        {
            if (q.Count == 0 || k > q.Count)
                return;
            if (k <= 0)
                return; 
            
            var s = new Stack<int>();

            while (s.Count < k)
            {
                s.Push(q.Dequeue());
            }
            
            while (s.Count > 0)
            {
                q.Enqueue(s.Pop());
            }

            /* Remove the remaining elements and enqueue them at the end of the Queue*/
            for (int i = 0; i < q.Count - k; i++)
            {
                q.Enqueue(q.Dequeue());
            }
        }


    }

}