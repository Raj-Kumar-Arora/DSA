using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal class LeetCode_28_Easy
    {
        public static void CountNodes()
        {
            //// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //    bt.root.left = new Node(2);
            //        bt.root.left.left = new Node(4);
            //        bt.root.left.right = new Node(5);
            //    bt.root.right = new Node(3);
            //        bt.root.right.left = new Node(6);
            //int expectedOutput = 6;

            //// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //int expectedOutput = 0;

            //// CASE - 3
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
            int expectedOutput = 1;

            int actualOutput = CountNodes(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        private static int CountNodes(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                return CountNodes(node.left) + CountNodes(node.right) + 1;
            }
        }
    }
}
