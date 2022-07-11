using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BaseClass
{
    // A class to represent a queue The queue,
    // front stores the front node of LL and rear stores the last node of LL
    public class StackUsingLinkedList
    {
        Node root;

        public bool isEmpty()
        {
            if (root == null)
            {
                return true;
            }
            else
                return false;
        }

        public void push(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node temp = root;
                root = newNode;
                newNode.next = temp;
            }
            Console.WriteLine(data + " pushed to stack");
        }

        public int pop()
        {
            int popped = int.MinValue;
            if (root == null)
            {
                Debug.WriteLine("Stack is Empty");
            }
            else
            {
                popped = root.data;
                root = root.next;
            }
            return popped;
        }

        public int peek()
        {
            if (root == null)
            {
                Debug.WriteLine("Stack is empty");
                return int.MinValue;
            }
            else
            {
                return root.data;
            }
        }
    }
}
