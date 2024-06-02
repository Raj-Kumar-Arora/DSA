using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_10_Easy
    {
        public static void IsPalindrome()
        {
            ////Case - 1
            //string s = "A man, a plan, a canal: Panama";
            //bool expOutput = true;

            ////Case - 2
            //string s = "race a car";
            //bool expOutput = false;

            ////CASE - 3 
            string s = " ";
            //bool expOutput = true;

            //Case - 4
            //string s = "";
            //bool expOutput = 0;

            //Case - 5
            //string s = "";
            //bool expOutput = 0;


            bool actualOutput = IsPalindrome(s);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();

            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                    sb.Append(c);
            }
            for (int i = 0; i < sb.Length/2; i++)
            {
                if (sb[i] != sb[sb.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}