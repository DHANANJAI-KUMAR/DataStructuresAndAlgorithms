using DataStructures.BaseClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DataStructures.LinkedListTest
{
    //https://www.geeksforgeeks.org/linked-list-set-1-introduction/

    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void createasimplelinkedlistwith3nodes()
        {
            /* Start with the empty list. */
            MyLinkedList llist = new MyLinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            llist.head.next = second; // Link first node with the second node

            second.next = third; // Link second node with the third node

            llist.printList();

        }


        [TestMethod]
        public void InsertingNodeToSimplelinkedlist()
        {
            /* Start with the empty list. */
            MyLinkedList llist = new MyLinkedList();

            // Insert 6. So linked list becomes 6->NUllist
            llist.append(6);

            // Insert 7 at the beginning. 
            // So linked list becomes 7->6->NUllist
            llist.push(7);

            // Insert 1 at the beginning. 
            // So linked list becomes 1->7->6->NUllist
            llist.push(1);

            // Insert 4 at the end. So linked list becomes
            // 1->7->6->4->NUllist
            llist.append(4);

            // Insert 8, after 7. So linked list becomes
            // 1->7->8->6->4->NUllist
            llist.insertAfter(llist.head.next, 8);

            Debug.Write("Created Linked list is: ");
            //Created Linked list is:  1  7  8  6  4
            llist.printList();

        }

        [TestMethod]
        public void DeletingNodeToSimplelinkedlist()
        {
            /* Start with the empty list. */
            MyLinkedList llist = new MyLinkedList();

            llist.push(7);
            llist.push(1);
            llist.push(3);
            llist.push(2);

            Debug.WriteLine("\nCreated Linked list is:");
            llist.printList();

            // Delete node with data 1
            llist.deleteNode(1);

            Debug.WriteLine("\nLinked List after Deletion of 1:");
            llist.printList();

        }

    }
}
