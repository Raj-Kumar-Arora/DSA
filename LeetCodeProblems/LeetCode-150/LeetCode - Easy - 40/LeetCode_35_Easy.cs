namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_35_Easy
    {
        public static void HammingWeight()
        {
            // CASE - 1
            //int n = 11;
            //expected output = 3

            //case - 2             
            int n = 2147483645;
            //expected output = 30

            int actualOutput = HammingWeight(n);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int HammingWeight(int n)
        {
            int count = 0;

            while (n > 0)
            {
                int lsd = n % 2;
                if (lsd == 1)
                    count++;
                n = n / 2;
            }
            return count;
        }

    }
}
