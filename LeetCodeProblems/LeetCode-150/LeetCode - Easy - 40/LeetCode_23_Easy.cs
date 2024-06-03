using DSA.Trees;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_23_Easy
    {
        //Similar to BinaryTree.cs - Height()
        public static void MaxDepth()
        {
            //CASE - 1
            BinaryTree bt = new BinaryTree()
            {
                root = new Node()
                {
                    data = 3,
                    left = { data = 9 },                //**  EQUIVALENT TO new Node() { data = 9 }  **/
                    right = new Node()
                    {
                        data = 20,
                        left = new Node() { data = 15 },
                        right = new Node() { data = 7 }
                    }
                }
            };
            var actualOutput = MaxDepth(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        //private int MaxDepth(TreeNode root)
        // Code submitted/ accepted to / by LeetCode
        private static int MaxDepth(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                int ld = MaxDepth(root.left);
                int rd = MaxDepth(root.right);

                if (ld >= rd)
                    return ld + 1;
                else
                    return rd + 1;
            }
        }
    }

}