using DSA.Trees;
namespace LeetCodeProblems.Top_15_Patterns
{
    public class LeetCodePatterns_9_12
    {
        public static void TopKFrequent()
        {
            ////Case - 1
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            var actualOutput = TopKFrequent(nums, k);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }

        private static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> freqMap = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (freqMap.ContainsKey(nums[i]))
                    freqMap[nums[i]]++;
                else
                    freqMap[nums[i]] = 1;
            }

            //PriorityQueue<int, int> pq = new();
            //foreach (var key in freqMap.Keys)
            //{
            //    pq.Enqueue(key, freqMap[key]);
            //    if (pq.Count > k)
            //        pq.Dequeue();
            //}

            //int[] res = new int[k];
            //int j = k;

            //while (pq.Count > 0)
            //    res[--j] = pq.Dequeue();

            //return res;

            //alternative to above code of PQ is below one 
            var sortedFrequents = freqMap.OrderByDescending(pair => pair.Value);
            return sortedFrequents.Take(k).Select(pair => pair.Key).ToArray();
        }
    }
}
