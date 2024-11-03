/* NOT SUBMITTED to LEETCODE
 */
namespace LeetCodeProblems.Top_15_Patterns
{
    internal static class LeetCodePatterns_9_6
    {

        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        public static void CloneGraph()
        {
            //// CASE - 1
            Node start = new Node(1);
            start.neighbors.Add (new Node(2));
            start.neighbors.Add (new Node(4));

            Node node2 = start.neighbors[0];
            node2.neighbors.Add(new Node(1));
            node2.neighbors.Add(new Node(3));

            Node node4 = start.neighbors[1];
            node4.neighbors.Add(new Node(1));
            node4.neighbors.Add(new Node(3));

            Node node3 = node2.neighbors[1];
            node3.neighbors.Add(new Node(2));
            node3.neighbors.Add(new Node(4));
            //bool expectedOutput = true;

            //// CASE - 2  [1,2]

            var actualOutput = CloneGraph(start);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        //REF - https://leetcode.com/problems/clone-graph/solutions/3391984/c-easy-recursion-faster-than-97/
        private static Node CloneGraph(Node node)
        {
            Dictionary<Node, Node> d = new();
            //return CloneGraph(node);

            if (node == null) { return null; }

            if (d.ContainsKey(node)) 
            { 
                return d[node]; 
            }

            d[node] = new Node(node.val);

            foreach(Node n in node.neighbors)
            {
               // Node t = CloneGraph(n);
               // this function clonegraph is getting called in infinite loop because
               // before it return  in d.ContainsKey, it should be added to dic
               // by calling this from local function - see REF link at line # 62
                d[node].neighbors.Add(CloneGraph(n));
            }

            return d[node];
        }

        //private Node Clone(Node node)
        //{
        //    if (node == null) { return null; }

        //    if (d)
        //}

    }

}