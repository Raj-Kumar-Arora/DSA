using DSA.Trees;
using DSA.Trees.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public static class Tree_LeetCodeProblems
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;

            do
            {
                Console.WriteLine("\nSupported sub-options in Tree:");
                Console.WriteLine("1. MaxDepth");
                Console.WriteLine("2. IsSameTree");
                Console.WriteLine("3. InvertTree");
                Console.WriteLine("4. IsSymmetric");
                Console.WriteLine("5. PathSum");
                Console.WriteLine("6. CountNodes");
                Console.WriteLine("7. AverageOfLevels");
                Console.WriteLine("8. GetMinimumDifference");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                Console.WriteLine("Selected sub-option: " + selectedSubOptionInt.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOptionInt)
                {
                    case 1: Tree_LeetCodeProblems.MaxDepth(); break;
                    case 2: Tree_LeetCodeProblems.IsSameTree(); break;
                    case 3: Tree_LeetCodeProblems.InvertTree(); break;
                    case 4: Tree_LeetCodeProblems.IsSymmetric(); break;
                    case 5: Tree_LeetCodeProblems.HasPathSum(); break;
                    case 6: Tree_LeetCodeProblems.CountNodes(); break;
                    case 7: Tree_LeetCodeProblems.AverageOfLevels(); break;
                    case 8: Tree_LeetCodeProblems.GetMinimumDifference(); break;


                    case 0:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOptionInt != 0);
        }

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
            for (int i = 0; i < sortedList.Count-1; i++)
            {
                for (int j = i+1; j<sortedList.Count; j++)
                {
                    int tmpDiff = Math.Abs(sortedList[i] - sortedList[j]);
                    if ( tmpDiff < minDiff)
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
        private static void AverageOfLevels()
        {
            ////// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(3);
            //    bt.root.left = new Node(9);
            //    bt.root.right = new Node(20);
            //        bt.root.right.left = new Node(15);
            //        bt.root.right.right = new Node(7);
            ////int expectedOutput = 6;

            //// CASE - 2
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(2147483647);
                bt.root.left = new Node(2147483647);
                bt.root.right = new Node(2147483647);
            var actualOutput = AverageOfLevels(bt.root);

            //Console.WriteLine("Actual Output = " + actualOutput);
        }
        public static IList<double> AverageOfLevels(Node root)
        {
            if (root == null) return null;

            Dictionary<int, List<long>> dictLevelToNodeValues = new Dictionary<int, List<long>>();
            SumOfLevels(root, 1, dictLevelToNodeValues);

            var result = new List<double>();
            foreach (var kvp in dictLevelToNodeValues)
            {
                //var lvlVal = kvp.Key;
                var lvlCnt = kvp.Value.Count;
                var lvlSum = kvp.Value.Sum();              
                result.Add((double)lvlSum/lvlCnt);
            }

            return result;
        }
        private static void SumOfLevels(Node node, int level, Dictionary<int, List<long>> dictLevelToNodeValue)
        {
            if (node == null) return;

            if (dictLevelToNodeValue.TryGetValue(level, out var levelList))
            {
                levelList.Add(node.data);
            }
            else
            {
                var list = new List<long>();
                list.Add(node.data);
                dictLevelToNodeValue.Add(level, list);
            }


            SumOfLevels(node.left, level + 1, dictLevelToNodeValue);
            SumOfLevels(node.right, level + 1, dictLevelToNodeValue);
        }
        private static void CountNodes()
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

        private static void HasPathSum()
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
        public static bool HasPathSum(Node root, int targetSum)
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

            return (node1.data  == node2.data) && IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
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


        public static void InvertTree()
        {
            // CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(10);
            //bt.root.left = new Node(11);
            //bt.root.right = new Node(12);
            //bt.root.left.left = new Node(13);
            //bt.root.left.right = new Node(14);
            //bt.root.right.left = new Node(15);
            //bt.root.right.right = new Node(16);

            //// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);

            // CASE - 3
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(2);
            bt.root.left = new Node(3);
            bt.root.right = null;
            bt.root.left.left = new Node(1);


            Console.WriteLine("Tree BEFORE Invert : " );
            bt.Display();

            var newRoot = InvertTree(bt.root);
            bt.root = newRoot;
            Console.WriteLine("Tree AFTER Invert : ");
            bt.Display();
        }
        // Code submitted/ accepted to / by LeetCode
        //private static TreeNode InvertTree(TreeNode root)
        //{
            //if (root == null)
            //    return null;

            //InvertTree(root.left);
            //InvertTree(root.right);

            ////Swap the nodes
            //TreeNode tmp = root.left;
            //root.left = root.right;
            //root.right = tmp;

            //return root;
        //}


        private static Node InvertTree(Node root)
        {
            if (root == null)
                return null;

            InvertTree(root.left);
            InvertTree(root.right);

            //Swap the nodes
            Node tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            return root;
        }
        //ALL CASES NOT WORKING - so taking most voted soln from leetcode 

        //private static Node InvertTree(Node root)
        //{
        //    if (root == null)
        //        return null;

        //    Queue<Node> queue = new ();
        //    queue.Enqueue(root);
        //    List<Node> invertedTree = new (); 

        //    //We will do Level Traversal for tree with swapping of left <-> right to invert tree
        //    while (queue.Count > 0)
        //    {
        //        Node node = queue.Dequeue();
        //        if (node != null)
        //        {
        //            invertedTree.Add(new Node (node.data));
        //            queue.Enqueue(node.right);
        //            queue.Enqueue(node.left);
        //        }
        //        else
        //        {
        //            invertedTree.Add(null);
        //        }
        //    }

        //    //now we need to create tree from invertedTree list by assigning left/right childs
        //    for (int i = 1; i < invertedTree.Count; i++)
        //    {
        //        //index of parent node to which current node will be assigned as left/right
        //        int parentNodeIndex = (i - 1) / 2;
        //        bool isLeftChild = (i % 2 == 1);  //if it will be left/right child of binary tree?
        //        if (invertedTree[parentNodeIndex] != null)
        //        {
        //            if (isLeftChild)
        //                invertedTree[parentNodeIndex].left = invertedTree[i];
        //            else
        //                invertedTree[parentNodeIndex].right = invertedTree[i];
        //        }
        //    }
        //    return invertedTree[0];
        //}
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
            if (p == null ||  q == null) return false;

            if (p.data != q.data) return false;

            if (IsSameTree(p.left, q.left) == false)
                return false;

            if (IsSameTree(p.right, q.right) == false)
                return false;

            return true;
        }


        //Similar to BinaryTree.cs - Height()
        public static void MaxDepth ()
        {
            //CASE - 1
            BinaryTree bt = new BinaryTree()
            {
                root = new Node()
                {
                    data = 3,
                    left = new Node() { data = 9 },
                    right = new Node() { data = 20,
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
