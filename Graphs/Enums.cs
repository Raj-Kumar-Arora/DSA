namespace DSA.Graphs
{
    namespace Enums
    {
        enum GraphOptions
        {
            DirectedGraphUsingAdjacencyMatrix = 1, DirectedGraphUsingAdjacencyList,
            EXIT = 0
        }
        enum DirectedGraphAdjMatrixOperations
        {
            CreateGraph = 1, DisplayAdjMatrix, InsertVertex, InsertEdge, DeleteEdge, DisplayIndegreeOutDegree, CheckIfEdgeExists,
            BFSTraversal, DFSTraversal,
            EXIT = 0
        }
        enum DirectedGraphAdjListOperations
        {
            DisplayAdjList = 1, InsertVertex, DeleteVertex, InsertEdge, DeleteEdge, DisplayIndegreeOutDegree, CheckIfEdgeExists,
            BFSTraversal, DFSTraversal,
            EXIT = 0
        }
        enum VertexState
        {
            INITIAL = 1, WAITING, VISITED
        }
    }
}
