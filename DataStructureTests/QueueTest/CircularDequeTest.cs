using DataStructures.Queues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructures.QueueTest
{
    [TestClass]
    public sealed class CircularDequeTest
    {
        [TestMethod]

        public void CircularDequeTest1()
        {
            // Create deque with capacity 4
            var dq = new CircularDeque<int>(4);

            // Insert at rear
            dq.AddRear(10);
            Console.WriteLine(dq.FrontEle() + " " + dq.RearEle());

            // Insert at front
            dq.AddFront(20);
            Console.WriteLine(dq.FrontEle() + " " + dq.RearEle());
            dq.AddFront(30);
            Console.WriteLine(dq.FrontEle() + " " + dq.RearEle());

            // Delete from rear
            dq.RemoveRear();
            Console.WriteLine(dq.FrontEle() + " " + dq.RearEle());
            dq.AddRear(40);
            Console.WriteLine(dq.FrontEle() + " " + dq.RearEle());
            dq.RemoveRear();
            Console.WriteLine(dq.FrontEle() + " " + dq.RearEle());
        
        }
    }
}
