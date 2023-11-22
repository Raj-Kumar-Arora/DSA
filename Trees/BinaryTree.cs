using DSA.Common;

namespace DSA
{
    namespace Trees
    {
        public class BinaryTree
        {
            public Node? Root = null;

            #region Basic Binary Tree Operations
            public void Create_Tree_1()  //Level order - P Q R A B X
            {
                Root = new Node('P');
                Root.lChild = new Node('Q');
                Root.rChild = new Node('R');
                Root.lChild.lChild = new Node('A');
                Root.lChild.rChild = new Node('B');
                Root.rChild.lChild = new Node('X');
            }
            public void Create_Tree_2()
            {
                Root = new Node('P');
                Root.lChild = new Node('Q');
                Root.rChild = new Node('R');
                Root.lChild.lChild = new Node('A');
                Root.lChild.rChild = new Node('B');
                Root.rChild.lChild = new Node('X');
            }
            public void Create_Tree_3()  //Level order - A B G C D H I E J F J L K F
            {
                Root = new Node('A');
                Root.lChild = new Node('B');
                Root.rChild = new Node('G');
                
                Root.lChild.lChild = new Node('C');
                Root.lChild.lChild.lChild = new Node('E');

                Root.lChild.rChild = new Node('D');
                Root.lChild.rChild.lChild = new Node('J');
                Root.lChild.rChild.rChild = new Node('F');


                Root.rChild.lChild = new Node('H');
                Root.rChild.lChild.lChild = new Node('J');

                Root.rChild.rChild = new Node('I');
                Root.rChild.rChild.lChild = new Node('L');
                Root.rChild.rChild.rChild = new Node('K');

                Root.rChild.rChild.rChild.rChild = new Node('F');
            }
            public void Display_NEW ()
            {
                Display_NEW(Root, 0);
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
                Display(Root, 0);
                Console.WriteLine();
            }
            private void Display(Node? t, int level)
            {
                //Console.Write(" |  ");
                int i;
                if (t == null)  
                    return; 

                Display(t.rChild, level + 1);
                Console.WriteLine();

                for (i = 0; i < level; i++)
                {
                    Console.Write("\t");
                }
                Console.Write(t.data);

                Display(t.lChild, level + 1);

                //Console.WriteLine(Constants.STR_LINE_SEPERATOR);
            }

            public void PreOrder ()
            {
                PreOrder(Root);
                Console.WriteLine();
            }
            private void PreOrder (Node? t)
            {
                if (t == null)
                    return;

                Console.Write("  " + t.data);
                PreOrder(t.lChild);
                PreOrder(t.rChild);
            }

            public void InOrder()
            {
                InOrder(Root);
                Console.WriteLine();
            }
            private void InOrder(Node? t)
            {
                if (t == null)
                    return;

                InOrder(t.lChild);
                Console.Write("  " + t.data);
                InOrder(t.rChild);
            }

            public void PostOrder()
            {
                PostOrder(Root);
                Console.WriteLine();
            }
            private void PostOrder(Node? t)
            {
                if (t == null)
                    return;

                PostOrder(t.lChild);
                PostOrder(t.rChild);
                Console.Write("  " + t.data);
            }
            #endregion Basic Binary Tree operations
        }
    }
}

