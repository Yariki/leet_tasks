using System;
using System.Text.RegularExpressions;

namespace LeetcodeTasks.FIndMaxAverage
{
    public class FindMaxAverage
    {
        private int[] _nums;
        private int _k;

        public FindMaxAverage(int[] nums, int k)
        {
            _nums = nums;
            _k = k;
        }

        public double GetMaxAverage()
        {
            if (_nums == null || _nums.Length == 0) return 0;
            if (_k == 0) return 0;
            if (_nums.Length < _k) return 0;

            double avg = double.MinValue;
            double sum = 0;

            for (int i = 0; i < _k; i++)
            {
                sum += _nums[i];
            }

            avg = Math.Max(avg, sum / _k);

            for (int i = _k; i < _nums.Length; i++)
            {
                sum -= _nums[i - _k];
                sum += _nums[i];
                avg = Math.Max(avg, sum / _k);
            }

            return avg;
        }
    }
}