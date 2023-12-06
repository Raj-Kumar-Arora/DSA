﻿using DSA.Graphs.Enums;

namespace Graphs
{
    class Vertex
    {
        public string Name {  get; set; }
        public VertexState State { get; set; }
        public Vertex(string? name)
        { this.Name = name; }
    }
}
