// See https://aka.ms/new-console-template for more information
using DSA.Common;
using DSA.Enums;

//TODO - make a new version of this project => web api project with swagger support

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Constants.STR_LINE_SEPERATOR);
        Console.WriteLine("\t*** Demo of all DSA features ***");
        Console.WriteLine(Constants.STR_LINE_SEPERATOR);
        DSA_Options selectedOption;
        int selectedOptionInt;

        do
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. LinkedList (Singly LL, Doubly LL, Circular LL)");
            Console.WriteLine("2. Arrays");
            Console.WriteLine("3. Strings");
            Console.WriteLine("4. Stacks");
            Console.WriteLine("5. Queues");
            Console.WriteLine("6. Trees (Binary Tree, Binary Search Tree, Heap)");
            Console.WriteLine("7. Graphs");
            Console.WriteLine("0. EXIT !!!");
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
                    case DSA_Options.Linkedlists:   DSA.LinkedLists.Main.Start();   break;
                    case DSA_Options.Arrays:        DSA.Arrays.Main.Start();        break;
                    case DSA_Options.Strings:       DSA.Strings.Main.Start();       break;
                    case DSA_Options.Stacks:        DSA.Stacks.Main.Start();        break;
                    case DSA_Options.Queues:        DSA.Queues.Main.Start();        break;
                    case DSA_Options.Trees:         DSA.Trees.Main.Start();         break;
                    case DSA_Options.Graphs:        DSA.Graphs.Main.Start();        break;
                        //Console.WriteLine("Selected option: " + selectedOption.ToString() + "\t is not yet implemented!\n");
                    case DSA_Options.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            }
            //Console.WriteLine(Constants.STR_ENTER_KEY_TO_CONTINUE);
            //Console.ReadKey();
        } while (selectedOption != DSA_Options.EXIT);
    }
}