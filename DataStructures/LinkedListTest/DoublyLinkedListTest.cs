using DataStructures.BaseClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DataStructures.LinkedListTest
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DoublyLinkedList dll = new DoublyLinkedList();

            // Start with the empty list
            dll.head_ref = null;

            // Insert 6.
            // So linked list becomes 6.null
            dll.push(6);

            // Insert 7 at the beginning.
            // So linked list becomes 7.6.null
            dll.push(7);

            // Insert 1 at the beginning.
            // So linked list becomes 1.7.6.null
            dll.push(1);

            Debug.Write("Created DLL is: ");
            dll.printList(dll.head_ref);
        }
    }
}
