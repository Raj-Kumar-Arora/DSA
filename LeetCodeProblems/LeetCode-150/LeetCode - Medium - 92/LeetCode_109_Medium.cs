using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    // Kadane's Algorithm - 1
    internal static class LeetCode_109_Medium
    {
        public static void MaxSubArray()
        {
            ////Case - 1
            int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];

            ////Case - 2

            //CASE - 3

            var actualOutput = MaxSubArray(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        // https://www.youtube.com/watch?v=w4W6yya1PIc
        //TRY OTHER leetcode solutions
        //WORKING
        private static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                max = Math.Max(sum, max);
                if (sum < 0)
                    sum = 0;
            }

            return max;
        }

        //easy to understand - but NOT WORKING
        private static int MaxSubArray_1(int[] nums)
        {
            int l = nums.Length;
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0, sum=0; j < nums.Length; j++)
                {
                    sum += nums[i];
                    max = Math.Max(sum, max);
                }
            }
            return max;
        }
    }
}
