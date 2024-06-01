using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_39_Easy
    {
        public static void MySqrt()
        {
            //////CASE - 1 
            int x = 2147395600;
            ////int[] expectedOutput = 46340 ;

            ////CASE - 1 
            //int x = 4;
            //int[] expectedOutput = 2 ;

            var actualOutput = MySqrt(x);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int MySqrt(int x)
        {
            for (long i = 1; i <= x; i++)
            {
                if (i * i > x)
                    return (int)(i - 1);
            }
            return 0;
        }

        //tedious way 
        //private static int MySqrt(int x)
        //{
        //    int ret = 0;
        //    // 289398
        //    //for x=1, loop should check till i<=x

        //    //for (int i = 1; i <= x; i++)
        //    //{
        //    //    if ((i * i <= x) &&
        //    //            ((i + 1) * (i + 1) > x))
        //    //        return i;
        //    //}

        //    int i = 0;
        //    try
        //    {                
        //        for (i = 1; i <= x; i++)
        //        {
        //            if (i * i <= x)
        //            {
        //                int nextSqr = checked((i + 1) * (i + 1));

        //                //if overflow happened then (nextSqr > x ) will be false but 
        //                //value will be on -ve range of integer values
        //                if (nextSqr > x)
        //                    return i;
        //                //else if (nextSqr >= int.MinValue)
        //                //    return i;


        //                //if ((nextSqr > x) == true && 
        //                //     nextSqr > int.MaxValue == false)
        //                //    return i;

        //                //if ((nextSqr > x) == false &&
        //                //     nextSqr > int.MinValue == true)
        //                //    return i;
        //            }

        //            //return i;
        //        }

        //    }
        //    catch (OverflowException)
        //    {
        //        ret = i;
        //    }
        //    finally
        //    {   }

        //    return ret;
        //}
    }
}
