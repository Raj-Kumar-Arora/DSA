using DSA.Trees.Enums;

namespace DSA.Trees
{
    public class Main
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            Tree_Options selectedSubOption;
            //TODO - add option to create BinaryTree/BST/etc. based on user selection
            BinaryTree bt = new ();

            do
            {
                Console.WriteLine("\nTODO - 1. Support Create_Tree_2    2. display impl like pyramid 1999");
                Console.WriteLine("\nSupported sub-options in Tree:");
                Console.WriteLine("20. Create Tree - 1 (Level order - P Q R A B X)");
                Console.WriteLine("21. Create Tree - 2 (Level order - 70 40 80 35 50 75 89 30 37 55 82 93)");
                Console.WriteLine("22. Create Tree - 3 (Level order - A B G C D H I E J F J L K F)");
                Console.WriteLine("23. Display current Tree");
                Console.WriteLine("24. PreOrder Traversal");
                Console.WriteLine("25. InOrder Traversal");
                Console.WriteLine("26. PostOrder raversal");

                Console.WriteLine("\n29. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree:");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (Tree_Options)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(Common.Constants.STR_LINE_SEPERATOR);

                switch (selectedSubOption)
                {
                    case Tree_Options.Create_Tree_1:        bt.Create_Tree_1();     break;
                    case Tree_Options.Create_Tree_2:        bt.Create_Tree_2();     break;
                    case Tree_Options.Create_Tree_3:        bt.Create_Tree_3();     break;
                    case Tree_Options.Display:              bt.Display();    break;
                    case Tree_Options.PreOrderTraversal:    bt.PreOrder();   break;
                    case Tree_Options.InOrderTraversal:     bt.InOrder();    break;
                    case Tree_Options.PostOrderTraversal:   bt.PostOrder();  break;

                    case Tree_Options.EXIT:
                        Console.WriteLine("You selected 9. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != Tree_Options.EXIT);
        }
    }
}
