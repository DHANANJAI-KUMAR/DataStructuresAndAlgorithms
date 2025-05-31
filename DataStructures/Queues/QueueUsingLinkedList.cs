using DataStructures.Nodes;

namespace DataStructures.Queues
{
    // A class to represent a queue The queue,
    // front stores the front node of LL and rear stores the last node of LL
    public class QueueUsingLinkedList
    {
        public Node front, rear;

        public QueueUsingLinkedList()
        {
            front = rear = null;
        }

        // Method to add an key to the queue.
        public void enqueue(int key)
        {
            // Create a new LL node
            Node temp = new Node(key);

            // If queue is empty, then new node is front and rear both
            if (rear == null)
            {
                front = rear = temp;
                return;
            }

            // Add the new node at the end of queue and change rear
            rear.next = temp;
            rear = temp;
        }

        // Method to remove an key from queue.
        public void dequeue()
        {
            // If queue is empty, return NULL.
            if (front == null)
                return;

            // Store previous front and move front one node ahead
            Node temp = front;
            front = front.next;

            // If front becomes NULL, then change rear also as NULL
            if (front == null)
                rear = null;
        }
    }
}
