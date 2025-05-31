using DataStructures.Nodes;
using DataStructures.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructures.BinaryTreeTest
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void BinaryTreeTest1()
        {

            BinaryTree tree = new BinaryTree();

            // Create root
            tree.root = new BinaryNode(1);

            /* Following is the tree after above statement

                 1
                / \
             null null     */
            tree.root.left = new BinaryNode(2);
            tree.root.right = new BinaryNode(3);

            /* 2 and 3 become left and right children of 1
                    1
                 /     \
               2        3
             /  \     /   \
           null null null null */
            tree.root.left.left = new BinaryNode(4);

            /* 4 becomes left child of 2
                    1
                 /     \
               2        3
             /  \     /   \
             4 null null null
            / \
         null null
            */

        }



    }
}
