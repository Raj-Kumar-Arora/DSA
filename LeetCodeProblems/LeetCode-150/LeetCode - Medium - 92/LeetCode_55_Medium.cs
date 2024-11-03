namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_55_Medium
    {
        public static void ThreeSum()
        {
            ////Case - 1
            int[] nums = [-1, 0, 1, 2, -1, -4];
            //var expOut = [[-1,-1,2],[-1,0,1]]

            ////Case - 2

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = ThreeSum(nums);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        private static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> threeSum = new List<IList<int>>();

            Array.Sort(nums);
            int Len = nums.Length;
            for (int i = 0; i < Len - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) 
                    continue; // skipping repeated numbers to avoid repeating triples

                int j = i + 1;
                int k = Len-1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        threeSum.Add(new List<int> { nums[i], nums[j], nums[k] });

                        //as we know we are having sorted array
                        //so skip all the repited value for l from l to max index
                        while (j < k && nums[j] == nums[j + 1])
                        {
                            j++;
                        }

                        //Note:) not required if we will focus only one then autometicaly other part will be handeled
                        // //so skip all the repited value for r from max index to 0th index 
                        // while(j<j&& nums[k] == nums[j-1])
                        // {
                        //     k--;
                        // }
                        //normal flow to check any other pair is there
                        j++;
                        k--;
                    }
                    else if (sum < 0)
                        j++;
                    else
                        k--;
                }
            }

            return threeSum;
        }

        //Its working fine but not working to skip duplicates 
        private static IList<IList<int>> ThreeSum_1(int[] nums)
        {
            IList<IList<int>> threeSum = new List<IList<int>>();

            Array.Sort(nums);
            int Len = nums.Length;
            for (int i = 0; i < Len-2; i++)
            {
                for (int j = i+1; j < Len - 1; j++)
                {
                    for (int k = j+1; k < Len; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            IList<int> tmp = new List<int>();
                            tmp.Add(nums[i]);
                            tmp.Add(nums[j]);
                            tmp.Add(nums[k]);

                            //this is not working to remove duplicates
                            if (threeSum.Contains(tmp) == false)                            
                                threeSum.Add(tmp);
                        }
                    }
                }
            }

            return threeSum;
        }
    }
}
