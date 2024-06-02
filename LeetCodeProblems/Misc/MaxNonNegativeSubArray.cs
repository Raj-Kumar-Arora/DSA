using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Misc
{
    internal static class MaxNonNegativeSubArray
    {
        public static void Test()
        {
            List<int> A = new List<int>()
            //case - 1 //{1, 2, 5, -7, 2, 3 };
            //case - 2  //{0, 0, -1, 0 };
            //case - 3  //{ 1967513926, 1540383426, -1303455736, -521595368};
            //case - 4 // { -1, -1, -1, -1, -1};
            //case - 5 //{ 756898537, -1973594324, -2038664370, -184803526, 1424268980};
            //case - 6 // {-1469348094, 1036140795, 2040651434, -317097467, 1376710097, 1330573317, 1687926652 };
            //case - 7 
            { 39194, 51295, 33419, 63443, 68706, 26593, 31226 };

            List<int> ret = maxset(A);
            foreach (int i in ret)
                Console.Write(i + " ");
        }

        public static List<int> maxset(List<int> A)
        {
            List<int> ret = new List<int>();

            int i = 0;
            int indexOfNeg = -1;
            int prevStartInex = 0, prevEndIndex = 0;
            int currStartInex = 0, currEndIndex = 0;
            long prevSum = 0, currSum = 0;

            if (A.Count <= 0) return ret;

            do
            {
                if (A[i] >= 0)
                    currSum += A[i];
                else  //Found -ve no 
                {
                    indexOfNeg = i;

                    if (currSum > prevSum ||
                         currSum == prevSum && prevSum == 0 && i > 0 && A[i - 1] >= 0) //update PREV Record For non-rep -VE nos
                    {
                        //replace data for PREV record
                        prevEndIndex = i - 1;
                        prevStartInex = currStartInex;
                        prevSum = currSum;
                    }
                    //Reset CURR records
                    currStartInex = i + 1;
                    currEndIndex = 0;
                    currSum = 0;
                }
                i++;
            } while (i < A.Count);

            if (currSum > prevSum ||
                currSum == prevSum && currEndIndex - currStartInex > prevEndIndex - prevStartInex)
            {
                if (currEndIndex == 0 && i == A.Count)
                    currEndIndex = A.Count - 1;

                //replace data for PREV record
                prevEndIndex = currEndIndex;
                prevStartInex = currStartInex;
            }

            for (i = prevStartInex; i <= prevEndIndex; i++)
                if (A[i] >= 0)
                    ret.Add(A[i]);

            return ret;
        }
    }
}
