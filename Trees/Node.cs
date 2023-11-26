namespace DSA.Trees
{
    public class Node
    {
        //TODO - enable generic type T support instead of hardcoded int type
        public Node? left;
        public int data;
        public Node? right;

        public Node() { }
        public Node(int d)
        {
            data = d;
            left = right = null;
        }
        public Node (int d, Node? l, Node? r) 
        {
            data = d;
            left = l;
            right = r;
        }

    }
}
