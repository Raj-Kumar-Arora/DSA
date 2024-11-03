using DSA.Trees;
namespace LeetCodeProblems.Top_15_Patterns
{
    // REF - LeetCode_29_Easy - AverageOfLevels
    // its leetcode 150's - Meidum 87 problem
    // LeetCode_150 - LeetCode_87_Medium

    public class LeetCodePatterns_9_7
    {
        public static void LevelOrder()
        {
            ////Case - 1
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(3);
            bt.root.left = new Node(9);
            bt.root.right = new Node(20);
            bt.root.right.left = new Node(15);
            bt.root.right.right = new Node(7);

            var actualOutput = LevelOrder(bt.root);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }
        //https://leetcode.com/problems/binary-tree-level-order-traversal/solutions/3142782/o-n-time-o-n-space/
        private static IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                List<int> level = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    Node cur = queue.Dequeue();
                    level.Add(cur.data);

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }

                result.Add(level);
            }

            return result;
        }
    }
}
