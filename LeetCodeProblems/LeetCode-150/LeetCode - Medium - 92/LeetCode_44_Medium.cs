namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_44_Medium
    {
        public static void CanJump()
        {
            ////Case - 1
            // int[] nums = { 2, 3, 1, 1, 4 };
            //bool expOut = true;

            ////Case - 2
            //int[] nums = { 3, 2, 1, 0, 4 };
            //bool expOut = false;

            //CASE - 3
            // int[] nums = {0};
            //bool expOut = true;

            //Case - 4
            //int[] nums = { 1,2 };
            //bool expOut = true;

            //Case - 5
            int[] nums = { 1,1,1,0 };
            //bool expOut = true;

            //Case - 6


            var actualOutput = CanJump(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }
        
        //SOLUTION from MOST VOTED SOLUTIONS posted on leetcode
        public static bool CanJump(int[] nums)
        {
            int finishIndex = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= finishIndex)
                {
                    if (i == 0) return true;
                    finishIndex = i;
                }
            }
            return false;
        }

        //NOT WORKING FOR ALL CASES - PROBLEM STATEMENT IS ALSO CONFUSING
        public static bool CanJump_1(int[] nums)
        {
            if (nums.Length < 2) return true;

            int MaxNoOfJumps = nums[0];

            for (int i = 1; i <= MaxNoOfJumps; i++)
            {
                int currentPosition = i;
                int nextJumpLength = nums[i];

                for (int step = 0; step <= nextJumpLength; step++)
                {
                    int nextPos = (currentPosition + step);

                    if (nextPos == nums.Length-1)
                        return true;
                }
            }

            return false;
        }
    }
}
