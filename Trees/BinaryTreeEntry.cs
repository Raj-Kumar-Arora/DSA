using DSA.Trees.Enums;
using DSA.Trees;
using DSA.Common;

namespace Trees
{
    public class BinaryTreeEntry
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            BinaryTree_Operations selectedSubOption;
            BinaryTree bt = new();

            do
            {
                Console.WriteLine("\nSupported sub-options in Binary Tree:");
                Console.WriteLine("1. Create Tree - 1 (Level order - P Q R A B X)");
                Console.WriteLine("2. Create Tree - 2 (Level order - 70 40 80 35 50 75 89 30 37 55 82 93)");
                Console.WriteLine("3. Create Tree - 3 (Level order - A B G C D H I E J F J L K F)");
                Console.WriteLine("4. Display current Tree");
                Console.WriteLine("5. PreOrder Traversal");
                Console.WriteLine("6. InOrder Traversal");
                Console.WriteLine("7. PostOrder Traversal");
                Console.WriteLine("8. LevelOrder Traversal");
                Console.WriteLine("9. Height Of Tree");
                Console.WriteLine("10. Searching of a node in Tree");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (BinaryTree_Operations)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                switch (selectedSubOption)
                {
                    case BinaryTree_Operations.Create_Tree_1:           bt.Create_Tree_1(); break;
                    case BinaryTree_Operations.Create_Tree_2:           bt.Create_Tree_2(); break;
                    case BinaryTree_Operations.Create_Tree_3:           bt.Create_Tree_3(); break;
                    case BinaryTree_Operations.Display:                 bt.Display();       break;
                    case BinaryTree_Operations.PreOrderTraversal:       bt.PreOrder();      break;
                    case BinaryTree_Operations.InOrderTraversal:        bt.InOrder();       break;
                    case BinaryTree_Operations.PostOrderTraversal:      bt.PostOrder();     break;
                    case BinaryTree_Operations.LevelOrder:              bt.LevelOrder();    break;
                    case BinaryTree_Operations.HeightOfTree:            bt.Height();        break;

                    case BinaryTree_Operations.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
                //Console.WriteLine(Constants.STR_ENTER_KEY_TO_CONTINUE);
                //Console.ReadKey();
            } while (selectedSubOption != BinaryTree_Operations.EXIT);
        }
    }

}
