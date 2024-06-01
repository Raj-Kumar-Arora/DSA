using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_13_Easy
    {
        public static void IsIsomorphic()
        {
            ////Case - 1
            //string s = "egg";
            //string t = "add";
            //bool expOutput = true;

            ////Case - 2
            //string s = "foo";
            //string t = "bar";
            //bool expOutput = false;

            //////CASE - 3 
            //string s = "paper";
            //string t = "title";
            //bool expOutput = true;

            //Case - 4
            string s = "badc";
            string t = "baba";
            //bool expOutput = false;

            //Case - 5

            bool actualOutput = IsIsomorphic(s, t);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool IsIsomorphic(string s, string t)
        {
            int sL = s.Length; 
            int tL = t.Length;

            if (sL != tL) { return false;  }

            Dictionary<char, char> mappedChars = new();
            for (int i = 0; i < sL; i++)
            {
                char key = s[i];
                char value = t[i];
                // if char = s[i] is present in mapped dictionary then check if its same as corresponding char at string t
                if (mappedChars.TryGetValue(key, out char mappedValue))
                {
                    if (mappedValue != value)
                        return false;
                }
                // if it key not preent in dictionary, add it after checking if value is already mapped
                else
                {
                    //REQUIREMENT => No two characters may map to the same character, but a character may map to itself.
                    foreach (var kvp in mappedChars)
                    {
                        if (kvp.Value == value)
                            return false;
                    }

                    //mappedChars[key] =  value;    // this line is same as below one - just a diff type of writing same thing
                    mappedChars.Add(key, value);
                }
            }

            return true;
        }
    }
}