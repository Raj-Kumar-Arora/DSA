namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_09_Easy
    {
        public static void StrStr()
        {
            ////Case - 1
            //string haystack = "sadbutsad";
            //string needle = "sad";
            //int expOutput = 0;

            ////Case - 2
            //string haystack = "leetcode";
            //string needle = "leeto";
            //int expOutput = -1;

            ////CASE - 3 //IMP CASE
            //string haystack = "sasadsad";
            //string needle = "sad";
            //int expOutput = 2;

            //Case - 4
            //string haystack = "sabcdefgsad";
            //string needle = "sad";
            //int expOutput = 8;

            //Case - 5
            //string haystack = "hello";
            //string needle = "ll";
            //int expOutput = 2;

            //Case - 6            
            //string haystack = "hellelllo";
            //string needle = "lll";
            //int expOutput =5 ;

            //Case - 7            
            //string haystack = "hellelllo";
            //string needle = "lllo";
            //int expOutput =5 ;

            //Case - 8            
            //string haystack = "aaa";
            //string needle = "aaaa";
            //int expOutput =5 ;

            //Case - 9     //IMP CASE       
            //string haystack = "mississippi";
            //string needle = "issip";
            //int expOutput =4 ;

            ////Case - 10          
            //string haystack = "abcde";
            //string needle = "cde";
            ////int expOutput =2 ;

            //Case - 10          
            string haystack = "a";
            string needle = "a";
            //int expOutput =0 ;

            int actualOutput = StrStr(haystack, needle);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static int StrStr(string haystack, string needle)
        {
            //create alias/reference for incoming strings for easier typing :-p 
            string s1 = haystack, s2 = needle;

            //APP - 2 FROM AVL SOLNS
            if (s1.Length < s2.Length) { return -1; }
            for (int i = 0; i < s1.Length - s2.Length + 1; i++)
            {
                int j = 0;
                while (j < s2.Length && s1[i + j] == s2[j])
                    j++;

                if (j == s2.Length)
                    return i;
            }
            return -1;

            //MY APPROACH - 1- NOT WORKING FOR CASE  - 9  "mississippi"/"issip"
            //*TAKEAWAY - we need to apply 2 loops and I was using only 1 loop in this approach
            //
            //if (s1.Length < s2.Length)
            //{
            //    return -1;
            //}

            //int index = -1;
            //int j = 0;
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    j = j % s2.Length;
            //    if (s1[i] == s2[j])
            //    {
            //        //if first char match, capture index in s1
            //        //if (index == -1 && j == 0)
            //        if (j == 0)
            //        { 
            //            index = i; 
            //        }
            //        j++;
            //    }
            //    else
            //    {
            //        //if s2 matching completed till s2.length chars, return index
            //        if (index != -1 && (i - index) == s2.Length)
            //            return index;
            //        else
            //        {
            //            j = 0;  //if an unmatched char found, start looking from s2's start 

            //            //if we got char matching at start of s2 like 3rd char s in [sasad / sad]
            //            if (s1[i] == s2[j])
            //            {
            //                index = i;
            //                j++;
            //            }
            //            else
            //            {
            //                //if s2 matching not complete in s1, reset found index
            //                index = -1;
            //            }
            //        }
            //    }               
            //}
            //return index;
        }
    }
}