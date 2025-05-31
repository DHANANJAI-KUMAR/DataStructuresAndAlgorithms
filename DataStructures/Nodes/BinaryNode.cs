
namespace DataStructures.Nodes
{
    public class BinaryNode
    {
        public int key;
        public BinaryNode left;
        public BinaryNode right;

        public BinaryNode(int key)
        {
            this.key = key;
            left = right = null;
        }

        public BinaryNode(int key, BinaryNode left, BinaryNode right)
        {
            this.key = key;
            this.left = left;
            this.right = right;
        }
    }
}
