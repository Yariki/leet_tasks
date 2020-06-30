namespace LeetcodeTasks.MaxProfit2
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var profit = new MaxProfit2(prices);
            return profit.GetMaxProfit2();
        }
    }
}