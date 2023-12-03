using DSA.Graphs.Enums;
using Graphs;
using Graphs.AdjacencyList;
using Graphs.DirectedGraph_AdjacencyMatrix;
using System.Diagnostics;

namespace DSA.Graphs
{
    public class Main
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            GraphOptions selectedSubOption;

            do
            {
                Console.WriteLine("\nSupported sub-options in Tree:");
                Console.WriteLine("1. Directed Graph (Adjacency Matrix)");
                Console.WriteLine("2. Directed Graph (Adjacency List)");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (GraphOptions)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOption)
                {
                    case GraphOptions.DirectedGraphUsingAdjacencyMatrix: GraphAdjacencyMatrixEntry.Start(); break;
                    case GraphOptions.DirectedGraphUsingAdjacencyList:   GraphAdjacencyListEntry.Start();   break;

                    case GraphOptions.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != GraphOptions.EXIT);
        }
    }
}