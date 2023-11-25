using DSA.Trees.Enums;
using DSA.Trees;
using DSA.Common;

namespace Trees
{
    public class BinarySearchTreeEntry
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            BinarySearchTree_Operations selectedSubOption;
            //TODO - add option to create BinaryTree/BST/etc. based on user selection
            BinarySearchTree bst = new();

            do
            {
                Console.WriteLine("\nSupported sub-options in Binary Search Tree:");
                Console.WriteLine("1. Create Tree - 1 (Level order - P Q R A B X)");
                Console.WriteLine("2. Create Tree - 2 (Level order - 70 40 80 35 50 75 89 30 37 55 82 93)");
                Console.WriteLine("3. Create Tree - 3 (Level order - A B G C D H I E J F J L K F)");
                Console.WriteLine("4. Display current Tree");
                Console.WriteLine("5. PreOrder Traversal");
                Console.WriteLine("6. InOrder Traversal");
                Console.WriteLine("7. PostOrder raversal");
                Console.WriteLine("8. Insert");
                Console.WriteLine("9. Search");
                Console.WriteLine("10. Min");
                Console.WriteLine("11. Max");

                Console.WriteLine("\n0. EXIT !!!");

                Console.Write("\nSelect sub-option in Tree:");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (BinarySearchTree_Operations)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                switch (selectedSubOption)
                {
                    case BinarySearchTree_Operations.Create_Tree_1:         bst.Create_Tree_1(); break;
                    case BinarySearchTree_Operations.Create_Tree_2:         bst.Create_Tree_2(); break;
                    case BinarySearchTree_Operations.Create_Tree_3:         bst.Create_Tree_3(); break;
                    case BinarySearchTree_Operations.Display:               bst.Display();       break;
                    case BinarySearchTree_Operations.PreOrderTraversal:     bst.PreOrder();      break;
                    case BinarySearchTree_Operations.InOrderTraversal:      bst.InOrder();       break;
                    case BinarySearchTree_Operations.PostOrderTraversal:    bst.PostOrder();     break;
                    case BinarySearchTree_Operations.Insert:                bst.Insert();        break;
                    case BinarySearchTree_Operations.Search:                bst.Search();        break;
                    case BinarySearchTree_Operations.Min:                   bst.Min();           break;
                    case BinarySearchTree_Operations.Max:                   bst.Max();           break;

                    case BinarySearchTree_Operations.EXIT:
                        Console.WriteLine("You selected 9. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != BinarySearchTree_Operations.EXIT);
        }
    }

}
