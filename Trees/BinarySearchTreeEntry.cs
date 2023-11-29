using DSA.Trees.Enums;
using DSA.Trees;

namespace Trees
{
    public class BinarySearchTreeEntry
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            BinarySearchTree_Operations selectedSubOption;
            BinarySearchTree bst = new();

            do
            {
                Console.WriteLine("\nSupported sub-options in Binary Search Tree:");
                Console.WriteLine("1. Create Tree - 1 (Level order - A B P Q R X)");
                Console.WriteLine("2. Create Tree - 2 (Level order - 45 39 60 23 42 55 79 10 34 44 57 77 83 29 69)");
                Console.WriteLine("3. Create Tree - 3 (Level order - A B G C D H I E J F J L K F)");
                Console.WriteLine("4. Display current Tree");
                Console.WriteLine("5. PreOrder Traversal");
                Console.WriteLine("6. InOrder Traversal");
                Console.WriteLine("7. PostOrder Traversal");
                Console.WriteLine("8. LevelOrder Traversal");
                Console.WriteLine("9. Insert a new node in tree");
                Console.WriteLine("10. Searching of a node in tree");
                Console.WriteLine("11. Delete a new node from tree");
                Console.WriteLine("12. Min");
                Console.WriteLine("13. Max");
                Console.WriteLine("14. Height Of Tree");

                Console.WriteLine("\n0. EXIT !!!");

                Console.Write("\nSelect sub-option in Tree: ");

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
                    case BinarySearchTree_Operations.LevelOrder:            bst.LevelOrder();    break;
                    case BinarySearchTree_Operations.Insert:                bst.Insert();        break;
                    case BinarySearchTree_Operations.Search:                bst.Search();        break;
                    case BinarySearchTree_Operations.Delete:                bst.Delete();        break;
                    case BinarySearchTree_Operations.Min:                   bst.Min();           break;
                    case BinarySearchTree_Operations.Max:                   bst.Max();           break;
                    case BinarySearchTree_Operations.HeightOfTree:          bst.Height();        break;

                    case BinarySearchTree_Operations.EXIT:
                        Console.WriteLine("You selected 9. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
                //Console.WriteLine(Constants.STR_ENTER_KEY_TO_CONTINUE);
                //Console.ReadKey();
            } while (selectedSubOption != BinarySearchTree_Operations.EXIT);
        }
    }

}
