namespace DataStructures.Nodes
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
            data = d;
            this.next = next;
            this.prev = prev;
        }
    }
    
}
