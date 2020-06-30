using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetcodeTasks.MaxProfit2
{
    public class MaxProfit2
    {
        private int[] _prices;

        public MaxProfit2(int[] prices)
        {
            _prices = prices;
        }

        public int GetMaxProfit1()
        {
            if (_prices == null || _prices.Length == 0) return 0;

            return calculate(_prices, 0);
        }



        public int calculate(int[] prices, int s)
        {
            if (s >= prices.Length)
                return 0;
            int max = 0;
            for (int start = s; start < prices.Length; start++)
            {
                int maxprofit = 0;
                for (int i = start + 1; i < prices.Length; i++)
                {
                    if (prices[start] < prices[i])
                    {
                        int profit = calculate(prices, i + 1) + prices[i] - prices[start];
                        if (profit > maxprofit)
                            maxprofit = profit;
                    }
                }

                if (maxprofit > max)
                    max = maxprofit;
            }

            return max;
        }

        public int GetMaxProfit2()
        {
            if (_prices == null || _prices.Length == 0) return 0;

            int i = 0;
            int valley = _prices[0];
            int peak = _prices[0];
            int maxprofit = 0;
            while (i < _prices.Length - 1)
            {
                while (i < _prices.Length - 1 && _prices[i] >= _prices[i + 1])
                    i++;
                valley = _prices[i];
                while (i < _prices.Length - 1 && _prices[i] <= _prices[i + 1])
                    i++;
                peak = _prices[i];
                maxprofit += peak - valley;
            }

            return maxprofit;




        }
    }
}