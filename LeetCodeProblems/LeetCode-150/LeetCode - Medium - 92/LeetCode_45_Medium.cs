namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_45_Medium
    {
        public static void Jump()
        {
            ////Case - 1
            // int[] nums = { 2, 3, 1, 1, 4 };
            //int expOut = 2;

            ////Case - 2
            //int[] nums = { 2, 3, 0, 1, 4 };
            //int expOut = 2;

            //CASE - 3
            // int[] nums = {0};
            //bool expOut = true;

            //Case - 4
            int[] nums = { 1,2 };
            //int expOut = 1;

            //Case - 5
            //int[] nums = { 1,1,1,0 };
            //bool expOut = true;

            //Case - 6


            var actualOutput = Jump(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }
        
        public static int Jump(int[] nums)
        {
            int n = 0;
            for (int i=1; i<nums.Length; i++)
            {
                n++;
                if (nums[i] + i >= nums.Length - 1)
                    return ++n;
            }
            return n;
        }
    }
}
