using System.Collections.Generic;

namespace LeetcodeTasks.CanPlaceFlowers
{
    public class CanPlaceFlowers
    {
        private int[] _nums;
        private int _n;

        public CanPlaceFlowers(int[] nums, int n)
        {
            _nums = nums;
            _n = n;
        }

        public bool CanFlowersBePlaced()
        {
            if (_n == 0) return true;
            if (_nums == null || _nums.Length == 0) return false;
            if (_nums.Length == 1 && _nums[0] == 0 && _n == 1) return true;

            int i = 0, count = 0;
            while (i < _nums.Length)
            {
                if (_nums[i] == 0 && (i == 0 || _nums[i - 1] == 0) && (i == _nums.Length - 1 || _nums[i + 1] == 0))
                {
                    _nums[i] = 1;
                    count++;
                }
                i++;
            }
            return count >= _n;
        }
    }
}