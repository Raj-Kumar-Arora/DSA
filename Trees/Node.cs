namespace DSA.Trees
{
    public class Node
    {
        public Node? lChild;
        public char data;
        public Node? rChild;
        public Node(char d)
        {
            data = d;
            lChild = rChild = null;
        }
    }
}
