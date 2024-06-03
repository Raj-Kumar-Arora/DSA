namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_37_Easy
    {
        public static void IsPalindrome()
        {
            ////CASE - 1 
            //int n = 141;
            //bool expectedOutput = true;

            ////CASE - 2 
            int n = -141;
            //bool expectedOutput = false;

            bool actualOutput = IsPalindrome(n);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static bool IsPalindrome(int n)
        {
            string str = n.ToString();
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                    return false;
            }
            return true;
        }

        //failing for case - 2 (n = -141)
        //private static bool IsPalindrome(int n)
        //{
        //    List<int> digitsArr = new();
        //    while (n>0)
        //    {
        //        digitsArr.Add(n % 10);
        //        n /= 10;
        //    }
        //    int len = digitsArr.Count;
        //    for (int i = 0; i< len/2; i++)
        //    {
        //        if (digitsArr[i] != digitsArr[len - 1 - i])
        //            return false;
        //    }
        //    return true;
        //}
    }
}
