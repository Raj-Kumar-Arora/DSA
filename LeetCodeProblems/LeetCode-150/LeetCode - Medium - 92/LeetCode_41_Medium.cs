namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_41_Medium
    {
        public static void RemoveDuplicates()
        {
            ////Case - 1
            //int[] nums = { 1, 1, 1, 2, 2, 3 };

            ////Case - 2
            int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

            ////Case - 3
            //int[] nums = { 1, 1};

            ////Case - 4
            //int[] nums = { 1, 1, 1 };

            RemoveDuplicates(nums);

            Console.WriteLine("Actual Output : ");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(" " + nums[i]);
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            foreach (int j in nums)
            {
                if (i < 2 || j > nums[i-2])
                    nums[i++] = j;
            }
            return i;
        }
        public static int RemoveDuplicates_1(int[] nums)
        {
            //if (nums.Length <3)
            //{
            //    return nums.Length;
            //}

            int p = 0; //no of elements parked at end of array which need to be skipped at end

            for(int i = 0; i< nums.Length-p-1;)  //i++
            {
                int cnt = 1;
                int j = i + 1;
                for(j = i+1; j< nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    { 
                        cnt++; 
                        if (cnt >2)
                        {
                            //no method present to remove 
                            //   nums.RemoveAt(j);
                            //Array.Remove
                            //j--;

                            //Park nums[j] element to end of array
                            int tmp = nums[j];
                            for (int k = j; k< nums.Length-1; k++)
                                nums[k] = nums[k+1];

                            nums[nums.Length-1] = tmp;
                            p++;
                            //j--;
                        }
                    }
                    else
                    {
                        i = j;
                        break;
                    }
                }
                if (j == nums.Length)
                    i++;
            }
            return nums.Length-p;
        }
    }
}
