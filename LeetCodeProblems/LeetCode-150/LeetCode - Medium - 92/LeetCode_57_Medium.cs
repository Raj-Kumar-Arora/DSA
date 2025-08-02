using System.Drawing;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_57_Medium
    {
        public static void LengthOfLongestSubstring()
        {
            ////Case - 1
            string s = "abcabcbb";
            int numRows = 3;
            //var expOut = "PAHNAPLSIIGYIR";

            ////Case - 2
            //string s = "pwwkew";
            //int numRows = 3;

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = LengthOfLongestSubstring(s);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        //TO Understand it later- Its also almost similar to my WORKING solution at line no 64
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/solutions/4701201/simple-solution-with-better-explanation/
        public static int LengthOfLongestSubstring(string s)
        {
            // Check if the length of the string is less than 2
            if (s.Length < 2)
            {
                return s.Length;
            }

            // Initialize variables
            int k = 0, maxLen = 0, count = 0;

            // Iterate through the string
            for (int i = 1; i < s.Length; i++)
            {
                // Check for repeating characters in the current substring
                for (int j = k; j < i; j++)
                {
                    if (s[i] == s[j])
                    {
                        k = j + 1;
                    }
                }

                // Update the current substring length
                count = i - k + 1;

                // Update the maximum length
                if (count > maxLen)
                {
                    maxLen = count;
                }
            }

            // Return the result
            return maxLen;
        }

        //WORKIGN - MY solution - not efficient
        private static int LengthOfLongestSubstring_(string s)
        {
            // StringBuilder sb = new();
            List<char> subStr = new List<char>();

            int i = 0, j = 0, maxLen = 0;

            while (j < s.Length)
            {
                char ch = s[j];
                //if (sb.ToString().Contains(ch))
                //    sb.Remove(s[i]);
                if (subStr.Contains(ch))
                {
                    subStr.Remove(s[i]);
                    i++;
                }
                else
                {
                    subStr.Add(ch);
                    j++;
                    maxLen = Math.Max(maxLen, j - i);
                }
            }
            return maxLen;
            ////check why this solution is working and above not working
            //int j = 0;
            //int i = 0;
            //int maxLength = 0;
            //List<char> sub = new List<char>();

            //while (j < s.Length)
            //{
            //    if (sub.Contains(s[j]))
            //    {
            //        sub.Remove(s[i]);
            //        i++;
            //    }
            //    else
            //    {
            //        sub.Add(s[j]);
            //        j++;
            //        maxLength = Math.Max(maxLength, j - i);
            //    }
            //}
            //return maxLength;
        }
    }
}
