using DSA.Trees.Enums;
using DSA.Trees;

namespace Trees
{
    public class HeapEntry
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            HeapOperations selectedSubOption;
            Heap heap = new();

            do
            {
                Console.WriteLine("\nSupported sub-options in Binary Search Tree:");
                Console.WriteLine("1. Create Tree");
                Console.WriteLine("2. Display current Tree");
                Console.WriteLine("3. Insert a new node in tree");
                Console.WriteLine("4. Delete a new node from tree");

                Console.WriteLine("\n0. EXIT !!!");

                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (HeapOperations)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                switch (selectedSubOption)
                {
                    case HeapOperations.Create_Tree:           heap.Create_Tree();   break;
                    case HeapOperations.Display:               heap.Display();       break;
                    case HeapOperations.Insert:                heap.Insert();        break;
                    case HeapOperations.Delete:                heap.Delete();        break;

                    case HeapOperations.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
                //Console.WriteLine(Constants.STR_ENTER_KEY_TO_CONTINUE);
                //Console.ReadKey();
            } while (selectedSubOption != HeapOperations.EXIT);
        }
    }

}
