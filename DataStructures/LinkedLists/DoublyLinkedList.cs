using DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class DoublyLinkedList
    {
        public DoublyNode head_ref;

        // Function to push a new element in the Doubly Linked List
        public void push(int new_data)
        {

            // Allocate node
            DoublyNode new_node = new DoublyNode(new_data, head_ref, null);
           
            // Change prev of head node to the new node
            if (head_ref != null)
                head_ref.prev = new_node;

            // Move the head to point to the new node
            head_ref = new_node;
        }

        // Function to traverse the Doubly LL in the forward & backward direction
        public void printList(DoublyNode node)
        {
            DoublyNode last = null;

            Debug.Write("\nTraversal in forward" + " direction \n");
            while (node != null)
            {

                // Print the data
                Debug.Write(" " + node.data + " ");
                last = node;
                node = node.next;
            }

            Debug.Write("\nTraversal in reverse" + " direction \n");
            while (last != null)
            {
                // Print the data
                Debug.Write(" " + last.data + " ");
                last = last.prev;
            }
        }

    }
}
