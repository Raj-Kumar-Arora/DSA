namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_56_Medium
    {
        public static void MinSubArrayLen()
        {
            ////Case - 1
            int[] nums = [2, 3, 1, 2, 4, 3];
            int target = 7;
            //var expOut = 2

            ////Case - 2

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = MinSubArrayLen(target, nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        private static int MinSubArrayLen(int target, int[] nums)
        {
            int l = nums.Length;
            int minLen = int.MaxValue;
            int sum = 0;
            int i = 0;
            for (int j=0; j < l; j++)
            {
                sum += nums[j];

                while (sum >= target)
                {
                    minLen = Math.Min(minLen, j - i +1);
                    sum -= nums[i];
                    i++;
                }
            }

            return minLen == int.MaxValue ? 0 : minLen;
        }
    }
}
