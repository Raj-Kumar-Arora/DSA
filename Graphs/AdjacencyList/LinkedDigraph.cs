using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.AdjacencyList
{
    class LinkedDigraph : BaseGraph
    {
        VertexNode? Start {  get; set; }

        internal void DisplayGraphInfo()
        {
            if (Start == null)
            {
                Console.WriteLine("Graph is empty. Add some vertices & edges to continue.");
                return;
            }
            Console.WriteLine("No of Vertices: " + Vertices());
            Console.WriteLine("No of Edges: " + Edges());

            for (VertexNode? vertex = Start; vertex != null; vertex = vertex.NextVertex)
            {
                Console.Write(vertex.Name + "->");
                for (EdgeNode? edge=vertex.FirstEdge; edge!=null; edge=edge.NextEdge)
                    Console.Write(" " + edge?.EndVertex?.Name);
                Console.WriteLine();
            }
        }
        internal void InsertVertex()
        {
            Console.Write("Enter vertex's name: ");
            InsertVertex(Console.ReadLine());
        }
        internal void DeleteVertex()
        {
            Console.Write("Enter vertex's name: ");
            DeleteVertex(Console.ReadLine());
        }
        internal void InsertEdge()
        {
            Console.Write("Enter 1st vertex's name: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd vertex's name: ");
            string s2 = Console.ReadLine();

            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Vertex name cannot be empty");
                return;
            }
            if (s1.Equals(s2))
            {
                Console.WriteLine("Invalid Edge : Start and End vertices are same");
                return;
            }

            InsertEdge(s1, s2);
        }
        internal void DeleteEdge()
        {
            Console.Write("Enter 1st vertex's name: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd vertex's name: ");
            string s2 = Console.ReadLine();

            if (String.IsNullOrEmpty(s1) || String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Vertex name cannot be empty");
                return;
            }
            if (s1.Equals(s2))
            {
                Console.WriteLine("Invalid Edge : Start and End vertices are same");
                return;
            }
            DeleteEdge(s1, s2);
        }
        internal void EdgeExists()
        {
            Console.Write("Enter 1st vertex's name: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd vertex's name: ");
            string s2 = Console.ReadLine();

            if (String.IsNullOrEmpty(s1) || String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Vertex name cannot be empty");
                return;
            }

            if (EdgeExists(s1, s2) == true)
                Console.WriteLine("Edge exists from " + s1 + " to " + s2);
            else
                Console.WriteLine("Edge not present from " + s1 + " to " + s2);

            if (EdgeExists(s2, s1) == true)
                Console.WriteLine("Edge exists from " + s2 + " to " + s1);
            else
                Console.WriteLine("Edge not present from " + s2 + " to " + s1);
        }
        internal void DisplayIndegreeOutDegree()
        {
            Console.Write("Enter vertex's name: ");
            string vertexName = Console.ReadLine();

            VertexNode vertex = FindVertex(vertexName);
            if (vertex == null)
            {
                Console.WriteLine("Vertex not present");
                return;
            }

            Console.WriteLine("OutDegree for " + vertexName + " : " + OutDegree(vertex));
            Console.WriteLine("InDegree for " + vertexName + " : " + InDegree(vertex));
        }

        private void InsertVertex(string? vertexName)
        {
            VertexNode newVertexNode = new VertexNode(vertexName);

            if (Start == null)
            {
                Start = newVertexNode;
            }
            else
            {
                VertexNode? tmp = Start;
                while (tmp.NextVertex != null)
                {
                    if (tmp.NextVertex.Name == vertexName)
                    {
                        Console.WriteLine("This vertex already exists");
                        return;
                    }
                    tmp = tmp.NextVertex;
                }
                if ((tmp?.Name == vertexName) ||
                    (tmp?.NextVertex?.Name == vertexName))
                {
                    Console.WriteLine("This vertex already exists");
                    return;
                }
                tmp.NextVertex = newVertexNode;
            }
            noOfVertices++;
        }
        private void DeleteVertex(string?  vertexName)
        {
            DeletefromEdgeLists(vertexName);
            DeletefromVertexLists(vertexName);
        }
        private void DeletefromVertexLists(string vertexName)
        {
            if (Start == null)
            {
                Console.WriteLine("No vertices to be deleted");
                return;
            }
            if (Start.Name.Equals(vertexName))
            {
                for (EdgeNode? tmp = Start.FirstEdge; tmp != null; tmp = tmp.NextEdge)
                    noOfEdges--;
                Start = Start.NextVertex;
                noOfVertices--;
            }
            else
            {
                VertexNode tmpVertex = Start;
                while (tmpVertex.NextVertex != null)
                {
                    if (tmpVertex.NextVertex.Name.Equals(vertexName))
                        break;
                    tmpVertex = tmpVertex.NextVertex;
                }
                if (tmpVertex.NextVertex == null)
                {
                    Console.WriteLine("Vertext not found");
                    return;
                }
                else
                {
                    for (EdgeNode? tmpEdge = tmpVertex.NextVertex.FirstEdge; tmpEdge != null; tmpEdge = tmpEdge.NextEdge)
                        noOfEdges--;

                    tmpVertex.NextVertex = tmpVertex.NextVertex.NextVertex;
                    noOfVertices--;
                }
            }
        }
        private void DeletefromEdgeLists(string vertexName)
        {
            for (VertexNode? tmpVertex = Start; tmpVertex != null; tmpVertex = tmpVertex?.NextVertex)
            {
                if (tmpVertex.FirstEdge == null)
                    continue;
                if (tmpVertex.FirstEdge.EndVertex.Name.Equals(vertexName))
                {
                    tmpVertex.FirstEdge = tmpVertex.FirstEdge.NextEdge;
                    noOfEdges--;
                }
                else
                {
                    EdgeNode tmpEdge = tmpVertex.FirstEdge;
                    while (tmpEdge.NextEdge != null)
                    {
                        if (tmpEdge.NextEdge.EndVertex.Name.Equals(vertexName))
                        {
                            tmpEdge.NextEdge = tmpEdge.NextEdge.NextEdge; 
                            noOfEdges--; 
                            break;
                        }
                        tmpEdge = tmpEdge.NextEdge;
                    }
                }
            }
        }
        private VertexNode? FindVertex(string vertexName)
        {
            VertexNode? tmpVertext = Start;
            while (tmpVertext != null)
            {
                if (tmpVertext.Name.Equals(vertexName))
                    return tmpVertext;
                tmpVertext = tmpVertext.NextVertex;
            }
            return null;
        }
        private void InsertEdge(string vertexName1, string vertexName2)
        {
            VertexNode? v1 = FindVertex(vertexName1);
            VertexNode? v2 = FindVertex(vertexName2);
            if (v1 == null)
            {
                Console.WriteLine("Start vertex not present, first insert vertex " + vertexName1);
                return;
            }
            if (v2 == null)
            {
                Console.WriteLine("End vertex not present, first insert vertex " + vertexName2);
                return;
            }

            EdgeNode newEdgeNode = new(v2);
            if (v1.FirstEdge == null)
            {
                v1.FirstEdge = newEdgeNode;
                noOfEdges++;
            }
            else
            {
                EdgeNode tmp = v1.FirstEdge;
                while (tmp.NextEdge != null)
                {
                    if (tmp.EndVertex.Name.Equals(vertexName2))
                    {
                        Console.WriteLine("Edge already present");
                        return;
                    }
                    tmp = tmp.NextEdge;
                }
                if (tmp.EndVertex.Name.Equals(vertexName2))
                {
                    Console.WriteLine("Edge already present");
                    return;
                }
                tmp.NextEdge = newEdgeNode;
                noOfEdges++;
            }
        }
        private void DeleteEdge(string vertexName1, string vertexName2)
        {
            VertexNode? v1 = FindVertex(vertexName1);
            if (v1 == null)
            {
                Console.WriteLine("Start vertex not present");
                return;
            }
            if (v1.FirstEdge == null)
            {
                Console.WriteLine("Edge not present");
                return;
            }

            if (v1.FirstEdge.EndVertex.Name.Equals (vertexName2))
            {
                v1.FirstEdge = v1.FirstEdge.NextEdge;
                noOfEdges--;
                return;
            }

            EdgeNode? edgeNode = v1.FirstEdge;
            while(edgeNode != null)
            {
                if (edgeNode.EndVertex.Name.Equals(vertexName2))
                {
                    edgeNode.NextEdge = edgeNode.NextEdge.NextEdge;
                    noOfEdges--;
                    return;
                }
            }
            Console.WriteLine("Edge not present");
        }
        private bool EdgeExists(string vertexName1, string vertexName2)
        {
            VertexNode? v1 = FindVertex(vertexName1);
            //VertexNode? v2 = FindVertex(vertexName2);
            EdgeNode? tmpEdge = v1?.FirstEdge;
            while (tmpEdge != null)
            {
                if (tmpEdge.EndVertex.Name.Equals(vertexName2))
                    return true;
                tmpEdge = tmpEdge?.NextEdge;
            }
            return false;
        }

        private int InDegree(VertexNode vertex)
        {
            int inDegree = 0;
            for (VertexNode? tmpVertex = Start; tmpVertex != null; tmpVertex = tmpVertex?.NextVertex)
            {
                for (EdgeNode? tmpEdge = tmpVertex?.FirstEdge; tmpEdge != null; tmpEdge = tmpEdge.NextEdge)
                    if (tmpEdge.EndVertex.Name.Equals(vertex?.Name))
                        inDegree++;
            }
            return inDegree;
        }
        private int OutDegree(VertexNode vertex)
        {
            int outDegree = 0;
            EdgeNode? tmpEdge = vertex.FirstEdge;
            while (tmpEdge != null)
            {
                tmpEdge = tmpEdge.NextEdge;
                outDegree++;
            }
            return outDegree;
        }
    }
}
