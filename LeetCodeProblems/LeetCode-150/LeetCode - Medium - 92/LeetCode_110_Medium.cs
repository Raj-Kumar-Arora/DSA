using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    // Kadane's Algorithm - 2
    internal static class LeetCode_110_Medium
    {
        public static void MaxSubarraySumCircular()
        {
            ////Case - 1
            int[] nums = [10, 9, 2, 5, 3, 7, 101, 18];

            ////Case - 2
            //string s = "bb";
            //List<string> wordDict = new List<string>() { "a", "b", "bbb", "bbbb" };

            //CASE - 3

            var actualOutput = MaxSubarraySumCircular(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        private static int MaxSubarraySumCircular(int[] nums)
        {
     
            return nums.Length;

        }

    }
}
