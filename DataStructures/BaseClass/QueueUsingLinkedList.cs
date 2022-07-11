using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BaseClass
{
    // A class to represent a queue The queue,
    // front stores the front node of LL and rear stores the last node of LL
    public class QueueUsingLinkedList
    {
        public Node front, rear;

        public QueueUsingLinkedList()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue.
        public void enqueue(int key)
        {
            // Create a new LL node
            Node temp = new Node(key);

            // If queue is empty, then new node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the end of queue and change rear
            this.rear.next = temp;
            this.rear = temp;
        }

        // Method to remove an key from queue.
        public void dequeue()
        {
            // If queue is empty, return NULL.
            if (this.front == null)
                return;

            // Store previous front and move front one node ahead
            Node temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL
            if (this.front == null)
                this.rear = null;
        }
    }
}
