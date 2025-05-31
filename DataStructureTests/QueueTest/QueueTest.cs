using DataStructures.Queues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DataStructures.QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void QueueTest1()
        {
            QueueUsingLinkedList q = new QueueUsingLinkedList();
            q.enqueue(10);
            q.enqueue(20);
            q.dequeue();
            q.dequeue();
            q.enqueue(30);
            q.enqueue(40);
            q.enqueue(50);
            q.dequeue();
            Debug.WriteLine("Queue Front : " + q.front.data);
            Debug.WriteLine("Queue Rear : " + q.rear.data);

        }
    }
}
