namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_06_Easy
    {
        public static void RomanToInt()
        {
            ////Case - 1
            //string s = "III";

            ////Case - 2
            string s = "LVIII";
            //int expOutput = 58;

            ////CASE - 3
            //string s = "MCMXCIV";
            //int expOutput = 1994;

            //Case - 4
            //string s = "";

            //Case - 5
            //string s = "";

            //Case - 6
            //string s = "";

            int actualOutput = RomanToInt(s);         

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static int RomanToInt(string s)
        {
            int ret = 0;
            // ****    REFERENCE TABLE    ****     //
            // index  Roman Literal   Weight Integer
            //  0         I               1
            //  1         V               5
            //  2         X               10
            //  3         L               50
            //  4         C               100
            //  5         D               500
            //  6         M               1000

            int[] wtOfRomanLiterals = new int[] { 1, 5, 10, 50, 100, 500, 1000 };

            int pi = 10; //index of prevoius roman literal char in iteration higher than current limit i.e. 6 (M)
            int ci = 0;  //index of current roman literal being traversed

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                switch (c)
                {
                    case 'I':   ci = 0;
                        break;
                    case 'V':   ci = 1;
                        break;
                    case 'X':   ci = 2;
                        break;
                    case 'L':  ci = 3;
                        break;
                    case 'C':  ci = 4;
                        break;
                    case 'D':  ci = 5;
                        break;
                    case 'M':  ci = 6;
                        break;
                    default: //don't consider if any invalid char is present
                        break;
                }

                if (pi >= ci)
                    ret += wtOfRomanLiterals[ci];
                else   //special sequence is being present like IV, IX, XL, CD, CM etc.
                {
                    //rollback previous index calculation from previous traversal
                    ret -= wtOfRomanLiterals[pi];
                    //recall : if its IX then wt of 'I' will be subtracted from wt of X in following step
                    ret += wtOfRomanLiterals[ci] - wtOfRomanLiterals[pi];
                }
                pi = ci;
            }
            return ret;
        }
    }
}
