using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    //TODO - BaseGraph can implement an interface here which defines blueprint of common public operations
    abstract class BaseGraph
    {
        protected int noOfVertices;
        protected int noOfEdges;
        public int Vertices() { return noOfVertices; }
        public int Edges() { return noOfEdges; }

        //TODO - move common graph operation's entry handlers here 
    }
}
