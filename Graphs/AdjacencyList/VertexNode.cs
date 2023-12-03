namespace Graphs.AdjacencyList
{
    class VertexNode
    {
        public string Name { get; set; }
        public VertexNode? NextVertex { get; set; }
        public EdgeNode? FirstEdge { get; set; }
        public VertexNode(string name) 
        { 
            Name = name;
        }
    }
}
