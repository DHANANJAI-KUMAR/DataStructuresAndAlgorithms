using DataStructures.Nodes;

namespace DataStructures.Trees
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
