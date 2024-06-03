namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_40_Easy
    {
        public static void ClimbStairs()
        {
            ////CASE - 1 
            int x = 4;
            //int[] expectedOutput = 5 ;

            var actualOutput = ClimbStairs(x);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }

        private static int ClimbStairs(int n)
        {
            if (n <= 0) return 0;
            if (n > 0 && n < 3) return n;

            int[] arr = new int[n + 1];
            arr[1] = 1;
            arr[2] = 2;

            ClimbStairs(n, arr);
            return arr[n];
        }
        private static void ClimbStairs(int n, int[] arr)
        {
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
        }

        //2nd & BETTER WAY
        private static int ClimbStairs_2ndWay(int n)
        {
            if (n <= 0) return 0;
            if (n > 0 && n < 3) return n;

            int sum = 0;
            int first = 1, second = 2;

            for (int i = 3; i <= n; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
            }
            return sum;
        }
    }
}
