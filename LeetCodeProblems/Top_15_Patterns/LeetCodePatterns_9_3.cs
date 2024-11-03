using System.Xml.Linq;

namespace LeetCodeProblems.Top_15_Patterns
{
    // Backtracking all problems and solutions = 
    //MASTER -> https://leetcode.com/problems/permutations/solutions/18239/a-general-approach-to-backtracking-questions-in-java-subsets-permutations-combination-sum-palindrome-partioning/
    //1. https://leetcode.com/problems/subsets/


    public class LeetCodePatterns_9_3
    {
        public static void Backtracking()
        {
            ////Case - 1
            int[] nums = [1, 2, 3];

            var actualOutput = Subsets(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        private static List<List<int>> Subsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            backtrack(result, new List<int>(), nums, 0);
            return result;
        }

        private static void backtrack(List<List<int>> list, List<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, i + 1);
                tempList.Remove(tempList.Count - 1);
            }
        }

        private static IList<IList<int>> Subsets__1(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>()); // Start with an empty subset

            foreach (int num in nums)
            {
                int size = result.Count;
                for (int i = 0; i < size; i++)
                {
                    List<int> newSubset = new List<int>(result[i]);
                    newSubset.Add(num);
                    result.Add(newSubset);
                }
            }

            return result;
        }

    }
}
