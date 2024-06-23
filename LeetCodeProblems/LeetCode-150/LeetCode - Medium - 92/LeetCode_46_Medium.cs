namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_46_Medium
    {
        public static void HIndex()
        {
            ////Case - 1
            // int[] citations = { 3,0,6,1,5 };
            //int expOut = 3;

            ////Case - 2
            int[] citations = { 1,3,1 };
            //int expOut = 1;

            //CASE - 3
            //int[] citations = { 100 };
            //int expOut = 1;

            //Case - 4
            //int[] citations = { 0 };
            //int expOut = 0;

            //Case - 5
            //int[] citations = {};
            //int expOut = 0;

            //Case - 6
            //int[] citations = { 0,1 };
            //int expOut = 1;

            //Case - 7
            //int[] citations = { 11, 15 };
            //int expOut = 2;

            //Case - 8
            //int[] citations = { 10, 8, 5, 4, 3 };
            //int expOut = 3;

            var actualOutput = HIndex(citations);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        public static int HIndex(int[] citations)
        {
            int n = citations.Length;
            Array.Sort(citations);
            for (int i = 0; i < n; i++)
            {
                if (citations[i] >= n - i) 
                    return n - i;
            }
            return 0;
        }
        public static int HIndex_2(int[] citations)
        {
            // REF => https://en.wikipedia.org/wiki/H-index
            //Formally, if f is the function that corresponds to the number of citations for each publication,
            //we compute the h-index as follows:
            //STEP - 1 : Order the values of f from the largest to the lowest value.
            //STEP - 2 : Look for the last position in which f is greater than or equal to the position (we call h this position).          
            
            //STEP - 1
            Array.Sort(citations);
            // Array.Reverse(citations);

            //If input contains any 0, we can remove it
            //int[] cits = new int[len-1];
            List<int> cits = new List<int>();
            //if (citations.Contains(0))
            {
                for (int i = 0; i < citations.Length; i++)
                {
                    if (citations[i] != 0)
                        cits.Add (citations[i]);
                }
            }
            
            int len = cits.Count;
            if (len == 1)
            {
                if (cits[0] > len)
                    return len;
                else
                    return cits[0];
            }
            else if (len <= 0)
                return 0;

            int[] hICnt = new int[len];
            for (int i = 0; i < len; i++)
            {
                int hi = cits[i];
                hICnt[i] = 0;

                for (int j = 0; j < len; j++)
                {
                    if (cits[j] >= hi)
                        hICnt[i]++;
                }
            }

            //STEP - 2
            // for (int i = len-1; i >= 0; i--)
            for (int i = len-1; i >= 0; i--)
            {
                if (hICnt[i] >= i)
                    return i + 1;
            }
            return 0;
        }
        public static int HIndex_1(int[] citations)
        {

            int len = citations.Length;
            if (len == 1)
            {
                if (citations[0] > len)
                    return len;
                else
                    return citations[0];
            }
            else if (len <= 0)
                return 0;

            int[] hICnt = new int[len];
            Array.Sort(citations);
            for (int i = 0; i < len; i++)
            {
                int hi = citations[i]; 
                hICnt[i] = 0;
                
                for (int j = 0; j< len; j++)
                {
                    if (citations[j] >= hi)
                        hICnt[i]++;
                }
            }

            for (int i = 0; i < len; i++)
            {
                int hi = citations[i];
                if (hICnt[i] >= hi)
                {
                    //do nothing
                    if (i == len - 1)
                        return citations[i];
                }
                else
                {
                    if (i > 0)
                        return citations[i - 1];
                    else
                        return citations[i];
                }
            }
            return 0;
        }
    }
}
