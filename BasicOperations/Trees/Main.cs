using DSA.Trees.Enums;
using Trees;

namespace DSA.Trees
{
    public class Main
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            TreeOptions selectedSubOption;
            
            do
            {
                Console.WriteLine("\nSupported sub-options in Tree:");
                Console.WriteLine("1. Binary Tree");
                Console.WriteLine("2. Binary Search Tree");
                Console.WriteLine("3. Heap Tree");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (TreeOptions)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOption)
                {
                    case TreeOptions.BinaryTree:       BinaryTreeEntry.Start();        break;
                    case TreeOptions.BinarySearchTree: BinarySearchTreeEntry.Start();  break;
                    case TreeOptions.Heap:             HeapEntry.Start();              break;

                    case TreeOptions.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != TreeOptions.EXIT);
        }
    }
}
