using DSA.Common;
using DSA.LinkedLists.Enums;


//TODO - make a new version of this project => web api project with swagger support
namespace DSA.LinkedLists
{
    public class Main
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            LinkedListOptions selectedSubOption;

            //TODO - add option to create LinkedList/Circular LL/DoublyLL based on user selection
            LinkedList ll = new ();

            do
            {
                Console.WriteLine("\nSupported sub-options in LinkedList:");
                Console.WriteLine("1. Create list");
                Console.WriteLine("2. Display list");
                Console.WriteLine("3. Insert Node (At start/end/specific position/before or afer specific node)");
                Console.WriteLine("4. Search for an element");
                Console.WriteLine("5. Update a node value");
                Console.WriteLine("6. Delete a node ");
                Console.WriteLine("7. Reverse list");
                Console.WriteLine("8. Sorting list (Exchanging Data/Links)");
                Console.WriteLine("9. Merging 2 lists in 1 list");

                Console.WriteLine("\nGeeksForGeeks problems:");
                Console.WriteLine("11. Middle of list");
                Console.WriteLine("12. Check if List is circular");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in LinkedList: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (LinkedListOptions)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(Constants.STR_LINE_SEPERATOR);

                switch (selectedSubOption)
                {
                    case LinkedListOptions.Create:             ll.Create();        break;
                    case LinkedListOptions.Display:            ll.Display();       break;
                    case LinkedListOptions.Insert:             ll.Insert();        break;
                    case LinkedListOptions.Search:             ll.Search();        break;
                    case LinkedListOptions.Update:             ll.Update();        break;
                    case LinkedListOptions.Delete:             ll.Delete();        break;
                    case LinkedListOptions.Reverse:            ll.Reverse();       break;
                    case LinkedListOptions.Sort:               ll.Sort();          break;
                    case LinkedListOptions.Merge:              ll.Merge();         break;
                    case LinkedListOptions.GeeksForGeeks0:     ll.MiddleOfList();  break;
                    case LinkedListOptions.GeeksForGeeks1:     ll.CheckIfCircularList(); break;
                    case LinkedListOptions.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
                //Console.WriteLine(Constants.STR_ENTER_KEY_TO_CONTINUE);
                //Console.ReadKey();
            } while (selectedSubOption != LinkedListOptions.EXIT);
        }

    }
}

