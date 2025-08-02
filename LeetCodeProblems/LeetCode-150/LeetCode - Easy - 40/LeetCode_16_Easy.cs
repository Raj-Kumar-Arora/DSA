namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_16_Easy
    {
        public static void TwoSum()
        {
            //Case - 1
            int[] nums = new int[] {2,7,11,15 }; int target = 9;
            //Case - 2
            //int[] nums = new int[] { 1,2,5,-4,7,3 }; int target = 1;

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

            //2nd approach - using hashset - NOT WORKING
            // REf - https://youtu.be/Z_c4byLrNBU?si=aMRzuybGsoGjTUtq

            //HashSet<int> set = new();
            ////set.Count = 2;

            //foreach (var num in nums)
            //{
            //    var complement = target - num;

            //    if (set.Contains(complement))
            //        return set.ToArray();

            //    set.Add(complement);            
            //}
            //return [];

            // To make it work - change HashSet to Dict<index, value>
            // Use a dictionary to store the number and its index
            // Key: number, Value: index
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Check if the complement exists in the dictionary
                if (numMap.ContainsKey(complement))
                {
                    // If found, return the indices of the complement and the current number
                    return new int[] { numMap[complement], i };
                }

                // If the complement is not found, add the current number and its index to the dictionary
                // This ensures that for future iterations, we can check if the current number is a complement
                // for a later number.
                if (!numMap.ContainsKey(nums[i])) // Avoid adding duplicate keys if numbers are repeated
                {
                    numMap.Add(nums[i], i);
                }
            }

            // If no solution is found (though the problem statement usually guarantees one),
            // you might return an empty array or throw an exception.
            // For LeetCode, typically a valid solution is expected.
            return new int[] { };

        }
    }
}
