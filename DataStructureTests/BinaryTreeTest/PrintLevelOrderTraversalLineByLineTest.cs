using DataStructures.Nodes;
using DataStructures.Trees;
using System.Reflection.Emit;

namespace DataStructures.BinaryTreeTest
{
    [TestClass]
    public class PrintLevelOrderTraversalLineByLineTest
    {
        [TestMethod]
        public void PrintLevelOrderTraversalLineByLineTest1()
        {
            // Binary tree structure:
            //
            //          1
            //        /   \
            //      2       3
            //    /  \    /   \
            //   4    5  6    null 
            
            BinaryTree tree = new BinaryTree();
            tree.root = new BinaryNode(1);
            tree.root.left = new BinaryNode(2);
            tree.root.left.left = new BinaryNode(4);
            tree.root.left.right = new BinaryNode(5);
            tree.root.right = new BinaryNode(3);
            tree.root.right.left = new BinaryNode(6);


            var traversal = LevelOrderUsingQueue(tree.root);
            foreach (var level in traversal)
            {
                foreach (var val in level)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }

        // Function to do level order traversal and return a 2D list
        private List<List<int>> LevelOrderUsingQueue(BinaryNode root)
        {
            var result = new List<List<int>>();
            if (root == null) return result;

            // Create an empty queue for level order traversal
            var queue = new Queue<BinaryNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                // nodeCount (queue size) indicates number of
                // nodes at current level.
                int nodeCount = queue.Count;
                var currentLevel = new List<int>();

                for (int i = 0; i < nodeCount; i++)
                {
                    var node = queue.Dequeue();
                    currentLevel.Add(node.key);

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                result.Add(currentLevel);
            }

            return result;
        }


       
    }
}
