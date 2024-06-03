using DSA.Trees;

namespace LeetCodeProblems.LeetCode_150
{
    internal class LeetCode_29_Easy
    {
        public static void AverageOfLevels()
        {
            ////// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(3);
            //    bt.root.left = new Node(9);
            //    bt.root.right = new Node(20);
            //        bt.root.right.left = new Node(15);
            //        bt.root.right.right = new Node(7);
            ////int expectedOutput = 6;

            //// CASE - 2
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(2147483647);
            bt.root.left = new Node(2147483647);
            bt.root.right = new Node(2147483647);
            var actualOutput = AverageOfLevels(bt.root);

            //Console.WriteLine("Actual Output = " + actualOutput);
        }
        private static IList<double> AverageOfLevels(Node root)
        {
            if (root == null) return null;

            Dictionary<int, List<long>> dictLevelToNodeValues = new Dictionary<int, List<long>>();
            SumOfLevels(root, 1, dictLevelToNodeValues);

            var result = new List<double>();
            foreach (var kvp in dictLevelToNodeValues)
            {
                //var lvlVal = kvp.Key;
                var lvlCnt = kvp.Value.Count;
                var lvlSum = kvp.Value.Sum();
                result.Add((double)lvlSum / lvlCnt);
            }

            return result;
        }
        private static void SumOfLevels(Node node, int level, Dictionary<int, List<long>> dictLevelToNodeValue)
        {
            if (node == null) return;

            if (dictLevelToNodeValue.TryGetValue(level, out var levelList))
            {
                levelList.Add(node.data);
            }
            else
            {
                var list = new List<long>();
                list.Add(node.data);
                dictLevelToNodeValue.Add(level, list);
            }


            SumOfLevels(node.left, level + 1, dictLevelToNodeValue);
            SumOfLevels(node.right, level + 1, dictLevelToNodeValue);
        }
    }
}
