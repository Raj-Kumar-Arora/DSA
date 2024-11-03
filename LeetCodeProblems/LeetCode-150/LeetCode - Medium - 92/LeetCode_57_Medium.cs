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


        private static int LengthOfLongestSubstring(string s)
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
