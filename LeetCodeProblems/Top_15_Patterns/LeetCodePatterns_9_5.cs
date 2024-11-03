using DSA.Trees;
using static System.Runtime.InteropServices.JavaScript.JSType;

//REF - LeetCode_150LeetCode_27_Easy

/* NOT SUBMITTED to LEETCODE
 * because output being returned need some formattting - MINOR CORRECTIONS REQD
 * e.g. my code returns "1-", "2-", "5", "1-", "3"  
 * EXPECTED = "1-2-5", "1-3"
 */
namespace LeetCodeProblems.Top_15_Patterns
{
    internal static class LeetCodePatterns_9_5
    {
        public static void PathSum()
        {
            //// CASE - 1
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(5);
            bt.root.left = new Node(4);
            bt.root.left.left = new Node(11);
            bt.root.left.left.left = new Node(7);
            bt.root.left.left.right = new Node(2);
            bt.root.right = new Node(8);
            bt.root.right.left = new Node(13);
            bt.root.right.right = new Node(4);
            bt.root.right.right.left = new Node(5);
            bt.root.right.right.right = new Node(1);
            int targetSum = 22;
            //bool expectedOutput = true;

            //// CASE - 2  [1,2]

            var actualOutput = PathSum(bt.root, targetSum);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        private static IList<IList<int>> PathSum(Node root, int targetSum)
        {
            if (root == null) return null;

            List<List<int>> result = new();
            PathSum(root.left, targetSum, root.data, result);
            return (IList<IList<int>>)result;
        }
        private static List<int> PathSum(Node node, int targetSum, int currSum, List<List<int>> paths)
        {
            //if (node == null) 
            //    return null;

            //currSum += node.data;

            //if (currSum <= targetSum)
            //{              
            //    if (node.left == null && node.right == null)
            //    {
            //        if (currSum == targetSum)
            //        {
            //            paths.Add(node.data);
            //            return paths;
            //        }
            //    }
            //    else
            //    {
            //        paths.Add(node.data);
            //        PathSum(node.left, targetSum, currSum, paths);
            //        PathSum(node.right, targetSum, currSum, paths);
            //    }
            //}

            //return paths;
            return null;
        }

        //WORKING EXCEPT RETURN STATEMENT 
        //private static IList<IList<int>> PathSum(Node root, int targetSum)
        //{
        //    if (root == null) return null;

        //    List<List<int>> result = new();
        //    var leftPaths = new List<int>();
        //    leftPaths.Add(root.data);
        //    var rtPaths = new List<int>();
        //    rtPaths.Add(root.data);

        //    List<int> leftResult = PathSum(root.left, targetSum, root.data, leftPaths);
        //    List<int> rightResult = PathSum(root.right, targetSum, root.data, rtPaths);

        //    result.Add(leftResult);
        //    result.Add(rightResult);

        // error while return execution;
        //System.InvalidCastException: 'Unable to cast object of type 'System.Collections.Generic.List`1[System.Collections.Generic.List`1[System.Int32]]' to type 'System.Collections.Generic.IList`1[System.Collections.Generic.IList`1[System.Int32]]'.'

        //    return (IList<IList<int>>)result;
        //}
        //private static List<int> PathSum(Node node, int targetSum, int currSum, List<int> paths)
        //{
        //    if (node == null)
        //        return null;

        //    currSum += node.data;

        //    if (currSum <= targetSum)
        //    {
        //        if (node.left == null && node.right == null)
        //        {
        //            if (currSum == targetSum)
        //            {
        //                paths.Add(node.data);
        //                return paths;
        //            }
        //        }
        //        else
        //        {
        //            paths.Add(node.data);
        //            PathSum(node.left, targetSum, currSum, paths);
        //            PathSum(node.right, targetSum, currSum, paths);
        //        }
        //    }

        //    return paths;
        //}
    }

}