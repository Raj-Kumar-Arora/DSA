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
        
        //NOT WORKING
        private static int LengthOfLIS_2(int[] s)
        {
            if (s.Length <= 0)
            {
                return 0;
            }
            else if (s.Length == 1)
            {
                return 1;
            }

            int lis = 1;
            int pi = 0;   //previous index

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > s[pi])
                {
                    lis++;  //increment lis count
                    pi = i;  //update previous index
                }
            }

            return lis;
        }
        //See line 90 for WORKING code

        //WORKING - DYNAMIC APPROACH
        //Ref https://www.youtube.com/watch?v=cjWnW0hdF1Y
        private static int LengthOfLIS(int[] nums)
        {
            var l = nums.Length;
            if (l == 1) return 1;

            var lis = new int[l];
            Array.Fill(lis, 1);

            for (int i = l-1; i>0; i--)
            {
                for (int j = i+1; j<l; j++)
                {
                    if (nums[i] < nums[j])
                        lis[i] = Math.Max(lis[i], 1 + lis[j]);
                }
            }

            return lis.Max();
        }

        /**********************/
        //WORKING - BEST Approach -  - 2nd approach using BINARAY SEARCH
        //https://leetcode.com/problems/longest-increasing-subsequence/
        private static int LengthOfLIS_ (int[] nums)
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
