using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_02_Easy
    {
        public static void RemoveElement()
        {
            ////Case - 1
            //int val = 2;
            //int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };

            ////Case - 2
            //int val = 3;
            //int[] nums = new int[] { 3, 2, 2, 3 };

            ////CASE - 3
            //int val = 0;
            //int[] nums = new int[] { };

            //Case - 4
            int val = 3;
            int[] nums = new int[] { 2 };

            int k = RemoveElement(nums, val);

            Console.WriteLine(" " + k);
            for (int i = 0; i < k; i++)
                Console.WriteLine(" " + nums[i]);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length <= 0) return 0;

            Array.Sort(nums);
            int si = -1, ei = -1; //to find the start and end index of val n sorted nums array
            int i = 0;

            //si = Array.FindIndex();
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val && si == -1)
                    si = i;

                if (si != -1 && nums[i] != val)
                {
                    ei = i; break;
                }
            }
            //val is not present in array
            if (si == -1)
                return nums.Length;

            //traversed complete array and val is till end 
            if (i == nums.Length)
               ei = nums.Length;
            
                    
            int k = nums.Length - (ei - si);
            // now remove the (ei + 1 - si) elements from nums array
            //while ((ei)(ei + i) < nums.Length)
            for (i= 0; (ei + i) < nums.Length; i++)
            {
                nums[si+i] = nums[ei + i];
            }
            return k;
        }
    }
}
