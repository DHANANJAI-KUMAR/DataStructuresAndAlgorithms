namespace DataStructures.Nodes
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
