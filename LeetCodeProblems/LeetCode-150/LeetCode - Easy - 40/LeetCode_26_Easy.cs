using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal class LeetCode_26_Easy
    {

        public static void IsSymmetric()
        {
            // CASE - 1
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
            bt.root.left = new Node(2);
            bt.root.right = new Node(2);
            bt.root.left.left = new Node(3);
            bt.root.left.right = new Node(4);
            bt.root.right.left = new Node(4);
            bt.root.right.right = new Node(3);
            //bool expectedOutput = true;

            // CASE - 2  [1,2,2,2,null,2]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);
            //bt.root.right = new Node(2);
            //bt.root.left.left = new Node(2);
            //bt.root.left.right = null;
            //bt.root.right.left = new Node(2);
            //bool expectedOutput = false;


            bool actualOutput = IsSymmetric(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        //private bool IsSymmetric(TreeNode root)
        //{
        //    if (root == null) return false;

        //    List<int> leftTreeList = new();
        //    List<int> rightTreeList = new();
        //    InOrderTraversal(root.left, leftTreeList);
        //    MirrorInOrderTraversal(root.right, rightTreeList);

        //    if (leftTreeList.Count != rightTreeList.Count)
        //        return false;

        //    for (int i = 0; i < leftTreeList.Count; i++)
        //        if (leftTreeList[i] != rightTreeList[i])
        //            return false;

        //    return true;
        //}

        // Code submitted/ accepted to / by LeetCode
        private static bool IsSymmetric(Node root)
        {
            if (root == null) return true;

            return IsMirror(root.left, root.right);
        }
        private static bool IsMirror(Node node1, Node node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null) return false;

            return (node1.data == node2.data) && IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
        }

        //BELOW CODE NOT WORKING FOR 1 CASE - CASE - 2  [1,2,2,2,null,2]
        //private static bool IsSymmetric(Node root)
        //{
        //    if (root == null) return false; 

        //    List<int> leftTreeList = new ();
        //    List<int> rightTreeList = new ();
        //    InOrderTraversal(root.left, leftTreeList);
        //    MirrorInOrderTraversal(root.right, rightTreeList);

        //    if (leftTreeList.Count != rightTreeList.Count)
        //        return false;

        //    for (int i = 0; i < leftTreeList.Count; i++)
        //        if (leftTreeList[i] != rightTreeList[i]) 
        //            return false;

        //    return true;
        //}

        ////InOrder Traversal =>     lNr => left -> root Node -> right 
        //private static void InOrderTraversal (Node node, List<int> treeList)
        //{
        //    if (node == null)
        //    {
        //        treeList.Add(int.MaxValue);
        //        return;
        //    }

        //    //if (node.left != null) 
        //        InOrderTraversal(node.left, treeList);
        //    treeList.Add (node.data);
        //    //if (node.right != null) 
        //        InOrderTraversal(node.right, treeList);
        //}

        ////MirrorInOrder Traversal =>     rNl => right -> root Node -> left 
        //private static void MirrorInOrderTraversal(Node node, List<int> treeList)
        //{
        //    if (node == null)
        //    {
        //        treeList.Add(int.MaxValue);
        //        return;
        //    }

        //    //if (node.right != null)  
        //        MirrorInOrderTraversal(node.right, treeList);
        //    treeList.Add(node.data);
        //    //if (node.left != null) 
        //        MirrorInOrderTraversal(node.left, treeList);
        //}

    }
}
