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
            DisplayAdjMatrix = 1, InsertVertex, InsertEdge, DeleteEdge, DisplayIndegreeOutDegree, CheckIfEdgeExists,
            EXIT = 0
        }
        enum DirectedGraphAdjListOperations
        {
            DisplayAdjList = 1, InsertVertex, DeleteVertex, InsertEdge, DeleteEdge, DisplayIndegreeOutDegree, CheckIfEdgeExists,
            EXIT = 0
        }
    }
}
