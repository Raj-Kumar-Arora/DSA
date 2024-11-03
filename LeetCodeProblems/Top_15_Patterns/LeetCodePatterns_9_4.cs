using DSA.Trees;
using static System.Runtime.InteropServices.JavaScript.JSType;

//REF - LeetCode_150LeetCode_23_Easy

/* NOT SUBMITTED to LEETCODE
 * because output being returned need some formattting - MINOR CORRECTIONS REQD
 * e.g. my code returns "1-", "2-", "5", "1-", "3"  
 * EXPECTED = "1-2-5", "1-3"
 */
namespace LeetCodeProblems.Top_15_Patterns
{
    internal static class LeetCodePatterns_9_4
    {
        public static void BinaryTreePaths()
        {
            //CASE - 1
            BinaryTree bt = new BinaryTree()
            {
                root = new Node()
                {
                    data = 1,
                    left = new Node()
                    {
                        data = 2,
                        left = null,
                        right = new Node() { data = 5 }
                    },
                    right = new Node (3)
                }
            };
            var actualOutput = BinaryTreePaths(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        private static IList<string> BinaryTreePaths(Node root)
        {
            if (root == null) return null;

            List<string> result = new();
            
            //return if its leaf node
            if (root.left == null && root.right == null) 
                 result.Add (root.data.ToString());

            if (root.left != null)
            {
                List<string> subRslt = BinaryTreePaths(root.left).ToList();
                result.Add(root.data.ToString() + "-");
                result.AddRange(subRslt);
            }

            if (root.right != null)
            {
                List<string> subRslt = BinaryTreePaths(root.right).ToList();
                result.Add(root.data.ToString() + "-");
                result.AddRange(subRslt);
            }

            return result;
        }

        //private static string BinaryTreePaths(Node root)
        //{
        //    string result = string.Empty;

        //    //return if its leaf node
        //    if (root.left == null && root.right == null)
        //        result += root.data.ToString();
        //    else
        //    {
        //        if (root.left != null)
        //            result += root.left.data.ToString();
        //    }


        //    return result;
        //}
    }

}