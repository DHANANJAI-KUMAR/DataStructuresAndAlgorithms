using DataStructures.Nodes;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class BinaryTreeIsSymmetric
    {
        [TestMethod]
        public void BinaryTreeIsSymmetricTest()
        {
            // Example symmetric tree:
            //      1
            //     / \
            //    2   2
            //   / \ / \
            //  3  4 4  3

            BinaryNode root = new BinaryNode(1,
                new BinaryNode(2, new BinaryNode(3), new BinaryNode(4)),
                new BinaryNode(2, new BinaryNode(4), new BinaryNode(3)));

            Console.WriteLine(IsSymmetric(root)); // Output: True
        }

        public bool IsSymmetric(BinaryNode root)
        {
            if (root == null)
                return true;

            return IsMirror(root.left, root.right);
        }

        private bool IsMirror(BinaryNode t1, BinaryNode t2)
        {
            if (t1 == null && t2 == null)
                return true;

            if (t1 == null || t2 == null)
                return false;

            return (t1.key == t2.key)
                && IsMirror(t1.left, t2.right)
                && IsMirror(t1.right, t2.left);
        }

    }
}
