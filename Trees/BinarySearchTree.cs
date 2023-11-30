namespace DSA
{
    namespace Trees
    {
        public class BinarySearchTree : BinaryTree
        {
            public new void  Create_Tree_1()  //Level order - 81 66 82 65 80 88
            {
                //root = new Node(81);
                //root.left = new Node(66);
                //root.right = new Node(82);
                //root.left.left = new Node(65);
                //root.left.right = new Node(80);
                //root.right.right = new Node(88);

                root = new Node()
                {
                    data = 52,
                    left = new Node()
                    {
                        data = 40,
                        left = new Node(23, new(10), null),
                        right = new Node(48,
                                       new Node(45,
                                           new Node(42, null, new(43)),
                                           null),
                                    new(50)),
                    },
                    right = new Node(69,
                                    new Node(55, new(54), new(57)),
                                    new Node(79, new(77), new(83)))
                };
            }
            public new void Create_Tree_2()  //Level order - 
            {
                root = new Node()
                {
                    data = 45,
                    left = new Node()
                    {
                        data = 39,
                        left = new Node(23, 
                                   new(10), 
                                   new Node (34, new(29), null)),

                        right = new Node(42,
                                null,
                                new(44))
                    },
                    right = new Node()
                    {
                        data = 60,
                        left = new Node(55,
                                   null,
                                   new (57)),               
                        right = new Node(79,
                                    new Node(77, new(69), null),
                                    new(83))
                    }
                };
            }
            /*                      70        
             *             30                   84
             *      12          45        78           95
             *  9     N      38    60    72 N         86 N
             *              35 N        N 73
             *             
             *             */
            public new void Create_Tree_3()  //Level order - 
            {
                root = new Node()
                {
                    data = 70,
                    left = new Node()
                    {
                        data = 30,
                        left = new Node(12, new(9), null),
                        right = new Node(45, 
                                new Node(38, new(35), null), 
                                new(60))
                    },
                    right = new Node()
                    {
                        data = 84,
                        left = new Node(78, 
                                   new Node (72, null, new(73)),
                                   null),  
                        right = new Node(95, new(86), null)
                    }
                };
            }

            #region Basic Binary Search Tree Operations
            public void Insert ()
            {
                Console.Write("Enter value of data for new node: ");
                int data;
                if (int.TryParse(Console.ReadLine(), out data) == false)
                {
                    Console.WriteLine("Please enter a valid integer no.");
                    return;
                }

                Node? t = root, parent = null;
                while (t != null)
                {  
                    parent = t;
                    if (data < t.data) t = t.left;
                    else if (data > t.data) t = t.right;
                    else if (data == t.data)
                    {
                        Console.WriteLine("This data is already present in tree!");
                        return;
                    }
                }

                if (t == null)
                {
                    Node newNode = new Node(data);

                    if (parent == null) 
                    {
                        root = newNode;
                    }
                    else
                    {
                        if (data < parent.data)  
                            parent.left = newNode;
                        if (data > parent.data)  
                            parent.right = newNode;
                    }
                }

            }
            
            //Recursive method of search is being implemented in Delete operation
            public void Search ()
            {
                if (IsTreeEmpty() == true) return;

                Console.Write("Enter value of Node's data to search: ");
                int data;
                if (int.TryParse(Console.ReadLine(), out data) == false)
                {
                    Console.WriteLine("Please enter a valid integer no.");
                    return;
                }

                Node? t = root;
                while (t != null) 
                {
                    if (data < t.data)
                        t = t.left;
                    else if (data > t.data)
                        t = t.right;
                    else if (data == t.data)
                    {
                        Console.WriteLine("FOUND!!! Searched node is present in tree.");
                        break;
                    }
                }

                if (t == null)
                    Console.WriteLine("NOT FOUND!!!  Searched node is NOT present in tree.");
            }

            public void Delete()
            {
                if (IsTreeEmpty() == true) return;

                Console.Write("Enter value of data for node to delete: ");
                int data;
                if (int.TryParse(Console.ReadLine(), out data) == false)
                {
                    Console.WriteLine("Please enter a valid integer no.");
                    return;
                }

                Delete(root, null, data);
            }
            private void Delete (Node? t, Node? parent, int data)
            {
                if (t == null)
                {
                    Console.WriteLine("NOT FOUND!!!  Searched node is NOT present in tree.");
                    return;
                }

                if (data < t?.data)
                    Delete(t?.left, t, data);
                else if (data > t?.data)
                    Delete(t?.right, t, data);
                else if (data == t?.data)
                {
                    //Case - 1  : Node being delete is Leaf Node
                    if (t?.left == null && t?.right == null)
                    {
                        if (parent?.left?.data == data)        // Node being deleted is Left child of parent
                            parent.left = null;
                        else if (parent?.right?.data == data)  // Node being deleted is Right child of parent
                            parent.right = null;
                    }
                    //Case - 2  : Node being delete has one child
                    else if (t?.left == null || t?.right == null)
                    {
                        if (parent?.left?.data == data)        // Node being deleted is Left child of parent
                        {
                            if (t?.left != null)    parent.left = t?.left;
                            if (t?.right != null)    parent.left = t?.right;
                        }
                        else if (parent?.right?.data == data)  // Node being deleted is Right child of parent
                        {
                            if (t?.left != null) parent.right = t?.left;
                            if (t?.right != null) parent.right = t?.right;
                        }
                    }
                    //Case - 3  : Node being delete has both non-null Children
                    else if (t?.left != null && t?.right != null)
                    {
                        //STEP-1 : Find the inorder successor of node t
                        //because inorder successor gives the next value to keep BST prerequisite
                        //Remember - In BST, left<N<Right & Inorder traversal generates ascendending order values of nodes

                        //Inorder successor of Node t = left most child of right subtree of t
                        Node? t1 = t?.right, t1Parent = t;
                        while(t1?.left != null)
                        {
                            t1Parent = t1;
                            t1 = t1.left;
                        }
                        //Now t1 is inorder successor of node t which need to be deleted

                        //STEP-2 : Copy t1 data to t's data and then delete node t1
                        t.data = t1.data;
                        Delete(t1, t1Parent, t1.data);
                    }

                    //return;
                }

            }
            public void Min ()
            {
                // in BST, the left most leaft child is min
                if (IsTreeEmpty() == true) return;

                Node? t = root;
                while (t?.left != null)
                    t = t.left;

                Console.WriteLine("Min value of data : " + t?.data);
            }
            public void Max()
            {
                // in BST, the right most leaft child is min
                if (IsTreeEmpty() == true) return;

                Node? t = root;
                while (t?.right != null)
                    t = t.right;

                Console.WriteLine("Min value of data : " + t?.data);
            }
            #endregion Basic Binary Search Tree operations
        }
    }
}

