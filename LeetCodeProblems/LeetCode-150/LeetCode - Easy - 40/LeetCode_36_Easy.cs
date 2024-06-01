using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_36_Easy
    {
        public static void SingleNumber()
        {
            ////CASE - 1 
            int[] nums = new int[] { 2, 2, 1 };
            //int expectedOutput = 1;

            int actualOutput = SingleNumber(nums);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dict = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out int result))
                {
                    dict[nums[i]]++;
                }
                else
                    dict.Add(nums[i], 1);
            }
            foreach (var kvp in dict)
            {
                if (kvp.Value == 1)
                    return kvp.Key;
            }
            return -1;
        }
    }
}
