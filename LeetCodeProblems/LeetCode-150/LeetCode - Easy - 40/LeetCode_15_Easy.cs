using System.Text;
namespace LeetCodeProblems.LeetCode_150
{
    /// <summary>
    /// SAME AS PROBLEM # 12 - CanConstruct ransomnote 
    /// </summary>
    internal static class LeetCode_15_Easy
    {
        public static void IsAnagram()
        {
            ////Case - 1
            //string s = "anagram";
            //string t = "nagaram";
            //bool expOutput = true;

            ////Case - 2
            string s = "rat";
            string t = "car";
            //bool expOutput = false;

            //////CASE - 3 
            //string s = "paper";
            //string t = "title";
            //bool expOutput = true;

            //Case - 4
            //string s = "badc";
            //string t = "baba";
            //bool expOutput = false;

            //Case - 5

            bool actualOutput = IsAnagram(s, t);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool IsAnagram(string s, string t)
        {
            int sL = s.Length; 
            int tL = t.Length;

            if (sL != tL) { return false; }
            string s1 = s;
            StringBuilder s2 = new StringBuilder(t);

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