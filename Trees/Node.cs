namespace DSA.Trees
{
    public class Node
    {
        public Node? left;
        public int data;
        public Node? right;
        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
}
