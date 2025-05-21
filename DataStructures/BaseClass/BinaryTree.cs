using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BaseClass
{
    public class BinaryTree
    {
        // Root of Binary Tree
        public BinaryNode root;

        // Constructors
        public BinaryTree(int key)
        {
            root = new BinaryNode(key);
        }

        public BinaryTree()
        {
            root = null;
        }
    }


}
