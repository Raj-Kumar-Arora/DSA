using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_125_Medium
    {
        public static void LengthOfLIS()
        {
            ////Case - 1
            int[] nums = [10, 9, 2, 5, 3, 7, 101, 18];

            ////Case - 2
            //string s = "bb";
            //List<string> wordDict = new List<string>() { "a", "b", "bbb", "bbbb" };

            //CASE - 3

            var actualOutput = LengthOfLIS(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        //See line 90 for WORKING code

        //NOT WORKING - need to check how to fix
        //REf https://www.youtube.com/watch?v=cjWnW0hdF1Y
        private static int LengthOfLIS_2(int[] nums)
        {
            var l = nums.Length;
            if (l == 1) return 1;

            var lis = new int[l];
            Array.Fill(lis, 1);

            //List<int> lis = new List<int>();
            //for (var i = 0; i < l; i++) lis[i] = 1;

            for (int i = l-1; i>0; i--)
            {
                for (int j = i+1; i<l; i++)
                {
                    lis[i] = Math.Max(lis[i], 1 + lis[j]);
                }
            }

            return lis.Length;
        }

        //{
        //    // The max variable holds the result
        //    int max_ref = 1;

        //    // The function _lis() stores its result in max
        //    findLIS(nums, nums.Length, max_ref);

        //    // Returns max
        //    return max_ref;
        //}

        //private static int findLIS(int[] arr, int n,int max_ref)
        //{
        //    // Base case
        //    if (n == 1)
        //        return 1;

        //    // 'max_ending_here' is length of LIS ending with
        //    // arr[n-1]
        //    int res, max_ending_here = 1;

        //    // Recursively get all LIS ending with arr[0],
        //    // arr[1] ... arr[n-2]. If   arr[i-1] is smaller
        //    // than arr[n-1], and max ending with arr[n-1] needs
        //    // to be updated, then update it
        //    for (int i = 1; i < n; i++)
        //    {
        //        res = findLIS(arr, i, max_ref);
        //        if (arr[i - 1] < arr[n - 1]
        //            && res + 1 > max_ending_here)
        //            max_ending_here = res + 1;
        //    }

        //    // Compare max_ending_here with the overall max
        //    // and update the overall max if needed
        //    if (max_ref < max_ending_here)
        //        max_ref = max_ending_here;

        //    // Return length of LIS ending with arr[n-1]
        //    return max_ending_here;
        //}


        //https://leetcode.com/problems/longest-increasing-subsequence/
        private static int LengthOfLIS (int[] nums)
        {
            List<int> sub = new List<int>();
            sub.Add(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num > sub[sub.Count - 1])
                {
                    sub.Add(num);
                }
                else
                {
                    int j = BinarySearch(sub, num);
                    sub[j] = num;
                }
            }
            return sub.Count;
        }
        private static int BinarySearch(List<int> sub, int num)
        {
            int left = 0;
            int right = sub.Count - 1;
            int mid = (left + right) / 2;

            while (left < right)
            {
                mid = (left + right) / 2;
                if (sub[mid] == num)
                    return mid;
                if (sub[mid] < num)
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}
