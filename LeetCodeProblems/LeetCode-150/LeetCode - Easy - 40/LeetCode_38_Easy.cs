using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_38_Easy
    {
        public static void PlusOne()
        {
            ////CASE - 1 
            //int[] digits = new int[] { 4, 3, 2, 1 };
            //int[] expectedOutput = 4 3 2 2 ;

            ////CASE - 2 
            //int[] digits = new int[] { 4, 3, 9, 9 };
            //int[] expectedOutput = 4 4 0 0  ;

            ////CASE - 3 
            //int[] digits = new int[] { 9 };
            //int[] expectedOutput = 1 0  ;

            ////CASE - 4 
            //int[] digits = new int[] { 9,9,9 };
            //int[] expectedOutput = 1 0 0 0;

            ////CASE - 5 
            int[] digits = new int[] { 9, 0, 9, 9 };
            //int[] expectedOutput = 9 1 0 0 ;

            var actualOutput = PlusOne(digits);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            for (int i = 0; i < len; i++)
            {
                var currDigitIndex = len - 1 - i;

                if (digits[currDigitIndex] == 9)
                {
                    digits[currDigitIndex] = 0;

                    //if current index is the MSB
                    if (currDigitIndex == 0)
                    {
                        // Create a new array with increased size
                        int[] newDigits = new int[len + 1];

                        // Add 1 as MSB to the new array
                        newDigits[0] = 1;

                        // Copy existing elements to the new array
                        // digits array will copy starting from index 0
                        // and new array destination will be starting from index 1
                        // because at index 0 (MSB) we have stored 1 as incremented value
                        Array.Copy(digits, 0, newDigits, 1, len);

                        return newDigits;
                    }
                }
                else
                {
                    digits[currDigitIndex]++;
                    break;
                }
            }
            return digits;
        }
        //private void PlusOne(int[] digits, int currDigitIndex)
        //{
        //    if (digits[currDigitIndex] == 9)
        //    {
        //        digits[currDigitIndex] = 0;
        //        PlusOne
        //        }
        //    else
        //    {
        //        digits[currDigitIndex]++;
        //        break;
        //    }
        //}
    }
}
