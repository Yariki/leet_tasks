using System;
using System.Collections.Generic;

namespace LeetcodeTasks.ArrayPartition1
{
    public class ArrayPartition1
    {
        private int[] _nums;

        public ArrayPartition1(int[] nums)
        {
            _nums = nums;
        }

        public int GetSumOfMin()
        {
            if (_nums == null || _nums.Length == 0) return 0;

            Array.Sort(_nums);

            var sum = 0;

            for (int i = 0; i < _nums.Length - 1; i += 2)
            {
                sum += _nums[i];
            }

            return sum;
        }

    }
}