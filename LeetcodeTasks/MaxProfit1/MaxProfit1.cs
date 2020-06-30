using System;

namespace LeetcodeTasks.MaxProfit1
{
    public class MaxProfit1
    {
        private int[] _nums;

        public MaxProfit1(int[] nums)
        {
            _nums = nums;
        }

        public int GetMaxProfit()
        {
            if (_nums == null || _nums.Length == 0) return 0;
            int profit = 0;

            for (int i = 0; i < _nums.Length; i++)
            {
                for (int j = i + 1; j < _nums.Length; j++)
                {
                    profit = Math.Max(profit, _nums[j] - _nums[i]);
                }
            }

            return profit;
        }

        public int GetMaxProfit2()
        {
            if (_nums == null || _nums.Length == 0) return 0;

            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] < minPrice)
                {
                    minPrice = _nums[i];
                }
                else if (_nums[i] - minPrice > maxProfit)
                {
                    maxProfit = _nums[i] - minPrice;
                }
            }

            return maxProfit;
        }

    }
}