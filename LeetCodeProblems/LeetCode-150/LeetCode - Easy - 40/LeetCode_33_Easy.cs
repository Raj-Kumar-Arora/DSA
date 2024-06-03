namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_33_Easy
    {
        public static void AddBinary()
        {
            ////CASE - 1 
            string a = "11", b = "1";
            //string expectedOutput = "100";

            //CASE - 2 
            //string a = "1010", b = "1011";
            //string expectedOutput = "10101";

            //CASE - 3 
            //string a = "", b = "";
            //string expectedOutput = "100";

            string actualOutput = AddBinary(a, b);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static string AddBinary(string a, string b)
        {
            int i = a.Length - 1, j = b.Length - 1;
            int carry = 0;
            string result = "";

            //// Step - 1   Fetching LSB(Least significant bit) i.e. right most bit
            ///             from both strings and then taking their sum in SumDigit
            ///  Step - 2   Carry forward is calculated from SumDigit using / , % 
            ///             as sumDigit is integer
            ///  Step - 3   Adjust carry forward in final sum
            while (i >= 0 || j >= 0 || carry == 1)
            {
                int firstDigit = (i >= 0) ? (a[i--] - '0') : 0;
                int secondDigit = (j >= 0) ? (b[j--] - '0') : 0;
                int sumDigit = firstDigit + secondDigit + carry;
                carry = sumDigit / 2;

                result += (sumDigit % 2).ToString();
            }
            return new string(result.Reverse().ToArray());    //**CHECK - WHY ToArray() IS NEEDED HERE ???
        }
    }
}
