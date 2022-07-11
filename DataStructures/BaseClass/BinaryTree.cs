using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BaseClass
{
    public class BinaryNode
    {
        public int key;
        public BinaryNode left;
        public BinaryNode right;

        public BinaryNode(int key)
        {
            this.key = key;
            this.left = this.right = null;
        }
        
        public BinaryNode(int key, BinaryNode left, BinaryNode right)
        {
            this.key = key;
            this.left = left;
            this.right = right;
        }
    }


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
