using DataStructures.Queues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructures.QueueTest
{
    [TestClass]
    public sealed class CircularQueueTest
    {
        [TestMethod]
        public void CircularQueueTest1()
        {
            var queue = new CircularQueue<int>(4);
            queue.Enqueue(10);
            queue.PrintQueue();

            queue.Enqueue(20);
            queue.PrintQueue();

            queue.Enqueue(30);
            queue.PrintQueue();

            queue.Enqueue(40);
            queue.PrintQueue();

            //This element will shit on top
            Console.WriteLine("Element should shifted");
            queue.Enqueue(50);
            queue.PrintQueue();

            queue.Dequeue();
            queue.PrintQueue();

            queue.Dequeue();
            queue.PrintQueue();

            queue.Enqueue(60);
            queue.PrintQueue();


        }
    }

}
