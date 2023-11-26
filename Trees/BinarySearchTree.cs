using DSA.Common;

namespace DSA
{
    namespace Trees
    {
        public class BinarySearchTree : BinaryTree
        {
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
            public void Search ()
            {
                Console.WriteLine(Constants.STR_TO_BE_IMPLEMENTED);
            }
            public void Insert(int d)
            {
                Console.WriteLine(Constants.STR_TO_BE_IMPLEMENTED);
            }
            public void Min ()
            {
                Console.WriteLine(Constants.STR_TO_BE_IMPLEMENTED);
            }
            public void Max()
            {
                Console.WriteLine(Common.Constants.STR_TO_BE_IMPLEMENTED);
            }
            #endregion Basic Binary Search Tree operations
        }
    }
}

