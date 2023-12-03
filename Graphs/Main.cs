using DSA.Graphs.Enums;
using Graphs;

namespace DSA.Graphs
{
    public class Main
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;
            DirectedGraphOperations selectedSubOption;

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

                selectedSubOption = (DirectedGraphOperations)selectedSubOptionInt;
                Console.WriteLine("Selected sub-option: " + selectedSubOption.ToString() + "\n");
                Console.WriteLine(Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOption)
                {
                    case DirectedGraphOperations.DisplayAdjMatrix:          graph.DisplayGraphInfo();           break;
                    case DirectedGraphOperations.InsertVertex:              graph.InsertVertex();               break;
                    case DirectedGraphOperations.InsertEdge:                graph.InsertEdge();                 break;
                    case DirectedGraphOperations.DeleteEdge:                graph.DeleteEdge();                 break;
                    case DirectedGraphOperations.DisplayIndegreeOutDegree:  graph.DisplayIndegreeOutDegree();   break;
                    case DirectedGraphOperations.CheckIfEdgeExists:         graph.EdgeExists();                 break;

                    case DirectedGraphOperations.EXIT:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOption != DirectedGraphOperations.EXIT);
        }
    }
}