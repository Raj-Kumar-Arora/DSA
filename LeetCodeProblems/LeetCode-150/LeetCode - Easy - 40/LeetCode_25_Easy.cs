using DSA.Trees;
namespace LeetCodeProblems.LeetCode_150
{
    internal class LeetCode_25_Easy
    {
        public static void InvertTree()
        {
            // CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(10);
            //bt.root.left = new Node(11);
            //bt.root.right = new Node(12);
            //bt.root.left.left = new Node(13);
            //bt.root.left.right = new Node(14);
            //bt.root.right.left = new Node(15);
            //bt.root.right.right = new Node(16);

            //// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);

            // CASE - 3
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(2);
            bt.root.left = new Node(3);
            bt.root.right = null;
            bt.root.left.left = new Node(1);


            Console.WriteLine("Tree BEFORE Invert : ");
            bt.Display();

            var newRoot = InvertTree(bt.root);
            bt.root = newRoot;
            Console.WriteLine("Tree AFTER Invert : ");
            bt.Display();
        }
        // Code submitted/ accepted to / by LeetCode
        //private static TreeNode InvertTree(TreeNode root)
        //{
        //if (root == null)
        //    return null;

        //InvertTree(root.left);
        //InvertTree(root.right);

        ////Swap the nodes
        //TreeNode tmp = root.left;
        //root.left = root.right;
        //root.right = tmp;

        //return root;
        //}


        private static Node InvertTree(Node root)
        {
            if (root == null)
                return null;

            InvertTree(root.left);
            InvertTree(root.right);

            //Swap the nodes
            Node tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            return root;
        }
        //ALL CASES NOT WORKING - so taking most voted soln from leetcode 

        //private static Node InvertTree(Node root)
        //{
        //    if (root == null)
        //        return null;

        //    Queue<Node> queue = new ();
        //    queue.Enqueue(root);
        //    List<Node> invertedTree = new (); 

        //    //We will do Level Traversal for tree with swapping of left <-> right to invert tree
        //    while (queue.Count > 0)
        //    {
        //        Node node = queue.Dequeue();
        //        if (node != null)
        //        {
        //            invertedTree.Add(new Node (node.data));
        //            queue.Enqueue(node.right);
        //            queue.Enqueue(node.left);
        //        }
        //        else
        //        {
        //            invertedTree.Add(null);
        //        }
        //    }

        //    //now we need to create tree from invertedTree list by assigning left/right childs
        //    for (int i = 1; i < invertedTree.Count; i++)
        //    {
        //        //index of parent node to which current node will be assigned as left/right
        //        int parentNodeIndex = (i - 1) / 2;
        //        bool isLeftChild = (i % 2 == 1);  //if it will be left/right child of binary tree?
        //        if (invertedTree[parentNodeIndex] != null)
        //        {
        //            if (isLeftChild)
        //                invertedTree[parentNodeIndex].left = invertedTree[i];
        //            else
        //                invertedTree[parentNodeIndex].right = invertedTree[i];
        //        }
        //    }
        //    return invertedTree[0];
        //}
    }
}
