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


    }
}
