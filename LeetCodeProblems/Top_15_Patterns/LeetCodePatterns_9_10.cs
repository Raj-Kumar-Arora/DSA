using DSA.Trees;

namespace LeetCodeProblems.Top_15_Patterns
{
    //SUBMITTED - Try to solve another problem related to this - SUBSETS- https://leetcode.com/problems/subsets/description/
    public class LeetCodePatterns_9_10
    {
        public static void Permute()
        {
            ////Case - 1
            int[] nums = [1, 2, 3];
           // int[] nums = [1, 2];
            var actualOutput = Permute(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }
        //using backtracking [PREFERRED APPROACH]
        // REF - https://youtu.be/Nabbpl7y4Lo?si=M4T5OTkBka5j_jwv
        // related code ref - https://leetcode.com/problems/permutations/solutions/3850889/c-solution-for-permutations-problem/
        private static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            bool[] used = new bool[nums.Length];

            List<int> permutation = new List<int>();
            backtrack (nums, permutation, used, result);
            return result;
        }

        private static void backtrack(int[] nums, List<int> permutation, bool[] used, List<IList<int>> result)
        {
            if (permutation.Count == nums.Length) // goal is reached
            {
                result.Add(new List<int> (permutation));
                return;
            }

            for (int i = 0; i < nums.Length; i++) // in nb_choices
            {
                if (!used[i])  // valid choice
                {
                    used[i] = true;
                    //Add the choice to backtracking
                    permutation.Add(nums[i]);

                    backtrack(nums, permutation, used, result);

                    //Undo the choice to backtracking
                    used[i] = false;
                    //permutation.Remove(nums[i]);
                    permutation.RemoveAt(permutation.Count - 1);
                }
            }
        }

        //another approach
        private static IList<IList<int>> Permute_1(int[] nums)
        {
            var result = new List<IList<int>>();
            var queue = new Queue<List<int>>();
            queue.Enqueue(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                int size = queue.Count;
                for (int j = 0; j < size; j++)
                {
                    var curr = queue.Dequeue(); // get latest list
                    for (int k = 0; k <= curr.Count; k++) // add it into every single index
                    {
                        var temp = new List<int>(curr); // take a copy
                        temp.Insert(k, nums[i]); // insert at index
                        queue.Enqueue(temp);
                    }
                }
            }

            while (queue.Count > 0)
                result.Add(queue.Dequeue());

            return result;
        }
    }
}
