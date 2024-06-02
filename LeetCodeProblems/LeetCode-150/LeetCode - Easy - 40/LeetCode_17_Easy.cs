using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_17_Easy
    {
        public static void getNextNo()
        {
            //Case - 1
            //int n = 19;
            //bool expectedOutput = true;

            //Case - 2
            int n = 2;
            //bool expectedOutput = false;

            //Case - 3
           // int n = 7;
           // bool expectedOutput = true;

            bool actualOutput = IsHappy(n);

            Console.WriteLine("actualOutput = " + actualOutput);

        }
        private static int getNextNo (int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int rem = n % 10;
                sum += rem * rem;
                n /= 10;
            }
            return sum;
        }
        public static bool IsHappy(int n)
        {
            //moved getNextNo calculation to seperate methond
            // in this method we will check the repeating pattern/cycle
            int no = n;
            int nextToNextNo = n;

            do
            {
                no = getNextNo(no);
                nextToNextNo = getNextNo(getNextNo(nextToNextNo));
            }while (no != nextToNextNo);

            return (no == 1);

            //**** APPROACH - 3   *****
            //int sum = 0;

            //if (n == 1)
            //    return true;

            //if (n == int.MaxValue - 1)
            //    return false;

            ////checking for 50 elements array for now for n = 2 
            //int[] repeatingPattern = new int[50];
            //repeatingPattern[0] = 2;
            //while (n > 0)
            //{
            //    if (repeatingPattern.Contains(n) == false)
            //    {
            //        repeatingPattern[repeatingPattern.Length] = n;
            //    }
            //    else
            //    {
            //        //value is repeating in pattern  infinite times
            //        return false;
            //    }

            //    int rem = n % 10;
            //    sum += rem * rem;
            //    n /= 10;

            //    if (n == 0)
            //    {
            //        n = sum;
            //        return IsHappy(n);
            //    }
            //}
            //return false;

            //**** APPROACH - 2   *****
            //even followign code of EXCEPTION HANDING Fails to run this program for case 2 (n =2 )
            // because of infinite loop
            //public static bool IsHappy(int n)
            //{
            //    bool ret = false;
            //    try
            //    {
            //        int sum = 0;

            //        if (n == 1)
            //            return true;

            //        if (n == int.MaxValue - 1)
            //            return false;

            //        while (n > 0)
            //        {
            //            int rem = n % 10;
            //            sum += rem * rem;
            //            n /= 10;

            //            if (n == 0)
            //            {
            //                n = sum;
            //                return IsHappy(n);
            //            }
            //        }
            //    }
            //  //  catch (Exception ex) { }
            //    finally
            //    {
            //        ret = false;
            //    }

            //    return ret;


            //*** APPROACH - 1 ****
            //bool ret = false;
            //int sum = 0;

            //if (n == 1)
            //    return true;

            //if (n > int.MaxValue-1) 
            //    return false;


            //while (n > 0)
            //{
            //    int rem = n % 10;
            //    sum += rem * rem;
            //    n /= 10;

            //    if (n == 0)
            //    {
            //        n = sum;
            //        return IsHappy(n);
            //    }
            //}
            //return ret;
        }
    }
}
