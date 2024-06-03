namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_32_Easy
    {
        public static void SearchInsert()
        {
            ////CASE - 1 
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //int target = 5;
            ////int expectedOutput = 2;

            //CASE - 2 
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 2;
            //int expectedOutput = 1;

            ////CASE - 3 
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //int target = 7;
            ////int expectedOutput = 4;

            int actualOutput = SearchInsert(nums, target);
            Console.WriteLine(" Actual Output : " + actualOutput);

        }
        private static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
                else if (nums[i] < target) continue;
                else if (nums[i] > target)
                {
                    if (i == 0 || nums[i - 1] < target)
                        return i;
                }
            }
            //target not found in array and its higher than last element 
            //insert at end of array
            // if (i == nums.Length)   
            return i;
        }
    }
}
