namespace DSA.Trees
{
    public class Node
    {
        public Node? lChild;
        public int data;
        public Node? rChild;
        public Node(int d)
        {
            data = d;
            lChild = rChild = null;
        }
    }
}
