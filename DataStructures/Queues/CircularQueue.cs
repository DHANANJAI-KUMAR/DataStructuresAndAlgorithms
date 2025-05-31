using System;

namespace DataStructures.Queues
{
   
    public class CircularQueue<T>
    {
        private T[] buffer;
        private int head;
        private int tail;
        private int size;

        public int Capacity => buffer.Length;
        public int Count => size;

        public CircularQueue(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            buffer = new T[capacity];
            head = 0;
            tail = 0;
            size = 0;
        }

        public void Enqueue(T item)
        {
            buffer[tail] = item;
            tail = (tail + 1) % Capacity;

            if (size == Capacity)
            {
                // Overwrite the oldest item
                head = (head + 1) % Capacity;
            }
            else
            {
                size++;
            }
        }

        public T Dequeue()
        {
            if (size == 0)
                throw new InvalidOperationException("Queue is empty");

            T item = buffer[head];
            head = (head + 1) % Capacity;
            size--;
            return item;
        }

        public T Peek()
        {
            if (size == 0)
                throw new InvalidOperationException("Queue is empty");

            return buffer[head];
        }

        public void PrintQueue()
        {
            Console.Write("Queue: ");
            for (int i = 0; i < size; i++)
            {
                int index = (head + i) % Capacity;
                Console.Write(buffer[index] + " ");
            }
            Console.WriteLine();
        }
    }

}
