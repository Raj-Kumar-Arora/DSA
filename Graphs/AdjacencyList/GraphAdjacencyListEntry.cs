using DSA.Graphs.Enums;
using Graphs.AdjacencyList;

namespace Graphs.DirectedGraphAdjacencyList
{
    internal class GraphAdjacencyListEntry
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            DirectedGraphAdjListOperations selectedSubOption;

            //TODO - add option to create LinkedList/Circular LL/DoublyLL based on user selection
            LinkedDigraph graph = new();

            do
            {
                Console.WriteLine("\nSupported sub-options in Graph:");
                Console.WriteLine("1. Display Graph Info (Adjacency List)");
                Console.WriteLine("2. Insert a Vertex");
                Console.WriteLine("3. Delete a Vertex");
                Console.WriteLine("4. Insert an Edge");
                Console.WriteLine("5. Delete an Edge");
                Console.WriteLine("6. Display Indegree and OutDegree of a vertex");
                Console.WriteLine("7. Check if edge exists between two vertices");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (DirectedGraphAdjListOperations)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOption)
                {
                    case DirectedGraphAdjListOperations.DisplayAdjList:             graph.DisplayGraphInfo();           break;
                    case DirectedGraphAdjListOperations.InsertVertex:               graph.InsertVertex();               break;
                    case DirectedGraphAdjListOperations.DeleteVertex:               graph.DeleteVertex();               break;
                    case DirectedGraphAdjListOperations.InsertEdge:                 graph.InsertEdge();                 break;
                    case DirectedGraphAdjListOperations.DeleteEdge:                 graph.DeleteEdge();                 break;
                    case DirectedGraphAdjListOperations.DisplayIndegreeOutDegree:   graph.DisplayIndegreeOutDegree();   break;
                    case DirectedGraphAdjListOperations.CheckIfEdgeExists:          graph.EdgeExists();                 break;

                    case DirectedGraphAdjListOperations.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != DirectedGraphAdjListOperations.EXIT);
        }
    }
}
