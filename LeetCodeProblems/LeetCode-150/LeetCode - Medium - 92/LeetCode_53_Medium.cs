namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_53_Medium
    {
        public static void TwoSum()
        {
            ////Case - 1
            //int[] numbers = [2, 7, 11, 15];
            //int target = 9;
            //var expOut = ;

            ////Case - 2
            int[] numbers = [-1,0];
            int target = -1;

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = TwoSum(numbers, target);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target) break;
                if (sum < target) left++;
                if (sum > target) right--;
            }
            return new int[] { left + 1, right + 1 };
        }

        //NOT An OPTIMISED SOLUTION - ALTHOUGH ACCEPTED BY LEETCODE
        // so will redo it with TWO POINTERS
        private static int[] TwoSum_1(int[] numbers, int target)
        {
            int len = numbers.Length;
            int[] twoSumArr = new int[2];

            if (len < 2) return twoSumArr;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (numbers[i] + numbers[j] == target) 
                    {
                        twoSumArr[0] = i + 1;
                        twoSumArr[1] = j + 1;
                        return twoSumArr;
                    }
                }
            }
            return twoSumArr;
        }
    }
}
