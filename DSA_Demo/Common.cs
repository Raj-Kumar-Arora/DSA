using System;

//TODO - move Enums class to SOLN LEVEL - common to all demo projects

namespace DSA.Common
{
    internal class Constants
    {
        public static readonly string LINE_SEPERATOR = "-------------------------------------------------";
    }
    namespace Enums
    {
        enum DSA_Options
        {
            Linkedlists = 1, Arrays, Strings, Stacks, Queues, Trees, Graphs, EXIT = 9
        }
        enum LinkedList_Options
        {
            Create = 10, Display, Insert, Search, Update, Delete, Reverse, Sort, Merge, 
            GeeksForGeeks0 = 110, GeeksForGeeks1 = 111,
            EXIT = 19
        }
    }
}


