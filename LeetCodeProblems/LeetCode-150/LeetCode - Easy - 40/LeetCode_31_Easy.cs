using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_31_Easy
    {
        public static void SortedArrayToBST()
        {
            //////// CASE - 1
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            //int expectedOutput = 1;

            //////// CASE - 2

            //////// CASE - 3


            ////// CASE - 4   

            Node actualOutput = SortedArrayToBST(nums);

            // Console.WriteLine("Actual Output = " + new BinarySearchTree(actualOutput));
        }

        private static Node SortedArrayToBST(int[] nums)
        {
            //Approach:-
            //We will make use of the fact that the inorder traversal of BST gives Sorted Array
            //So we will reverse the logic of inorder traversal
            //by using Divide & Conquer technique
            if (nums.Length == 0) return null;

            int midIndex = nums.Length / 2;
            int[] leftArr = nums.Take(midIndex).ToArray();
            int[] rightArr = nums.Skip(midIndex + 1).ToArray();

            Node node = new Node(nums[midIndex]);
            node.left = SortedArrayToBST(leftArr);
            node.right = SortedArrayToBST(rightArr);

            return node;
        }
    }
}
