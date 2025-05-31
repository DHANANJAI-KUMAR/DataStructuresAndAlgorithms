using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues
{
    //DoubleEndedQueue
    public class CircularDeque<T>
    {
        private T[] data;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public CircularDeque(int capacity)
        {
            this.capacity = capacity;
            data = new T[capacity];
            front = -1;
            rear = -1;
            size = 0;
        }

        public bool IsEmpty => size == 0;

        public bool IsFull => size == capacity;

        public int Count => size;

        // Add to front
        public void AddFront(T item)
        {
            if (IsFull)
                throw new InvalidOperationException("Deque is full");

            if (IsEmpty)
            {
                front = rear = 0;
            }
            else
            {
                front = (front - 1 + capacity) % capacity;
            }

            data[front] = item;
            size++;
        }

        // Add to rear
        public void AddRear(T item)
        {
            if (IsFull)
                throw new InvalidOperationException("Deque is full");

            if (IsEmpty)
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity;
            }

            data[rear] = item;
            size++;
        }

        // Remove from front
        public T RemoveFront()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque is empty");

            T item = data[front];
            if (front == rear)
            {
                front = rear = -1; // Deque is now empty
            }
            else
            {
                front = (front + 1) % capacity;
            }

            size--;
            return item;
        }

        // Remove from rear
        public T RemoveRear()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque is empty");

            T item = data[rear];
            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                rear = (rear - 1 + capacity) % capacity;
            }

            size--;
            return item;
        }

        // Peek front
        public T PeekFront()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque is empty");

            return data[front];
        }

        // Peek rear
        public T PeekRear()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque is empty");

            return data[rear];
        }


        // Get the front element
        public T FrontEle() { return data[front]; }

        // Get the rear element
        public T RearEle()
        {
            int rear = (front + size - 1) % capacity;
            return data[rear];
        }

    }

}
