using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode_150
{
    internal static class LeetCode_14_Easy
    {
        public static void Test()
        {
            // C# Solution - Easy to understand (With comments)

            ////Case - 1
            //string pattern = "abba";
            //string s = "dog cat cat dog";
            //bool expOutput = true;

            ////Case - 2
            //string pattern = "abba";
            //string s = "dog cat cat fish";
            //bool expOutput = false;

            //////CASE - 3 
            //string pattern = "aaaa";
            //string s = "dog cat cat dog";
            //bool expOutput = false;

            //Case - 4
            string pattern = "abba";
            string s = "dog dog dog dog";
            //bool expOutput = false;

            //Case - 5

            bool actualOutput = WordPattern(pattern, s);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool WordPattern(string pattern, string s)
        {
            int pL = pattern.Length;
            string[] strArr = s.Split(' ');
            int sL = strArr.Length;

            if (pL != sL) { return false; }
            
            Dictionary<char, string> mappedStrs = new();
            for (int i = 0; i < sL; i++)
            {
                char key = pattern[i];
                string value = strArr[i];

                // if pattern char (key) is present in mapped dictionary then check if its same as corresponding string in s
                if (mappedStrs.TryGetValue(key, out string mappedValue))
                {
                    if (mappedValue != value)
                        return false;
                }
                // if it key not preent in dictionary, add it after checking if value is already mapped
                else
                {
                    foreach (var kvp in mappedStrs)
                    {
                        if (kvp.Value == value)
                            return false;
                    }

                    //mappedStrs[key] =  value;   // this line is same as below one - just a diff type of writing same thing
                    mappedStrs.Add(key, value);
                }
            }

            return true;
        }
    }
}