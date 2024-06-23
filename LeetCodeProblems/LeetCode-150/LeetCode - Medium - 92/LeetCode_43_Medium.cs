namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_43_Medium
    {
        public static void MaxProfit()
        {
            ////Case - 1
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

            ////Case - 2
            //int[] prices = new int[] { 7, 6, 4, 3, 1 };

            ////CASE - 3
            //int[] prices = new int[] { 2,2,2, 2, 2, 2, 2};

            //Case - 4
            //int[] prices = new int[] { 1,2,3,4,5 };

            //Case - 5
            //int[] prices = new int[] { 2,4,1 };

            //Case - 6
            //int[] prices = new int[] { 3, 5, 2, 1 };

            int k = MaxProfit(prices);

            Console.WriteLine("Max profit  = " + k);
        }

        public static int MaxProfit(int[] prices)
        {
            int buyPrice = prices[0];
            int salePrice = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++) 
            {
                int val = prices[i];

                if (val < buyPrice)
                {
                    buyPrice = val;
                    salePrice = val; //update sale price wrt current buy price
                }

                if (val > salePrice)
                {
                    salePrice = val;

                    //if we are selling, reset buyPrice & update profit 
                    profit += (salePrice - buyPrice);
                    buyPrice = salePrice; //start from here
                }
            }

            return profit;
        }
    }
}
