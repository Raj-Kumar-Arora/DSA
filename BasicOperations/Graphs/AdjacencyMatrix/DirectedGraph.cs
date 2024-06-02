
using DSA.Common;
using DSA.Graphs.Enums;
using Graphs.AdjacencyList;
using System;

namespace Graphs
{
    class DirectedGraph : BaseGraph
    {
        public static readonly int MAX_VERTICES = 30;

        bool[,] adjMatrix;
        Vertex[] vertexList; 

        public  DirectedGraph()
        {
            adjMatrix = new bool[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }
        internal void CreateGraph()
        {
            // Smaller graph for testing
            //InsertVertex("0");
            //InsertVertex("1");
            //InsertVertex("2");
            //InsertVertex("3");
            //InsertVertex("5");
            //InsertEdge("0", "1");
            //InsertEdge("0", "3");
            //InsertEdge("1", "2");
            //InsertEdge("1", "4");
            //InsertEdge("2", "5");

            InsertVertex("0");
            InsertVertex("1");
            InsertVertex("2");
            InsertVertex("3");
            InsertVertex("4");
            InsertVertex("5");
            InsertVertex("6");
            InsertVertex("7");
            InsertVertex("8");
            InsertVertex("9");

            InsertEdge("0", "1");
            InsertEdge("0", "3");
            InsertEdge("1", "2");
            InsertEdge("1", "4");
            InsertEdge("1", "5");
            InsertEdge("2", "3");
            InsertEdge("2", "5");
            InsertEdge("3", "6");
            InsertEdge("4", "5");
            InsertEdge("4", "7");
            InsertEdge("5", "6");
            InsertEdge("5", "8");
            InsertEdge("6", "8");
            InsertEdge("6", "9");
            InsertEdge("7", "8");
            InsertEdge("8", "9");
        }
        internal void DisplayGraphInfo()
        {
            DisplayAdjacencyMatrix();
            Console.WriteLine("No of Vertices: " + Vertices());
            Console.WriteLine("No of Edges: " + Edges());
            if (noOfVertices > 0)
            {
                Console.Write(" (");
                for (int i = 0; i < noOfVertices; i++)
                    Console.Write(vertexList[i].Name + " ");
                Console.WriteLine(")");
            }
        }
        internal void InsertVertex()
        {
            Console.Write("Enter vertex's name: ");
            InsertVertex(Console.ReadLine());
        }
        internal void InsertEdge()
        {
            Console.Write("Enter 1st vertex's name: ");
            Vertex v1 = new Vertex(Console.ReadLine());
            Console.Write("Enter 2nd vertex's name: ");
            Vertex v2 = new Vertex(Console.ReadLine());

            if (v1.Name.Equals(v2.Name))
            {
                Console.WriteLine("Invalid Edge : Start and End vertices are same");
                return;
            }

            InsertEdge(v1, v2);
        }
        internal void DeleteEdge()
        {
            Console.Write("Enter 1st vertex's name: ");
            Vertex v1 = new Vertex(Console.ReadLine());
            Console.Write("Enter 2nd vertex's name: ");
            Vertex v2 = new Vertex(Console.ReadLine());

            if (v1.Name.Equals(v2.Name))
            {
                Console.WriteLine("Invalid Edge : Start and End vertices are same");
                return;
            }

            DeleteEdge(v1, v2);
        }
        internal void EdgeExists()
        {
            Console.Write("Enter 1st vertex's name: ");
            Vertex v1 = new Vertex(Console.ReadLine());
            Console.Write("Enter 2nd vertex's name: ");
            Vertex v2 = new Vertex(Console.ReadLine());

            if (EdgeExists(v1, v2) == true)
                Console.WriteLine("Edge exists from " + v1.Name + " to " + v2.Name);
            else
                Console.WriteLine("Edge not present from " + v1.Name + " to " + v2.Name);

            if (EdgeExists(v2, v1) == true)
                Console.WriteLine("Edge exists from " + v2.Name + " to " + v1.Name);
            else
                Console.WriteLine("Edge not present from " + v2.Name + " to " + v1.Name);
        }
        internal void DisplayIndegreeOutDegree()
        {
            Console.Write("Enter vertex's name: ");
            Vertex vertex = new Vertex(Console.ReadLine());

            Console.WriteLine("OutDegree for " + vertex.Name + " : " + OutDegree(vertex));
            Console.WriteLine("InDegree for " + vertex.Name + " : " + InDegree(vertex));
        }
        internal void BFSTraversal()
        {
            Console.WriteLine("\nSupported sub-options in BFS Traversal:");
            Console.WriteLine("1. BFS Traversal starting from a specific vertex");
            Console.WriteLine("   (Nodes not reachable from this specific index will not be traversed");
            Console.WriteLine("2. BFS Traversal for all vertices");
            Console.Write("\nSelect sub-option: ");
            int selectedSubOptionInt = -1;
            int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
            Console.WriteLine("");

            switch (selectedSubOptionInt)
            {
                case 1:     BFSTraversalFromStartVertex();              break;
                case 2:     BFSTraversal_AllVertex();                   break;
                default:    Console.WriteLine("Select a valid option"); break;
            }
            Console.WriteLine("");
        }
        internal void DFSTraversal()
        {
            Console.WriteLine("\nSupported sub-options in BFS Traversal:");
            Console.WriteLine("1. DFS Traversal starting from a specific vertex");
            Console.WriteLine("    (Nodes not reachable from this specific index will not be traversed");
            Console.WriteLine("2. DFS Traversal for all vertices");
            Console.Write("\nSelect sub-option: ");
            int selectedSubOptionInt = -1;
            int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
            Console.WriteLine("");

            switch (selectedSubOptionInt)
            {
                case 1: DFSTraversalFromStartVertex(); break;
                case 2: DFSTraversal_AllVertex(); break;
                default: Console.WriteLine("Select a valid option"); break;
            }
            Console.WriteLine("");
        }
        private void DisplayAdjacencyMatrix()
        {
            for(int i = 0; i < noOfVertices; i++)
            {
                for (int j = 0; j < noOfVertices; j++)
                {
                    if (adjMatrix[i, j])
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        private void InsertVertex(string? name)
        {
            int vIndex = GetIndex(new Vertex(name));

            //TODO : validation 
            if (vIndex != -1)
            {
                Console.WriteLine("This vertex already exists");
                return;
            }
            vertexList[noOfVertices++] = new Vertex(name);
        }
        private int GetIndex(Vertex v)
        {
            for (int i = 0; i<noOfVertices; i++)
            {
                if (v.Name.Equals(vertexList[i].Name))
                    return i;
            }
            return -1;
        }
        private bool EdgeExists (Vertex v1, Vertex v2)
        {
            return IsAdjacent(GetIndex(v1), GetIndex(v2));
        }
        private bool IsAdjacent(int v1Index, int v2Index)
        {
            return adjMatrix[v1Index, v2Index];
        }
        private void InsertEdge(string v1Name, string v2Name)
        {
            InsertEdge(new Vertex(v1Name), new Vertex(v2Name));
        }
        private void InsertEdge(Vertex v1, Vertex v2)
        {
            int v1Index = GetIndex(v1);
            int v2Index = GetIndex(v2);

            if ((v1Index == -1) || (v2Index == -1))
            {
                Console.WriteLine("Invalid vertex");
                return;
            }
            if (v1Index == v2Index)
            {
                Console.WriteLine("Not a valid edge.");
                return;
            }

            if (adjMatrix[v1Index, v2Index] == true)
                Console.WriteLine("Edge already present");
            else
            {
                adjMatrix[v1Index, v2Index] = true;
                noOfEdges++;
            }
        }
        private void DeleteEdge(Vertex v1, Vertex v2)
        {
            int v1Index = GetIndex(v1);
            int v2Index = GetIndex(v2);

            if (adjMatrix[v1Index, v2Index] == false)
                Console.WriteLine("Edge not present in the graph");
            else
            {
                adjMatrix[v1Index, v2Index] = false;
                noOfEdges--;
            }
        }
        private int OutDegree(Vertex v1)
        {
            int v1Index = GetIndex(v1);

            int outDegree = 0;
            for (int i = 0; i < noOfVertices; i++)
                if (adjMatrix[v1Index, i] == true)
                    outDegree++;

            return outDegree;
        }
        private int InDegree(Vertex v1)
        {
            int v1Index = GetIndex(v1);

            int inDegree = 0;
            for (int i = 0; i < noOfVertices; i++)
                if (adjMatrix[i, v1Index] == true)
                    inDegree++;
            return inDegree;
        }
        private void BFSTraversalFromStartVertex()
        {
            Console.Write("Enter vertex's name: ");
            string? startVertextName = Console.ReadLine();
            if (string.IsNullOrEmpty(startVertextName) || GetIndex(new Vertex(startVertextName)) == -1)
            {
                Console.WriteLine("Enter a valid vertex name");
                return;
            }
            else
            {
                //Reset vertex state to INTIAL
                for (int i = 0; i < noOfVertices; i++)
                    vertexList[i].BfsState = VertexBFSTraversalState.INITIAL;
                
                Console.Write("BFS Traversal : ");
                BFSTraversalFromSpecificVertexIndex(GetIndex(new Vertex(startVertextName)));   //TODO : find a way to reduce duplicate call for GetIndex in this method
            }
        }
        private void BFSTraversalFromSpecificVertexIndex(int startVertexIndex)
        {
            Queue<int> qu = new();
            qu.Enqueue(startVertexIndex);
            vertexList[startVertexIndex].BfsState = VertexBFSTraversalState.WAITING;

            while (qu.Count != 0)    //TODO: could this check be    qu.Count > 0  ?
            {
                startVertexIndex = qu.Dequeue();
                Console.Write(" " + vertexList[startVertexIndex].Name + " ");
                vertexList[startVertexIndex].BfsState = VertexBFSTraversalState.VISITED;

                for (int i = 0; i < noOfVertices; i++)
                {
                    if (IsAdjacent(startVertexIndex, i) && vertexList[i].BfsState == VertexBFSTraversalState.INITIAL)
                    {
                        qu.Enqueue(i);
                        vertexList[i].BfsState = VertexBFSTraversalState.WAITING;
                    }
                }
            }
            Console.WriteLine();
        }
        private void BFSTraversal_AllVertex()
        {
            Console.Write("BFS Traversal (ALL) : ");

            //Reset vertex state to INTIAL
            for (int i = 0; i < noOfVertices; i++)
                vertexList[i].BfsState = VertexBFSTraversalState.INITIAL;

            BFSTraversalFromSpecificVertexIndex(0);  //Passing 0 as default start vertex index 

            //now traverse vertices which were not reachable from default start vertex index 0
            for (int i = 0; i < noOfVertices; i++)
                if (vertexList[i].BfsState == VertexBFSTraversalState.INITIAL)
                    BFSTraversalFromSpecificVertexIndex(i);
        }
        private void DFSTraversalFromStartVertex()
        {
            Console.Write("Enter vertex's name: ");
            string? startVertextName = Console.ReadLine();
            if (string.IsNullOrEmpty(startVertextName) || GetIndex(new Vertex(startVertextName)) == -1)
            {
                Console.WriteLine("Enter a valid vertex name");
                return;
            }
            else
            {
                //Reset vertex state to INTIAL
                for (int i = 0; i < noOfVertices; i++)
                    vertexList[i].DfsState = VertexDFSTraversalState.INITIAL;

                Console.Write("DFS Traversal : ");
                DFSTraversalFromSpecificVertexIndex(GetIndex(new Vertex(startVertextName)));   //TODO : find a way to reduce duplicate call for GetIndex in this method
            }

        }
        private void DFSTraversalFromSpecificVertexIndex(int startVertexIndex)
        {
            Stack<int> st = new();
            st.Push(startVertexIndex);
            while (st.Count != 0)            //TODO: could this check be    st.Count > 0  ?
            {
                startVertexIndex = st.Pop();
                if (vertexList[startVertexIndex].DfsState == VertexDFSTraversalState.INITIAL)
                {
                    Console.Write(" " + vertexList[startVertexIndex].Name + " ");
                    vertexList[startVertexIndex].DfsState = VertexDFSTraversalState.VISITED;
                }

                for (int i = noOfVertices - 1; i >= 0 ; i--)
                {
                    if (IsAdjacent(startVertexIndex, i) && vertexList[i].DfsState == VertexDFSTraversalState.INITIAL)
                    {
                        st.Push(i);
                    }
                }
            }
            Console.WriteLine();
        }
        private void DFSTraversal_AllVertex()
        {
            Console.Write("DFS Traversal (ALL) : ");

            //Reset vertex state to INTIAL
            for (int i = 0; i < noOfVertices; i++)
                vertexList[i].DfsState = VertexDFSTraversalState.INITIAL;

            DFSTraversalFromSpecificVertexIndex(0);  //Passing 0 as default start vertex index 

            //now traverse vertices which were not reachable from default start vertex index 0
            for (int i = 0; i < noOfVertices; i++)
                if (vertexList[i].DfsState == VertexDFSTraversalState.INITIAL)
                    DFSTraversalFromSpecificVertexIndex(i);
        }
    }
}
