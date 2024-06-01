using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode_150
{
    internal static class LeetCode_04_Easy
    {
        public static void Test()
        {
            ////Case - 1
            //int[] nums = new int[] { 3,2,3 };

            ////Case - 2
            //int[] nums = new int[] { 2,2,1,1,1,2,2 };

            ////CASE - 3
            //int[] nums = new int[] { 2,2,1,1,1,2,1 };

            //Case - 4
            //int[] nums = new int[] { 2 };

            //Case - 5
            //int[] nums = new int[] { 10, 9, 9, 9, 10 };

            //Case - 6
            int[] nums = new int[] { 2,2,1,3,1,1,4,1,1,5,1,1,6 };

            int k = MajorityElement(nums);

            Console.WriteLine("k = " + k);
        }
        public static int MajorityElement(int[] nums)
        {
            int k1 = 1, k2 = 0;
            int i = 0, k=0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    k2++;
                    k = j;
                }
                else
                    k1++;
            }

            if (k1 >= k2) 
                return nums[i];
            else 
                return nums[k];
        }
    }
}
