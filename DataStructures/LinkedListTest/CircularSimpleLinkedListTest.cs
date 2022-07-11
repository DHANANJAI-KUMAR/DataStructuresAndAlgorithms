using DataStructures.BaseClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DataStructures.LinkedListTest
{
    //https://www.geeksforgeeks.org/linked-list-set-1-introduction/

    [TestClass]
    public class CircularSimpleLinkedListTest
    {
        [TestMethod]
        public void CreateCircularSimpleLinkedList()
        {
            /* Start with the empty list. */
            CircularSimpleLinkedList csll = new CircularSimpleLinkedList();

            /* Initialize lists as empty */
            Node head = null;

            /* Created linked list will
            be 11.2.56.12 */
            head = csll.push(head, 12);
            head = csll.push(head, 56);
            head = csll.push(head, 2);
            head = csll.push(head, 11);

            Debug.WriteLine("Contents of Circular " + "Linked List:");
            csll.printList(head);

        }


       

    }
}
