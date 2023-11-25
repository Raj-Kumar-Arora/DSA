using DSA.Common;

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
                root = new Node('P');
                root.left = new Node('Q');
                root.right = new Node('R');
                root.left.left = new Node('A');
                root.left.right = new Node('B');
                root.right.left = new Node('X');
            }
            public void Create_Tree_2()
            {
                root = new Node('P');
                root.left = new Node('Q');
                root.right = new Node('R');
                root.left.left = new Node('A');
                root.left.right = new Node('B');
                root.right.left = new Node('X');
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
            public void Display_NEW ()
            {
                Display_NEW(root, 0);
                Console.WriteLine();
            }
            
            //TODO - display tree like pyramid as expected in hard copies

            private void Display_NEW(Node? t, int level)
            {
                for (int i = 0; i < level; i++)
                    Console.WriteLine("  ");

            }

            public void Display()
            {
                Display(root, 0);
                Console.WriteLine();
            }
            private void Display(Node? t, int level)
            {
                //Console.Write(" |  ");
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
            #endregion public methods - Basic Binary Tree operations
        }
    }
}

