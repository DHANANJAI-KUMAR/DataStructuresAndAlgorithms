using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BaseClass
{
    public class DoublyNode
    {
        public int data;
        public DoublyNode next;
        public DoublyNode prev;

        //public DoublyNode(int d) { 
        //    data = d;
        //    next = null;
        //}

        public DoublyNode(int d, DoublyNode next, DoublyNode prev)
        {
            this.data = d;
            this.next = next;
            this.prev = prev;
        }
    }
    
}
