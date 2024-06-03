namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_16_Easy
    {
        public static void TwoSum()
        {
            //Case - 1
            //int[] nums = new int[] {2,7,11,15 }; int target = 9;
            //Case - 2
            int[] nums = new int[] { 1,2,5,-4,7,3 }; int target = 1;

            int[] ret = TwoSum(nums, target);

            for (int i = 0; i < ret.Length; i++)
                Console.WriteLine(" " + ret[i]);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ret[0] = i; ret[1] = j; break;
                    }
                }
            }
            return ret;
        }
    }
}
