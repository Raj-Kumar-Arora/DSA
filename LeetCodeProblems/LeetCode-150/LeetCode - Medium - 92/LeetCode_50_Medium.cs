namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_50_Medium
    {
        public static void IntToRoman()
        {
            ////Case - 1
            //int num = 3749;
            //string expOut = MMMDCCXLIX;

            ////Case - 2
            //int num = 58;
            //string expOut = LVIII;

            //CASE - 3
            //int num = 1994;
            //string expOut = MCMXCIV;

            //Case - 4
            int num = 1;
            //string expOut = I;

            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = IntToRoman(num);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        public static string IntToRoman(int num)
        {
            string roman = string.Empty;
            //int c = 0;
            int len = num.ToString().Length;

            while (len > 0)
            {
                int x = (int)Math.Pow(10, len-1);
                int rem = num / x;
                num = num % x;
                //c = c + 1;

                switch (len)
                {
                    case 1: 
                        if (rem == 9) roman += "IX";
                        else if (rem == 4) roman += "IV";
                        else 
                        {
                            if (rem >= 5)
                            {
                                roman += "V";
                                rem = rem % 5;
                            }
                                
                            for (int i = 0; i< rem; i++)
                            {
                                roman += "I";
                            }
                        }
                        break;

                    case 2:
                        if (rem == 9) roman += "XC";
                        else if (rem == 4) roman += "XL";
                        else 
                        {
                            if (rem >= 5)
                            {
                                roman += "L";
                                rem = rem % 5;
                            }

                            for (int i = 0; i < rem; i++)
                            {
                                roman += "X";
                            }
                        }
                        break;

                    case 3:
                        if (rem == 9) roman += "CM";
                        else if (rem == 4) roman += "CD";
                        else 
                        {
                            if (rem >= 5)
                            {
                                roman += "D";
                                rem = rem % 5;
                            }

                            for (int i = 0; i < rem; i++)
                            {
                                roman += "C";
                            }
                        }
                        break;

                    case 4:
                        for (int i = 0; i < rem; i++)
                        {
                            roman += "M";
                        }
                        break;
                } 

                len--;
            }
            return roman;
        }
    }
}
