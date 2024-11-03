namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_49_Medium
    {
        public static void CanCompleteCircuit()
        {
            ////Case - 1
            //int[] gas = { 1, 2, 3, 4, 5 };
            //int[] cost = { 3, 4, 5, 1, 2 };
            //int expOut = 3;

            ////Case - 2
            //int[] gas = { 3, 4, 5, 1, 2};
            //int[] cost = { 1, 2, 3, 4, 5};
            //int expOut = 0;

            //CASE - 3
            int[] gas =  { 2, 3, 4  };
            int[] cost = { 3, 4, 3 };
            //int expOut = 0;

            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = CanCompleteCircuit(gas, cost);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        //TEST CASES PASSED - but its taking too long so its not getting submitted
        //tHIS ERROR IS NOW FIXED
        public static int CanCompleteCircuit_MY(int[] gas, int[] cost)
        {
            int len = gas.Length;
            if (len != cost.Length) return 0;

            //This line fixes ERROR AT SUBMISSION - "TEST CASES PASSED - but its taking too long so its not getting submitted"
            if (gas.Sum() < cost.Sum()) return -1;

            int i = 0;
            for (i = 0; i < len; i++)
            {
                int fuel = 0;

                int j = i;
                for (j = i; j < len; j++)
                {
                    fuel += gas[j] - cost[j];
                    if (fuel < 0)
                        break;
                }

                if (j == len)
                {
                    for (j = 0; j < i; j++)
                    {
                        fuel += gas[j] - cost[j];
                        if (fuel < 0)
                            break;
                    }
                    if (fuel < 0)
                        return -1;
                    else
                        return i;
                }
            }

            return -1;
        }

        //optimized from my way looking at leetcode solutions
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int len = gas.Length;
            if (len != cost.Length) return 0;

            //This line fixes ERROR AT SUBMISSION - "TEST CASES PASSED - but its taking too long so its not getting submitted"
            if (gas.Sum() < cost.Sum()) return -1;

            int fuel = 0;
            int si = 0; //start index

            for (int j = 0; j < len; j++)
            {
                fuel += gas[j] - cost[j];
                if (fuel < 0)
                {
                    fuel = 0;
                    si = j+1;
                }
            }
            return si;
        }

        //TODO Understand this solution - popular C# from leetcode
        public static int CanCompleteCircuit_1(int[] gas, int[] cost)
        {
            // Index from end operator ^
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#index-from-end-operator-
            int t1 = gas[^1];
            int t2 = gas[^2];
            int t3 = cost[^1];
            int t4 = cost[^2];

            int sum = gas[^1] - cost[^1];
            int maxIndex = gas.Length - 1;
            int maxSum = sum;

            for (int i = gas.Length - 2; i >= 0; i--)
            {
                sum += gas[i] - cost[i];
                if (sum > maxSum)
                {
                    maxIndex = i;
                    maxSum = sum;
                }
            }

            if (sum < 0) return -1;
            return maxIndex;
        }

    }
}
