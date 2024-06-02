using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_07_Easy
    {
        public static void LengthOfLastWord()
        {
            ////Case - 1
            //string s = "Hello World";
            //int expOutput = 5;

            ////Case - 2
            //string s = "   fly me   to   the moon  ";
            //int expOutput = 4;

            ////CASE - 3
            //string s = "luffy is still joyboy";
            //int expOutput = 6;

            //Case - 4
            //string s = "A ";
            //int expOutput = 1;

            //Case - 5
            string s = "A  ";
            //int expOutput = 1;

            //Case - 6
            //string s = "";

            int actualOutput = LengthOfLastWord(s);         

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static int LengthOfLastWord(string s)
        {
            int ret = 0;
            if (string.IsNullOrEmpty(s) || s.Length <=1)
                return s.Length;

            if (s[0] != ' ')
                ret = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    //if pattern being received is like " X" where x is non-space, reset chars count
                    if (s[i - 1] == ' ')
                        ret = 1;
                    else
                        ret++;
                }
                else
                {
                    // do nothing if space chars received may be at end of string
                }

            }
            return ret;
        }
    }
}
