namespace DSA.Trees
{
    namespace Enums
    {
        enum Tree_Options
        {
            BinaryTree = 1, BinarySearchTree, Heap, 
            EXIT = 0
        }
        enum BinaryTree_Operations
        {
            Create_Tree_1 = 1, Create_Tree_2, Create_Tree_3, Display, PreOrderTraversal, InOrderTraversal, PostOrderTraversal, LevelOrder,
            HeightOfTree,
            EXIT = 0
        }
        enum BinarySearchTree_Operations
        {
            Create_Tree_1 = 1, Create_Tree_2, Create_Tree_3, Display, PreOrderTraversal, InOrderTraversal, PostOrderTraversal, LevelOrder,
            Insert, Search, Delete, Min, Max, HeightOfTree,
            EXIT = 0
        }
        enum Heap_Operations
        {
            Create_Tree = 1, Display, Insert, Delete,
            EXIT = 0
        }
    }
}
