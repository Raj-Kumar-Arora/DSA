using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Misc
{
    internal class FindMissingElement
    {

        //PASTE THIS BLOCK IN PROGRAM.CS
        ////int[] Input = new int[] { 1, 2, 3, 4, 7, 8 };   //Working 
        ////int[] Input = new int[] { 1, 2, 3, 4, 6, 8, 9 };  //output need some refining
        //int[] Input = new int[] { 1, 2, 3, 4, 5, 6, 7 };    // working as expected[1-7]
        //FindMissingElement(Input);
        //**TILL HERE **

        //Test Case 1
        //Input = [1,2,3,4,6,7,8]
        //Output = [1-4, 6-8]

        //[1,2,3,4,6,8,9]

        //[1-4, 6, 8-9]



        //Test Case 2

        //input = [1,2,3,4,5,6,7]

        //output = [1-7]


        //1. iterate thru the input array 
        //2. find missing no if any
        //3. split 

        //string FindMissingElement(int[] input)
        //{
        //    int prevNo = input[0];
        //    string strResult = "[" + prevNo.ToString() + "-";

        //    for (int i = 1; i < input.Length; i++)
        //    {
        //        if (input[i] == prevNo + 1)
        //        {
        //            //if (strResult.EndsWith(", "))
        //            //{
        //            //    strResult += Input[i].ToString();
        //            //}
        //            if (i == Input.Length - 1)
        //            {
        //                strResult += Input[i].ToString() + "]";
        //            }
        //        }
        //        else
        //        {
        //            //split array for result
        //            strResult += prevNo.ToString();

        //            if (i == Input.Length)
        //            {
        //                strResult += "]";
        //            }
        //            else
        //            {
        //                strResult += ", " + input[i] + "-";
        //            }
        //        }

        //        prevNo = input[i];
        //    }



        //    return strResult;
        //}
    }
}
