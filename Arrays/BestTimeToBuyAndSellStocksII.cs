
namespace Arrays
{
    public class BestTimeToBuyAndSellStocksII
    {
        public int MaxProfit(int[] prices)
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