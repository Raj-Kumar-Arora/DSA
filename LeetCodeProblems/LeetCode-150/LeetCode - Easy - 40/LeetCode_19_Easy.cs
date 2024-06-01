using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_19_Easy
    {
        public static void SummaryRanges()
        {
            //Case - 1
            //int[] nums = new int[] { 0, 1, 2, 4, 5, 7 };
            //bool expectedOutput = "0->2","4->5","7";

            //Case - 2
            int[] nums = new int[] { 0, 2, 3, 4, 6, 8, 9 };
            //bool expectedOutput = ["0","2->4","6","8->9"];

            //Case - 3
            // int n = 7;
            // bool expectedOutput = true;

            IList<string> actualOutput = SummaryRanges(nums);

            foreach (var str in actualOutput.ToList<string>())
                Console.WriteLine("actualOutput = " + str);
        }
        public static IList<string> SummaryRanges(int[] nums)
        {
            List<string> strList = new();
            int si = 0, ei = 0;   //for start & end index of checking continuity 

            int i = 1;
            //starting traversal from 1 to compare if ith & (i-1)th element are adjacent
            for (i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    ei = i - 1;

                    if (ei == si)
                        strList.Add(nums[si].ToString());
                    else
                        strList.Add(nums[si].ToString() + "->" + nums[ei].ToString());

                    //update start & end index
                    si = i; ei = i;
                }
            }
            //Need to check explicitly for last element 
            //the below logic is same as above logic but its needed bcz above logic cannot run for last element
            // ** ALTERNATE WAY is to add a dummy element at end of nums array like - int.MaxValue **
            // ** as being done by other solutions **
            if (i == nums.Length)
            {
                ei = i - 1;
                if (ei == si)
                    strList.Add(nums[si].ToString());
                else
                    strList.Add(nums[si].ToString() + "->" + nums[ei].ToString());
            }
            return strList;

            //*** OPTIMIZATIONS **
            //List<string> strList = new();
            //int si = 0, ei = 0;   //for start & end index of checking continuity 

            //int i = 1;
            ////starting traversal from 1 to compare if ith & (i-1)th element are adjacent
            //for (i=1; i < nums.Length; i++)
            //{
            //    if ( (nums[i] != nums[i-1] + 1) || 
            //         (i == nums.Length -1))
            //    {
            //        ei = i - 1;

            //        if (ei == si)
            //            strList.Add(nums[si].ToString());
            //        else
            //            strList.Add(nums[si].ToString() + "->" + nums[ei].ToString());

            //        //update start & end index
            //        si = i; ei = i;
            //    }
            //}
            ////if (i == nums.Length)
            ////{
            ////    ei = i-1;
            ////    if (ei == si)
            ////        strList.Add(nums[si].ToString());
            ////    else
            ////        strList.Add(nums[si].ToString() + "->" + nums[ei].ToString());
            ////}
            //return strList;
        }
    }
}
