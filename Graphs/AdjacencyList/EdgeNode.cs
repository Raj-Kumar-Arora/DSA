using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.AdjacencyList
{
    class EdgeNode
    {
        public VertexNode? EndVertex { get; set; }
        public EdgeNode? NextEdge { get; set; }

        public EdgeNode(VertexNode vertex)
        {
            EndVertex = vertex;
        }
    }
}
