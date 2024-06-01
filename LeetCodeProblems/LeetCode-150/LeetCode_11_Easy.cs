using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode_150
{
    internal static class LeetCode_11_Easy
    {
        public static void Test()
        {
            ////Case - 1
            //string s = "abc";
            //string t = "ahbgdc";
            //bool expOutput = true;

            ////Case - 2
            //string s = "axc";
            //string t = "ahbgdc";
            //bool expOutput = false;

            ////CASE - 3 
            //string s = "ace";
            //string t = "abcde";
            //bool expOutput = true;

            //Case - 4
            string s = "aec";
            string t = "abcde";
            //bool expOutput = false;

            //Case - 5
            //string s = "";
            //bool expOutput = 0;


            bool actualOutput = IsSubsequence(s, t);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool IsSubsequence(string s, string t)
        {
            int sL = s.Length; 
            int tL = t.Length;

            if (sL > tL) { return false;  }

            int pi = 0; //index of last/prev char of s in t
            for (int i = 0; i < sL; i++)
            {
                int j = 0;
                for (j = pi; j < tL; j++)
                {
                    if (s[i] == t[j])
                    {
                        pi = j + 1; 
                        break;
                    }
                }
                if (j == tL)
                    return false;
            }
            return true;
        }
    }
}