using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BaseClass
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d) { 
            data = d;
            next = null;
        }

        public Node(int d, Node n)
        {
            data = d;
            next = n;
        }
    }
}
