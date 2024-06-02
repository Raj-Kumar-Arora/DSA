using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_05_Easy
    {
        public static void MaxProfit()
        {
            ////Case - 1
            //int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

            ////Case - 2
            //int[] prices = new int[] { 7, 6, 4, 3, 1 };

            ////CASE - 3
            //int[] prices = new int[] { 2,2,2, 2, 2, 2, 2};

            //Case - 4
            //int[] prices = new int[] { 1,2,3,4,5 };

            //Case - 5
            //int[] prices = new int[] { 2,4,1 };

            //Case - 6
            int[] prices = new int[] { 3,5,2,1 };

            int k = MaxProfit(prices);

            Console.WriteLine("k = " + k);
        }
        public static int MaxProfit(int[] prices)
        {
            int buyingPrice = prices[0];
            int profit = 0;     //profile cannt be < 0 | No Loss

            // Let i = dayIndex on which new price is available
            for (int i = 1; i < prices.Length; i++)
            {
                int newPrice = prices[i];
                // As per problem statement, on new Day either we can buy or sell
                // but we cannot do both buy and sell on same day
                // so we choose based on condition if new Price is lower than old buy price

                if (newPrice < buyingPrice)
                    buyingPrice = newPrice;
                else
                {
                    //sell if new profit is higher than earlier
                    int newProfit = (newPrice - buyingPrice);
                    if (newProfit > profit)
                        profit = (newPrice - buyingPrice);
                }
            }

            return profit;

            //Approach - 2
            //for (int i = 1; i < prices.Length; i++)
            //{
            //    int newPrice = prices[i];
            //    //buy if newPrice is lower and profile is increasing
            //    //to decide if we should buy when newPrice is 2 in cases like [3,5,2,1]
            //    if (newPrice < buyingPrice && (newPrice - buyingPrice) > profit)
            //        buyingPrice = newPrice;

            //    //Calculate profile based on buyingPrice if its updated 
            //    if ((newPrice - buyingPrice) > profit)
            //        profit = (newPrice - buyingPrice); 
            //}

            return profit;

            //Approach - 1
            //if (prices.Length < 2) 
            //    return 0;           //full week data not available

                //int d1 = 0; //day of buying stock 
                //int d2 = 1; //day of selling stock

                //for (int i = 1; i < prices.Length; i++)
                //{
                //    //if current price is lower than earlier buy on ith day
                //    // and DONT allow to buy on last day
                //    if (prices[i] < prices[d1] && i != prices.Length - 1) 
                //     d1 = i;

                //    if (prices[i] > prices[d2]) //if current price is higher than earlier sell on ith day
                //        d2 = i;
                //}

                //if (d1 > d2) return 0;
                //else 
                //    return prices[d2] - prices[d1];
        }
    }
}
