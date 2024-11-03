namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_51_Medium
    {
        public static void ReverseWords()
        {
            ////Case - 1
            //string s = "the sky is blue";
            //var expOut = "blue is sky the";

            ////Case - 2
            //string s = "  hello world  ";
            //var expOut = "world hello";

            //CASE - 3
            string s = "a good   example";
            //var expOut = "example good a";

            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = ReverseWords(s);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        public static string ReverseWords(string s)
        {
            string reverse = string.Empty;

            var words = s.Trim().Split(' ');
            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word)) 
                    continue;
                reverse = word + " " + reverse;
            }
            return reverse.Trim();
        }
    }
}
