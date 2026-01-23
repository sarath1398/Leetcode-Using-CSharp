
namespace Arrays
{
    // Leetcode : 122 - Best Time to Buy and Sell Stock II
    // Approach : Greedy / One Pass
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Medium
    public class BestTimeToBuyAndSellStocksII
    {
        public static int MaxProfit(int[] prices)
        {
            int p = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                p += Math.Max(0, prices[i] - prices[i - 1]);
            }
            return p;
        }
    }
}