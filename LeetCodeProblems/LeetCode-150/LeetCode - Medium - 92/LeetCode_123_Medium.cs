using System.Drawing;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_123_Medium
    {
        public static void WordBreak()
        {
            ////Case - 1
            string s = "leetcode";
            List<string> wordDict = new List<string>() { "leet", "code" };

            ////Case - 2
            //string s = "bb";
            //List<string> wordDict = new List<string>() { "a", "b", "bbb", "bbbb" };

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = WordBreak(s, wordDict);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        // THIS PROBLEM CAN BE SOLVED WITH 2 APPROACHES - 1st DP & 2nd MEMOISATION WITH RECURSION
        // SOLUTION DETAILS - 100% DP & DFS [VIDEO] - Segmenting a String - BY vanAmsen
        // https://leetcode.com/problems/word-break/solutions/3860456/100-dp-dfs-video-segmenting-a-string/?envType=study-plan-v2&envId=top-interview-150

        // HERE IS 1st DP APPROACH 
        private static bool WordBreak(string s, IList<string> wordDict)
        {
            int n = s.Length;
            bool[] dp = new bool[n + 1];
            dp[0] = true;
            int max_len = 0;
            foreach (string word in wordDict)
            {
                max_len = Math.Max(max_len, word.Length);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = i - 1; j >= Math.Max(i - max_len - 1, 0); j--)
                {
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n];
        }

        // Here is next approach - 2nd MEMOISATION WITH RECURSION
        // this is also working - code for memoisation commented to understand the simlified version

        private static bool WordBreak_2(string s, IList<string> wordDict)
        { 
        //    Dictionary<string, bool> memo = new Dictionary<string, bool>();
            HashSet<string> wordSet = new HashSet<string>(wordDict);
          //  return Dfs(s, wordSet, memo);
            return Dfs(s, wordSet);
        }

        private static bool Dfs(string s, HashSet<string> wordSet)
        {
           // if (memo.ContainsKey(s)) return memo[s];
            if (wordSet.Contains(s)) return true;
            for (int i = 1; i < s.Length; i++)
            {
                string prefix = s.Substring(0, i);
            //    if (wordSet.Contains(prefix) && Dfs(s.Substring(i), wordSet, memo))
                if (wordSet.Contains(prefix) && Dfs(s.Substring(i), wordSet))
                {
                  //  memo[s] = true;
                    return true;
                }
            }
         //   memo[s] = false;
            return false;
        }

        // my approach - not working for case - 2
        private static bool WordBreak_1(string s, IList<string> wordDict)
        {
            string words = string.Empty;
            for (int i = 0; i < wordDict.Count; i++)
            {
                words += wordDict[i];
            }

            bool result = s.StartsWith(words);
            return result;
        }
    }
}
