using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_08_Easy
    {
        public static void LongestCommonPrefix()
        {
            ////Case - 1
            string[] strs = new string[] { "flower", "flow", "flight" };
            //string expOutput = "fl";

            ////Case - 2
            //string[] strs = new string[] { "dog", "racecar", "car" };
            //string expOutput = "";

            ////CASE - 3
            //string[] strs = new string[] { "dog"};
            //string expOutput = "dog";

            //Case - 4
            //string[] strs = new string[] { "flower", "flight", "flow" };
            //string expOutput = "fl";

            //Case - 5
            //string[] strs = new string[] { "abab","aba","" };
            //string expOutput = "";

            //Case - 6            
            //string[] strs = new string[] { "c", "acc", "ccc" };
            //string expOutput = "";

            string actualOutput = LongestCommonPrefix(strs);         

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            //if (strs.Length <= 1)
            //    return strs[strs.Length - 1];

            Array.Sort(strs);
            string s0 = strs[0];
            string si = strs[strs.Length - 1];
            int i;
            for (i = 0; i < s0.Length && i < si.Length; i++)
            {
                if (s0[i] != si[i])
                    break;
            }
            return s0[..i]; // equivalent to  s0.Substring(0, i);

            //APP - 3 FROM AVL SOLNS
            //StringBuilder ans = new StringBuilder();
            //Arrays.sort(v);
            //String first = v[0];
            //String last = v[v.length - 1];
            //for (int i = 0; i < Math.min(first.length(), last.length()); i++)
            //{
            //    if (first.charAt(i) != last.charAt(i))
            //    {
            //        return ans.toString();
            //    }
            //    ans.append(first.charAt(i));
            //}
            //return ans.toString();

            //aPP - 2 FROM AVL SOLNS
            // int s0_Length = s0.Length
            //for j => while OF (s0_Length > si.Length || !s0.equals(si.substring(0, s0_Length))) 
            //s0_Length--

            //MY APPROACH - 1 - WORKS FOR 5/6 CASES
            // NOT WORKING FOR CASE - 6 { "c", "acc", "ccc" }
            //if (strs.Length <= 1)
            //    return strs[strs.Length-1];

            //StringBuilder retStr = new StringBuilder();
            //string s0 = strs[0];
            //int minLen = 0;

            //for (int i = 1; i< strs.Length; i++)
            //{
            //    string si = strs[i];
            //    //int minLen = Math.Min (s0.Length, si.Length);
            //    minLen = (s0.Length < si.Length) ? s0.Length : si.Length;
            //    if (retStr.Length >0)
            //        minLen = (minLen < retStr.Length) ? minLen : retStr.Length;

            //    if (minLen == 0)
            //        return "";

            //    for (int j = 0; j<minLen; j++)
            //    {
            //        //compare s0 & si char by char and copy the matching chars in ret
            //        //break on first non-matching char
            //        if (s0[j] == si[j])
            //        {
            //            if (retStr.Length - 1 < j)
            //                retStr.Append(si[j]);
            //        }
            //        else
            //        {
            //            if (retStr.Length > j)
            //                retStr.Remove(j, retStr.Length - j);
            //            break;
            //        }
            //    }
            //}

            //return retStr.ToString();
        }
    }
}
