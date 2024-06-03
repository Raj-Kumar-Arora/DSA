using System.Text;
namespace LeetCodeProblems.LeetCode_150
{
    /// <summary>
    /// SAME AS PROBLEM # 15 - ANAGRAM
    /// </summary>
    internal static class LeetCode_12_Easy
    {
        public static void CanConstruct()
        {
            ////Case - 1
            //string s = "abc";
            //string t = "ahbgdc";
            //bool expOutput = true;

            ////Case - 2
            string s = "axc";
            string t = "ahbgdc";
            //bool expOutput = false;

            ////CASE - 3 
            //string s = "ace";
            //string t = "abcde";
            //bool expOutput = true;

            //Case - 4
            //string s = "aec";
            //string t = "abcde";
            //bool expOutput = true;

            //Case - 5
            //string s = "";
            //bool expOutput = 0;


            bool actualOutput = CanConstruct(s, t);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) { return false; }

            string s1 = ransomNote;
            StringBuilder s2 = new StringBuilder(magazine);

            for (int i = 0; i < s1.Length; i++)
            {
                int j = 0;
                for (j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        //Each letter in magazine can only be used once in ransomNote.
                        //So remove the char that is used/found in s1 
                        //and move pointer in s1 to next char by incrementing i
                        s2.Remove(j, 1);
                        break;
                    }
                    //if char not found till end, return false to exit loop
                    if (j == s2.Length - 1) 
                        return false;
                }
            }
            return true;
        }
    }
}