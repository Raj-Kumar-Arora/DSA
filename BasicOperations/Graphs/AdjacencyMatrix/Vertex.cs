using DSA.Graphs.Enums;

namespace Graphs
{
    class Vertex
    {
        public string Name {  get; set; }
        public VertexBFSTraversalState BfsState { get; set; }
        public VertexDFSTraversalState DfsState { get; set; }
        public Vertex(string? name)
        { this.Name = name; }
    }
}
