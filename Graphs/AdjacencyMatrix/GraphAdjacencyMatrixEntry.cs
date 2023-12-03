using DSA.Graphs.Enums;

namespace Graphs.DirectedGraphAdjacencyMatrix
{
    internal class GraphAdjacencyMatrixEntry
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            DirectedGraphAdjMatrixOperations selectedSubOption;

            //TODO - add option to create LinkedList/Circular LL/DoublyLL based on user selection
            DirectedGraph graph = new();

            do
            {
                Console.WriteLine("\nSupported sub-options in Graph:");
                Console.WriteLine("1. Display Graph Info (Adjacency Matrix)");
                Console.WriteLine("2. Insert a Vertex");
                Console.WriteLine("3. Insert an Edge");
                Console.WriteLine("4. Delete an Edge");
                Console.WriteLine("5. Display Indegree and OutDegree of a vertex");
                Console.WriteLine("6. Check if edge exists between two vertices");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                selectedSubOption = (DirectedGraphAdjMatrixOperations)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOption)
                {
                    case DirectedGraphAdjMatrixOperations.DisplayAdjMatrix: graph.DisplayGraphInfo(); break;
                    case DirectedGraphAdjMatrixOperations.InsertVertex: graph.InsertVertex(); break;
                    case DirectedGraphAdjMatrixOperations.InsertEdge: graph.InsertEdge(); break;
                    case DirectedGraphAdjMatrixOperations.DeleteEdge: graph.DeleteEdge(); break;
                    case DirectedGraphAdjMatrixOperations.DisplayIndegreeOutDegree: graph.DisplayIndegreeOutDegree(); break;
                    case DirectedGraphAdjMatrixOperations.CheckIfEdgeExists: graph.EdgeExists(); break;

                    case DirectedGraphAdjMatrixOperations.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != DirectedGraphAdjMatrixOperations.EXIT);
        }
    }
}
