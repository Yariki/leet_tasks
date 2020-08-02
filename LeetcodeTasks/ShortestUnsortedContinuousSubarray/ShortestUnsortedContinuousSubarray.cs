using System;

namespace LeetcodeTasks.ShortestUnsortedContinuousSubarray
{
    public class ShortestUnsortedContinuousSubarray
    {
        private readonly int[] _nums;

        public ShortestUnsortedContinuousSubarray(int[] nums)
        {
            _nums = nums;
        }

        public int GetLength()
        {
            if (_nums == null || _nums.Length == 0) return 0;

            int max = int.MinValue;

            int f = -1, s = -1;

            for (int i = 0; i < _nums.Length - 1; i++)
            {
                if (f == -1 && _nums[i] > _nums[i + 1])
                {
                    max = Math.Max(max, _nums[i]);
                    f = i;
                }
                else if (f > -1 && _nums[i] > _nums[i + 1])
                {
                    max = Math.Max(max, _nums[i]);
                    s = i + 1;
                }
            }

            return f > -1 && s > -1 ? (s - f) + 1 : f > -1 && s == -1 ? 2 : 0;
        }
    }
}