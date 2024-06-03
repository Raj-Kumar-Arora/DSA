namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_34_Easy
    {
        public static void ReverseBits()
        {
            ////CASE - 1 
            //uint n = 0b0101;   
            //expectedOutput = "0b 1010";  //decimal value 10

            //CASE - 2 
            //uint n = 0b1010;
            //expectedOutput = "0b 0101";  //decimal value 5

            //CASE - 3 
            uint n = 0b1101;
            //expectedOutput = "0b 1011";  //decimal value 11

            uint actualOutput = ReverseBits(n);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static uint ReverseBits(uint n)
        {
            // APPROACH 
            // STEP - 1  Get ith bit from LSB towards MSB
            // STEP - 2  Left shift bit (32 - ith) times to perform reverse 
            // STEP - 3  Do OR operation with result of previous steps
            uint result = 0;
            int len = 4; // 32;  //32 bit unit length

            for (int i = 0; i < len; i++)
            {
                // STEP - 1  Get ith bit from LSB towards MSB
                uint t1 = (uint)(n & 1);
                n = n >> 1;

                // STEP - 2  Left shift bit (32 - ith) times to perform reverse 
                uint t2 = t1 << (len - i - 1);

                // STEP - 3  Do OR operation with result of previous steps
                result |= t2;
            }
            return result;

            //Sln # 2  - NOT WORKING 
            //result = result << 1;
            //if (n % 2 == 1)
            //    result++;
            //n = n >> 1;

            //1st sln NOT WORKING 
            //uint lsb = (uint)(n & i);
            //uint reverse = lsb << (len-i-1);
            //result = result | reverse;
            //n = n >> 1;
        }
    }
}
