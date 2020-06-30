namespace LeetcodeTasks.MaxProfit1
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var profit = new MaxProfit1(prices);
            return profit.GetMaxProfit();
        }
    }
}