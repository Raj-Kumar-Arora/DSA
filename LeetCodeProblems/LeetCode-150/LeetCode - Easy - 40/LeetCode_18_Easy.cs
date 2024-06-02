using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_18_Easy
    {
        public static void ContainsNearbyDuplicate()
        {
            //Case - 1
            int[] nums = new int[] { 1, 2, 3, 1 };
            int k = 3;
            //bool expectedOutput = true;

            //Case - 2
            //int[] nums = new int[] { 1, 0, 1, 1 };
            //int k = 1;
            ////bool expectedOutput = true;

            //Case - 3
            //int[] nums = new int[] { 1, 2, 3, 1, 2, 3 };
            //int k = 2;
            ////bool expectedOutput = false;

            bool actualOutput = ContainsNearbyDuplicate(nums, k);

            Console.WriteLine("actualOutput = " + actualOutput);

        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            //APPROACH - 2 ** OPTIMIZED USING HASHSET
            HashSet<int> set = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > k) 
                    set.Remove(nums[i - k - 1]);

                // If element could not be added to set becuase its already present 
                // at index <=k then return true 
                if (set.Add(nums[i]) == false) 
                    return true;
            }
            return false;

            //APPROACH - 2 ** OPTIMIZED USING HASHSET - NOT CHECKED BECAUSE ITS LOGIC IS HARD TO UNDERSTAND
            //HashSet<int> hashset = new();

            //int j = 0;   //for tracking/removing the kth farthest  element
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    // if the traversed element is already present
            //    // and hashset size is <= k
            //    //if (i < k && hashset.Contains(nums[i]))
            //    //if (hashset.Count <= k && hashset.Add(nums[i]) == false)
            //    //        return true;

            //    //if (hashset.Count > k)
            //    //    hashset.Remove(nums[i]);
            //}
            //return false;


            ////APPROACH - 1 *** WORKING *** BUT NOT OPTIMIZED
            //int i = 0;
            //for (i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if ((nums[i] == nums[j]) && (Math.Abs(i - j) <= k))
            //            return true;
            //    }
            //}

            //return false;
        }
    }
}
