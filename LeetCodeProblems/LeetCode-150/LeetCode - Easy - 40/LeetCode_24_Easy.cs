using DSA.Trees;

namespace LeetCodeProblems.LeetCode_150
{
    internal class LeetCode_24_Easy
    {
        public static void IsSameTree()
        {
            // CASE - 1
            //BinaryTree bt1 = new BinaryTree()
            //{ 
            //    root = new Node() 
            //    {   data = 1,               
            //        left = new Node()  { data = 2 },
            //        right = new Node() { data = 3 }
            //    }
            //};
            //BinaryTree bt2 = new BinaryTree()
            //{
            //    root = new Node()
            //    {
            //        data = 1,
            //        left = new Node() { data = 2 },
            //        right = new Node() { data = 3 }
            //    }
            //};

            // CASE - 2
            BinaryTree bt1 = new BinaryTree()
            {
                root = new Node()
                {
                    data = 1,
                    left = new Node() { data = 2 }
                }
            };
            BinaryTree bt2 = new BinaryTree()
            {
                root = new Node()
                {
                    data = 1,
                    right = new Node() { data = 2 }
                }
            };

            bool actualOutput = IsSameTree(bt1.root, bt2.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        // private static bool IsSameTree(TreeNode p, TreeNode q)
        // Code submitted/ accepted to / by LeetCode

        private static bool IsSameTree(Node p, Node q)
        {
            if (p == q) return true;
            if (p == null || q == null) return false;

            if (p.data != q.data) return false;

            if (IsSameTree(p.left, q.left) == false)
                return false;

            if (IsSameTree(p.right, q.right) == false)
                return false;

            return true;
        }
    }
}
