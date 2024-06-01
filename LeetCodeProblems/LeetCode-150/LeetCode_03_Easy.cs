using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode_150
{
    internal static class LeetCode_03_Easy
    {
        public static void Test()
        {
            ////Case - 1
            //int[] nums = new int[] { 1, 1, 2 };

            ////Case - 2
            //int[] nums = new int[] { 0,0,1,1,1,2,2,3,3,4 };

            ////CASE - 3
            //int[] nums = new int[] { };

            //Case - 4
            //int[] nums = new int[] { 2 };

            //Case - 5
            int[] nums = new int[] { 2, 2 };

            int k = RemoveDuplicates(nums);

            Console.WriteLine("k = " + k);
            for (int i = 0; i < k; i++)
                Console.WriteLine(" " + nums[i]);
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int[] l = new int[nums.Length];
            int k = 0;
            if (nums.Length == 0) { return 0; }
            if (nums.Length == 1) { return 1; }

            l[k++] = nums[0];
            for (int j = 1; j < nums.Length; j++)
            {
                if (l[k - 1] != nums[j])
                    l[k++] = nums[j];
            }

            for (int j = 0; j < k; j++)
                nums[j] = l[j];

            return k;
        }
    }
}
