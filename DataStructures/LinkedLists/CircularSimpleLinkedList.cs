using DataStructures.Nodes;
using System.Diagnostics;

namespace DataStructures.LinkedLists
{
    public class CircularSimpleLinkedList
    {
        public Node addToEmpty(Node last, int data)
        {
            // This function is only for empty list
            if (last != null)
                return last;

            // Creating a node dynamically.
            Node temp = new Node(data, last);
            last = temp;

            return last;
        }
        
        
        public Node addBegin(Node last, int data)
        {
            if (last == null)
                return addToEmpty(last, data);

            // Creating a node dynamically
            Node temp = new Node(data, last.next);

            // Adjusting the links
            last.next = temp;

            return last;
        }
        
        
        public Node addEnd(Node last, int data)
        {
            if (last == null)
                return addToEmpty(last, data);

            // Creating a node dynamically. 
            Node temp = new Node(data, last.next);

            // Adjusting the links. 
            last.next = temp;
            last = temp;

            return last;
        }

        public Node addAfter(Node last, int data, int item)
        {
            if (last == null)
                return null;

            Node temp, p;
            p = last.next;
            do
            {
                if (p.data == item)
                {
                    temp = new Node(data, p.next);
                    p.next = temp;

                    if (p == last)
                        last = temp;
                    return last;
                }
                p = p.next;
            } while (p != last.next);

            Debug.WriteLine(item + " not present in the list.");
            return last;

        }

        public Node push(Node head_ref, int data)
        {
            Node ptr1 = new Node(data, head_ref);
            Node temp = head_ref;

            /* If linked list is not null then set the next of last node */
            if (head_ref != null)
            {
                while (temp.next != head_ref)
                    temp = temp.next;
                temp.next = ptr1;
            }
            else
                ptr1.next = ptr1;

            head_ref = ptr1;

            return head_ref;
        }

        /* Function to print nodes in a given Circular linked list */
        public void printList(Node head)
        {
            Node temp = head;
            if (head != null)
            {
                do
                {
                    Debug.Write(temp.data + " ");
                    temp = temp.next;
                }
                while (temp != head);
            }
        }


    }
}
