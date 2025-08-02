using DSA.Trees;
namespace LeetCodeProblems.Top_15_Patterns
{
    public class LeetCodePatterns_9_13
    {
        public static void NextGreaterElement()
        {
            ////Case - 1
            int[] nums1 = { 4, 1, 2 };
            int[] nums2 = { 1, 3, 4, 2 };

            var actualOutput = NextGreaterElement(nums1, nums2);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }

        private static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int n = nums2.Length;
            Stack<int> st = new Stack<int>();
            int[] nextGreater = new int[n];
            for (int i = 0; i < n; i++)
            {
                nextGreater[i] = -1;
                while (st.Any() && nums2[st.Peek()] < nums2[i])
                    nextGreater[st.Pop()] = nums2[i];
                st.Push(i);
            }

            int m = nums1.Length;
            Dictionary<int, int> dict = new();
            int[] ans = new int[m];
            for (int i = 0; i < n; i++)
                dict[nums2[i]] = i;

            for (int i = 0; i < m; i++)
                ans[i] = nextGreater[dict[nums1[i]]];

            return ans;
        }
    }
}
