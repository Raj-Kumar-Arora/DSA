// See https://aka.ms/new-console-template for more information
using DSA.Common;
using DSA.Common.Enums;
using DSA.LinkedLists;


//TODO - make a new version of this project => web api project with swagger support

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Constants.LINE_SEPERATOR);
        Console.WriteLine("\t*** Demo of all DSA features ***");
        Console.WriteLine(Constants.LINE_SEPERATOR);
        DSA_Options selectedOption;
        int selectedOptionInt;

        do
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. LinkedList");
            Console.WriteLine("2. Arrays");
            Console.WriteLine("3. Strings");
            Console.WriteLine("4. Stacks");
            Console.WriteLine("5. Queues");
            Console.WriteLine("6. Trees");
            Console.WriteLine("7. Graphs");
            Console.WriteLine("9. EXIT !!!");
            if (int.TryParse(Console.ReadLine(), out selectedOptionInt) == false)
            {
                Console.WriteLine("!!! Wrong input selection !!!\n");
            }

            //Code go thru for valid user input
            {
                Console.Clear();

                selectedOption = (DSA_Options)selectedOptionInt;
                Console.WriteLine("Selected option: " + selectedOption.ToString());

                switch (selectedOption)
                {
                    case DSA_Options.Linkedlist:
                        SingleLinkedListDemo();
                        break;
                    case DSA_Options.Arrays: //break;
                    case DSA_Options.Strings: //break;
                    case DSA_Options.Stacks: //break;
                    case DSA_Options.Queues: //break;
                    case DSA_Options.Trees: //break;
                    case DSA_Options.Graphs: //break;
                        Console.WriteLine("Selected option: " + selectedOption.ToString() + "\t is not yet implemented!\n") ;
                        break;
                    case DSA_Options.EXIT:
                        Console.WriteLine("You selected 9. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            }
        } while (selectedOption != DSA_Options.EXIT);
    }

    private static void SingleLinkedListDemo()
    {
        int selectedSubOptionInt = -1;
        LinkedList_Options selectedSubOption;
        LinkedList ll = new LinkedList();

        do
        {
            Console.WriteLine("\nSupported sub-options in LinkedList:");
            Console.WriteLine("10. Create list");
            Console.WriteLine("11. Display list");
            Console.WriteLine("12. Insert Node (At start/end/specific position/before or afer specific node)");
            Console.WriteLine("13. Search for an element");
            Console.WriteLine("14. Update a node value");
            Console.WriteLine("15. Delete a node ");
            Console.WriteLine("16. Reverse list");
            Console.WriteLine("17. Sorting list (Exchanging Data/Links)");
            Console.WriteLine("18. Merging 2 lists in 1 list");

            Console.WriteLine("\nGeeksForGeeks problems:");
            Console.WriteLine("110. Middle of list");
            Console.WriteLine("111. Check if List is circular");

            Console.WriteLine("\n19. EXIT !!!");
            Console.Write("\nSelect sub-option in LinkedList:");

            int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
            Console.WriteLine("");

            selectedSubOption = (LinkedList_Options)selectedSubOptionInt;
            Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
            Console.WriteLine(Constants.LINE_SEPERATOR);
            int data;

            switch (selectedSubOption)
            {
                case LinkedList_Options.Create:     ll.Create();    break;
                case LinkedList_Options.Display:    ll.Display();   break;
                case LinkedList_Options.Insert:     ll.Insert();    break;
                case LinkedList_Options.Search:     ll.Search();    break;
                case LinkedList_Options.Update:     ll.Update();    break;
                case LinkedList_Options.Delete:     ll.Delete();    break;
                case LinkedList_Options.Reverse:    ll.Reverse();   break;
                case LinkedList_Options.Sort:       ll.Sort();      break;
                case LinkedList_Options.Merge:      ll.Merge();     break;
                case LinkedList_Options.GeeksForGeeks0: 
                                                    ll.MiddleOfList();          break;
                case LinkedList_Options.GeeksForGeeks1:
                                                    ll.CheckIfCircularList();   break;
                case LinkedList_Options.EXIT:
                    Console.WriteLine("You selected 9. Exiting...");
                    break;
                default:
                    Console.WriteLine("!!! Wrong input selection !!!\n");
                    break;
            }
        } while (selectedSubOption != LinkedList_Options.EXIT);
    }

}