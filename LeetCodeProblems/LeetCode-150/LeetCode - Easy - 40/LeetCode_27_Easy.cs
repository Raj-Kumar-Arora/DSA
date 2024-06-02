using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal class LeetCode_27_Easy
    {

        public static void HasPathSum()
        {
            //// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(5);
            //    bt.root.left = new Node(4);
            //        bt.root.left.left = new Node(11);
            //            bt.root.left.left.left = new Node(7);
            //            bt.root.left.left.right = new Node(2);
            //    bt.root.right = new Node(8);
            //        bt.root.right.left = new Node(13);
            //        bt.root.right.right = new Node(4);
            //            bt.root.right.right.right = new Node(1);
            //int targetSum = 22;
            //bool expectedOutput = true;

            //// CASE - 2  [1,2]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);
            //int targetSum = 1;
            ////bool expectedOutput = false;

            // CASE - 3  [1]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //int targetSum = 1;
            ////bool expectedOutput = true;

            //// CASE - 4  [-2,null,-3]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(-2);
            //    bt.root.right = new Node(-3);
            //int targetSum = -2;
            ////bool expectedOutput = false;

            //// CASE - 5  [1,2,null,3,null,4,null,5
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
            bt.root.left = new Node(2);
            bt.root.left.left = new Node(3);
            bt.root.left.left.left = new Node(4);
            bt.root.left.left.left.left = new Node(5);
            int targetSum = 6;
            //bool expectedOutput = false;

            //// CASE - 6    [5,4,8,11,null,13,4,7,2,null,null,null,1]
            ///// same as case 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(5);
            //    bt.root.left = new Node(4);
            //        bt.root.left.left = new Node(11);
            //        bt.root.left.left.left = new Node(7);
            //        bt.root.left.left.right = new Node(2);
            //    bt.root.right = new Node(8);
            //        bt.root.right.left = new Node(13);
            //        bt.root.right.right = new Node(4);
            //        bt.root.right.right.right = new Node(1);
            //int targetSum = 22;
            //bool expectedOutput = true;

            bool actualOutput = HasPathSum(bt.root, targetSum);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        private static bool HasPathSum(Node root, int targetSum)
        {
            if (root == null) return false;

            int currSum = root.data;

            if ((root.left != null && HasPathSum(root.left, targetSum, currSum)) ||
               (root.right != null && HasPathSum(root.right, targetSum, currSum)))
                return true;
            else
            {
                if (root.left == null && root.right == null && currSum == targetSum)
                    return true;
            }
            return false;
        }
        private static bool HasPathSum(Node node, int targetSum, int currSum)
        {
            currSum += node.data;

            if ((node.left != null && HasPathSum(node.left, targetSum, currSum)) ||
                (node.right != null && HasPathSum(node.right, targetSum, currSum)))
                return true;
            else
            {
                if (node.left == null && node.right == null && currSum == targetSum)
                    return true;
            }

            return false;

            // ** Following code not passing case [1,2] / targetSum = 1 **
            //if (node == null)
            //{
            //    if (currSum == targetSum)
            //        return true;
            //}
            //else
            //{
            //    currSum += node.data;
            //    return (HasPathSum(node.left, targetSum, currSum) ||
            //            HasPathSum(node.right, targetSum, currSum));
            //}

            //return false;

            //if (node == null)
            //{
            //    if (currSum == targetSum) 
            //        return true;
            //}
            //else
            //{
            //    currSum += node.data;
            //    return (HasPathSum(node.left, targetSum, currSum) ||
            //            HasPathSum(node.right, targetSum, currSum));
            //}

            //return false;
        }

    }
}
