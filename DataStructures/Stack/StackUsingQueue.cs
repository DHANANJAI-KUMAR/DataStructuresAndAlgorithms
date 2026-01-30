using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTests.StackTest
{
    public class StackUsingQueue<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();
        public int Size() { return q1.Count; }

        // Push element onto stack
        public void Push(T x)
        {
            // Step 1: Enqueue to q2
            q2.Enqueue(x);

            // Step 2: Move all from q1 to q2
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            // Step 3: Swap q1 and q2
            Queue<T> temp = q1;
            q1 = q2;
            q2 = temp;
        }

        // Removes the element on top of the stack
        public T Pop()
        {
            if (q1.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            return q1.Dequeue();
        }

        // Get the top element
        public T Top()
        {
            if (q1.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            return q1.Peek();
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return q1.Count == 0;
        }
    }

}
