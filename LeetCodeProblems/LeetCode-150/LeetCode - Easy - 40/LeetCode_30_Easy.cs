using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_30_Easy
    {

        public static void GetMinimumDifference()
        {
            //////// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(4);
            //    bt.root.left = new Node(2);
            //        bt.root.left.left = new Node(1);
            //        bt.root.left.right = new Node(3);
            //    bt.root.right = new Node(6);
            ////int expectedOutput = 1;

            //////// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //    bt.root.left = new Node(0);
            //    bt.root.right = new Node(48);
            //        bt.root.right.left = new Node(12);
            //        bt.root.right.right = new Node(49);
            //////int expectedOutput = 1;

            //////// CASE - 3
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //    bt.root.left = null;
            //    bt.root.right = new Node(3);
            //        bt.root.right.left = new Node(2);
            //////int expectedOutput = 1;

            ////// CASE - 4   236,104,701,null,227,null,911]
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(236);
            bt.root.left = new Node(104);
            bt.root.left.right = new Node(227);
            bt.root.right = new Node(701);
            bt.root.right.right = new Node(911);
            //int expectedOutput = 1;

            var actualOutput = GetMinimumDifference(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        private static int GetMinimumDifference(Node root)
        {
            //Approach:-
            //Since its BST, so inorder traversal will sort it 
            //then will find min diff b/w any 2 nodes

            //Step - 1 inorder traversal
            //int[] sortedArr = new();
            List<int> sortedList = new();
            InOrder(root, sortedList);

            //Step - 2 find 2 lowest values in list and get abs diff
            int minDiff = int.MaxValue;
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedList.Count; j++)
                {
                    int tmpDiff = Math.Abs(sortedList[i] - sortedList[j]);
                    if (tmpDiff < minDiff)
                        minDiff = tmpDiff;
                }
            }
            return minDiff;
        }
        private static void InOrder(Node node, List<int> sortedList)
        {
            if (node == null)
                return;

            InOrder(node.left, sortedList);
            sortedList.Add(node.data);
            InOrder(node.right, sortedList);
        }
        //BELOW CODE NOT WORKING for cae 4
        //I found the reason is misunderstanding about the problem
        //What I thought - Find min diff between 2 adjacent nodes in tree
        //What it is     - Find min diff between ANY 2 nodes in tree
        // se need to write this algo again
        //private static int GetMinimumDifference(Node root)
        //{
        //    if (root == null) return 0;

        //    int nMinDiff = int.MaxValue, lMinDiff = int.MaxValue, rMinDiff = int.MaxValue;
        //    if (root.left != null && root.right!= null)
        //    {
        //        nMinDiff = Math.Min (Math.Abs(root.data - root.left.data), Math.Abs(root.data - root.right.data));

        //        lMinDiff = GetMinimumDifference(root.left);
        //        rMinDiff = GetMinimumDifference(root.right);
        //    }
        //    else if (root.left != null && root.right == null)
        //    {
        //        nMinDiff = Math.Min(Math.Abs(root.data - root.left.data), int.MaxValue);

        //        lMinDiff = GetMinimumDifference(root.left);
        //        rMinDiff = int.MaxValue;
        //    }
        //    else if (root.left == null && root.right != null)
        //    {
        //        nMinDiff = Math.Min(int.MaxValue, Math.Abs(root.data - root.right.data));

        //        lMinDiff = int.MaxValue;
        //        rMinDiff = GetMinimumDifference(root.right);
        //    }

        //    return Math.Min(nMinDiff, Math.Min(lMinDiff, rMinDiff));
        //}
    }
}
