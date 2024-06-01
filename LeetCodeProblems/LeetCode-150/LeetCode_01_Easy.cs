using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode_150
{
    internal static class LeetCode_01_Easy
    {
        public static void Test()
        {
            ////Case - 1
            //int m = 3, n = 3;
            //int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = new int[] { 2, 5, 6 };

            ////Case - 2
            //int m = 1, n = 0;
            //int[] nums1 = new int[] { 1};
            //int[] nums2 = new int[] {};

            ////Case - 3
            int m = 0, n = 1;
            int[] nums1 = new int[] { 0 };
            int[] nums2 = new int[] { 1 };

            Merge(nums1, m, nums2, n);
            for (int i = 0; i < nums1.Length; i++)
                Console.WriteLine(" " + nums1[i]);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] l = new int[m + n];
            //int i = 0, j = 0, k = 0;
            int i,j,k = 0;
            i = j = k = 0;

            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    l[k++] = nums1[i++];
                }
                else
                {
                    l[k++] = nums2[j++];
                }
            };

            // if 1st array traversed but 2nd still not completely traversed
            if (i == m)
            {
                while (j < n)
                {
                    l[k++] = nums2[j++];
                }
            }
            if (j == n)
            {
                while (i < m)
                    l[k++] = nums1[i++];
            }

            //copy array l to nums1
            for(int index=0; index < m+n; index++) 
            {
                nums1[index] = l[index];
            }
        }
    }
}
