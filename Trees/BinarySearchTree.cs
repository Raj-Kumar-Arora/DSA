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

                Console.WriteLine(Common.Constants.STR_TO_BE_IMPLEMENTED);
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

