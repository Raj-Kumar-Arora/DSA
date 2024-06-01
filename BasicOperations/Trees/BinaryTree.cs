using DSA.Common;
using System.Reflection.Emit;

namespace DSA
{
    namespace Trees
    {
        public class BinaryTree
        {
            #region public properties
            public Node? root { get; set;} = null;
            #endregion public properties

            #region public methods - Basic Binary Tree Operations
            public void Create_Tree_1()  //Level order - P Q R A B X
            {
                root = new Node(10);
                root.left = new Node(11);
                root.right = new Node(12);
                root.left.left = new Node(13);
                root.left.right = new Node(14);
                root.right.left = new Node(15);
                root.right.right = new Node(16);
            }
            public void Create_Tree_2()  //Level order - 70 40 80 35 50 75 89 30 37 55 82 93
            {
                root = new Node()
                {
                    data = 70,
                    left = new Node()
                    {
                        data = 40,
                        left = new Node(35, new(30), new(37)),
                        right = new Node(50, null, new(55))
                    },
                    right = new Node()
                    {
                        data = 80,
                        left = new Node(75),
                        right = new Node(89, new(82), new(93))
                    }
                };
            }
            public void Create_Tree_3()  //Level order - A B G C D H I E J F J L K F
            {
                root = new Node('A');
                root.left = new Node('B');
                root.right = new Node('G');
                
                root.left.left = new Node('C');
                root.left.left.left = new Node('E');

                root.left.right = new Node('D');
                root.left.right.left = new Node('J');
                root.left.right.right = new Node('F');


                root.right.left = new Node('H');
                root.right.left.left = new Node('J');

                root.right.right = new Node('I');
                root.right.right.left = new Node('L');
                root.right.right.right = new Node('K');

                root.right.right.right.right = new Node('F');
            }

            public void Display()
            {
                if (IsTreeEmpty() == true) return;

                Display(root, 0);
                Console.WriteLine();
            }
            private void Display(Node? t, int level)
            {
                int i;
                if (t == null)  
                    return; 

                Display(t.right, level + 1);
                Console.WriteLine();

                for (i = 0; i < level; i++)
                {
                    Console.Write("\t");
                }
                Console.Write(t.data);

                Display(t.left, level + 1);

                //Console.WriteLine(Constants.STR_LINE_SEPERATOR);
            }

            public void PreOrder ()
            {
                Console.WriteLine("PreOrder:");
                PreOrder(root);
                Console.WriteLine();
            }
            private void PreOrder (Node? t)
            {
                if (t == null)
                    return;

                Console.Write("  " + t.data);
                PreOrder(t.left);
                PreOrder(t.right);
            }

            public void InOrder()
            {
                Console.WriteLine("InOrder:");
                InOrder(root);
                Console.WriteLine();
            }
            private void InOrder(Node? t)
            {
                if (t == null)
                    return;

                InOrder(t.left);
                Console.Write("  " + t.data);
                InOrder(t.right);
            }

            public void PostOrder()
            {
                Console.WriteLine("PostOrder:");
                PostOrder(root);
                Console.WriteLine();
            }
            private void PostOrder(Node? t)
            {
                if (t == null)
                    return;

                PostOrder(t.left);
                PostOrder(t.right);
                Console.Write("  " + t.data);
            }

            public void LevelOrder()
            {
                Console.WriteLine("Level Order:");
                Queue<Node?> qu = new();
                qu.Enqueue(root);

                while (qu.Count > 0)
                {
                    Node? t = qu.Dequeue();
                    Console.Write("   " + t.data);
                    if (t.left != null) qu.Enqueue(t.left);
                    if (t.right != null) qu.Enqueue(t.right);
                }
                Console.WriteLine();
            }

            public void Height()
            {
                if (IsTreeEmpty() == true) return;

                int h = Height(root);
                Console.WriteLine("Height of tree : " + h);
            }
            private int Height(Node? t)
            {
                //int lh, rh = 0;

                int lh = t?.left == null ? 0 : Height(t.left);
                int rh = t?.right == null ? 0 : Height(t.right);
                //if (t?.left == null) 
                //    lh = 1;
                //else lh = Height(t.left);

                //if (t?.right == null)
                //    lh = 1;
                //else lh = Height(t.right);

                return lh>rh ? (lh+1) : (rh+1);
            }

            protected bool IsTreeEmpty()
            {
                if (root == null)
                {
                    Console.WriteLine("The tree is empty.");
                    return true;
                }
                else return false;
            }

            public bool SearchNode()
            {
                Console.WriteLine("TO BE IMPLEMENTED...");
                return true;
            }
            #endregion public methods - Basic Binary Tree operations
        }
    }
}

