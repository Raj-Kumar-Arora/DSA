namespace LeetCodeProblems.Top_15_Patterns
{
    // 33. Search in Rotated Sorted Array
    //https://leetcode.com/problems/search-in-rotated-sorted-array/
    public class LeetCodePatterns_9_1
    {
        public static void Search()
        {
            ////Case - 1
            //int[] nums = [4, 5, 6, 7, 0, 1, 2];
            //int target = 0;

            ////Case - 2
            //int[] nums = [1];
            //int target = 0;

            //CASE - 3
            //int[] nums = [4, 5, 6, 7, 0, 1, 2];
            //int target = 3;

            ////Case - 4
            //int[] nums = [1, 3];
            //int target = 0;

            ////Case - 5
            int[] nums = [1, 3, 5];
            int target = 2;

            var actualOutput = Search(nums, target);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }
        private static int Search(int[] nums, int target)
        {
            int si = 0, ei = 0;
            int ri = 0;
            int l = nums.Length;

            if (l == 1)
            {
                if (nums[0] == target)
                    return 0;
                else return -1;
            }


            for (int i = 0; i < l-1; i++)
            {
                if (nums[i + 1] < nums[i])
                {
                    ri = i;
                    break;
                }
            }

            if (ri == 0 && nums[l-1] > nums[0])   //array is not rotated
            {
                ei = l - 1;
            }
            else if (target >= nums[0] && target <= nums[ri])
            {
                si = 0; ei = ri;
            }
            else if (target >= nums[ri + 1] && target <= nums[l - 1])
            {
                si = ri + 1; ei = l - 1;
            }
            else
                return -1;

            return BinarySearch(si, ei, target, nums);
        }
        private static int BinarySearch(int si, int ei, int target, int[] nums)
        {
            int mi = (si + ei) / 2;
            if (target == nums[mi])
                return mi;

            if (target >= nums[si] && target <= nums[mi])
            {
                ei = mi;
            }
            else if (target >= nums[mi + 1] && target <= nums[ei])
            {
                si = mi + 1;
            }
            else 
                return -1;

            return BinarySearch(si, ei, target, nums);
        }
    }
}
