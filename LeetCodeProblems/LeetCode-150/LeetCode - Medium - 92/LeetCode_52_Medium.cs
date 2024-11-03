namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_52_Medium
    {
        public static void Convert()
        {
            ////Case - 1
            string s = "PAYPALISHIRING";
            int numRows = 3;
            //var expOut = "PAHNAPLSIIGYIR";

            ////Case - 2

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = Convert(s, numRows);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        //NOT MY SOLUTION - ITS from LEETCODE C#
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= 1)
               return s;
            
            string[] solution = new string[numRows];

            int i = 0, direction = 1;
            foreach (char c in s)
            {
                solution[i] += c;

                i += direction;

                if (i == numRows - 1 || i == 0) 
                    direction *= -1;
            }

            return string.Concat(solution);
        }
    }
}
