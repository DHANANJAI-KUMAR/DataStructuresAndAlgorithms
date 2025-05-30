namespace DataStructureTests
{
    [TestClass]
    public sealed class CircularArrayTest
    {
        [TestMethod]
        public void CircularQueueTest()
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

    public class CircularQueue<T>
    {
        private T[] buffer;
        private int head;
        private int tail;
        private int size;
        private bool overWrite = false;

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
            if (size == Capacity && !overWrite)
                throw new InvalidOperationException("Queue is full"); 
            

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
