using DSA.Common;
using LinkedLists;

namespace DSA
{
    namespace LinkedLists
    {
        public class LinkedList
        {
            public Node? Start = null;

            #region Basic LinkedList Operations
            public void Create()
            {
                Console.Write("Enter no of nodes: ");
                int noOfNodes;
                if (int.TryParse(Console.ReadLine(), out noOfNodes) == false)
                {
                    Console.WriteLine("Please enter a valid integer no.");
                }

                while (noOfNodes > 0)
                {
                    Insert();
                    noOfNodes--;
                }
            }
            public void Display()
            {                
                Console.Write(" |  ");
                Node tmp = Start;
                while (tmp != null)
                {
                    Console.Write(tmp.data + " -> ");
                    tmp = tmp.next;
                }

                Console.WriteLine(" NULL");
                Console.WriteLine(Constants.STR_LINE_SEPERATOR);
                Console.WriteLine();
            }
            //public void Insert(int data, int refData = 0, bool? before=null)
            public void Insert ()
            {
                Console.Write("Enter value of data for new node: ");
                int data;
                if (int.TryParse(Console.ReadLine(), out data) == false)
                {
                    Console.WriteLine("Please enter a valid integer no.");
                }

                Node? tmp = Start;
                Node? prev = null;
                Node? newNode = new Node(data);

                //TODO - pending implementation
                int refData = -1; bool? before = null;
                do
                {
                    //Insert 1st node - at start 
                    if (Start == null)
                    {
                        Start = newNode;
                        break;
                    }
                    else if (tmp?.next == null)
                    {
                        tmp.next = newNode;
                        break;
                    }
                    else if (tmp.data == refData)
                    {
                        if (before == true)
                        {
                            newNode.next = tmp;
                            prev.next = newNode;
                        }
                        else if (before == false)
                        {
                            newNode.next = tmp?.next;
                            tmp.next = newNode;
                        }
                        break;
                    }
                    else
                    {
                        prev = tmp;
                        tmp = tmp?.next;
                    }
                } while (tmp != null);
            }
            public void Search()
            {
                int data;
                Console.Write("Enter value of data to search: ");
                if (int.TryParse(Console.ReadLine(), out data))
                {
                    int position = 1;

                    Console.WriteLine(Constants.STR_LINE_SEPERATOR);

                    Node? tmp = Start;
                    while (tmp != null)
                    {
                        if (tmp.data == data)
                        {
                            Console.WriteLine("\t " + data + " FOUND at position:" + position);
                            break;
                        }
                        else
                        {
                            position++;
                            tmp = tmp?.next;
                        }
                    }
                    // if reached here => data element not found
                    if (tmp == null)
                        Console.WriteLine("\t " + data + " NOT FOUND");


                    Console.WriteLine(Constants.STR_LINE_SEPERATOR);
                    Console.WriteLine();

                }
                else
                    Console.WriteLine("Please enter a valid integer no.");
            }
            public void Update()
            {
                int data;
                Console.Write("Enter value of data to update: ");
                if (int.TryParse(Console.ReadLine(), out data) == false )
                {
                    Console.WriteLine("Please enter a valid integer no.");
                }
                else
                {
                    int position = 1;

                    Console.WriteLine(Constants.STR_LINE_SEPERATOR);

                    Node? tmp = Start;
                    while (tmp != null)
                    {
                        if (tmp.data == data)
                        {
                            int newData;
                            Console.Write("Enter new value of data to update: ");
                            if (int.TryParse(Console.ReadLine(), out newData) == false)
                            {
                                Console.WriteLine("Please enter a valid integer no.");
                            }
                            else
                                tmp.data = newData;

                            break;
                        }
                        else
                        {
                            position++;
                            tmp = tmp?.next;
                        }
                    }
                    // if reached here => data element not found
                    if (tmp == null)
                        Console.WriteLine("\t " + data + " NOT FOUND");


                    Console.WriteLine(Constants.STR_LINE_SEPERATOR);
                    Console.WriteLine();
                }
            }

            public void Delete()
            {
                int data;
                Console.Write("Enter value of data to delete: ");
                if (int.TryParse(Console.ReadLine(), out data) == false)
                {
                    Console.WriteLine("Please enter a valid integer no.");
                }
                else
                {
                    Node? tmp = Start;
                    Node? prev = null;
                    while (tmp != null)
                    {
                        if (tmp.data == data)
                        {
                            //delete 1st node
                            if (tmp == Start)
                                Start = tmp.next;
                            else if (tmp.next == null) //Last Node of list
                                prev.next = null;
                            else
                                prev.next = tmp.next;
                            break;
                        }
                        else
                        {
                            prev = tmp;
                            tmp = tmp.next;
                        }
                    }

                    if (tmp == null)
                        Console.WriteLine("\t " + data + " NOT FOUND");
                }
            }
            public void Reverse()
            {
                Console.WriteLine("BEFORE reversing linkedlist...");
                this.Display();

                Node? tmp = Start;
                Node? prev = null;
                while (tmp != null)
                {
                    Node? next = tmp?.next;
                    tmp.next = prev;
                    if (next == null)
                        Start = tmp;

                    // move to next node
                    prev = tmp;
                    tmp = next;
                }

                Console.WriteLine("AFTER reversing linkedlist...");
                this.Display();
            }

            public void Sort()
            {
                Console.WriteLine("\nSupported sub-options in LinkedList Sorting:");
                Console.WriteLine("1. Sorting list by Exchanging Data");
                Console.WriteLine("2. Sorting list by Exchanging Links");
                Console.WriteLine();
                Console.Write("Enter choice: ");

                int selectedSortOptionInt;
                int.TryParse(Console.ReadLine(), out selectedSortOptionInt);
                Console.WriteLine("");

                switch (selectedSortOptionInt)
                {
                    case 1:
                        Sort_ExchangeDataElements(); break;
                    case 2:
                        Sort_ExchangeLinks(); break;
                }
            }
            private void Sort_ExchangeDataElements()
            {
                for (Node?i = Start; i?.next != null; i = i.next)
                {
                    for (Node? j = i.next; j != null; j = j.next)
                    {
                        if (i.data > j.data)
                        {
                            int d = i.data;
                            i.data = j.data;
                            j.data = d;
                        }
                    }
                }
            }

            private void Sort_ExchangeLinks()
            {
                Console.WriteLine("TO BE IMPLEMENTED...");
            }
            public void Merge()
            {
                Console.WriteLine("TO BE IMPLEMENTED...");
            }
            #endregion Basic LinkedList operations

            #region GeeksForGeeks Problems
            public void MiddleOfList()
            {
                Console.WriteLine("Creating reference linkedlist");
                this.Create();
                this.Display();

                if (Start == null)
                    Console.WriteLine("LinkedList is empty");
                Node tmp = Start; int length = 0;
                while (tmp != null)
                {
                    length++;
                    tmp = tmp.next;
                }

                tmp = Start; int index = 0;
                while (tmp != null && index < length / 2)
                {
                    index++;
                    tmp = tmp.next;
                }
                if (index == length / 2)
                    Console.WriteLine("Value of Middle element of linkedlist: " + tmp.data + "  index: " + (index + 1));
            }

            public void CheckIfCircularList()
            {
                Node tmp = Start;
                while (tmp != null)
                {
                    if (tmp.next == Start)
                    {
                        Console.WriteLine("List is circular"); break;
                    }
                    tmp = tmp.next;
                }
                if (tmp == null)
                    Console.WriteLine("List is NOT circular");
            }

            #endregion  GeeksForGeeks Problems
        }
    }
}

