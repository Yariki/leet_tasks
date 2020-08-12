using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeTasks.MaxProduct
{
    public class MaxProduct
    {
        private int[] _nums;

        public MaxProduct(int[] nums)
        {
            _nums = nums;
        }

        public int GetMaxProduct()
        {
            if (_nums == null) return 0;
            if (_nums.Length < 3) return 0;

            Array.Sort(_nums);
            var list = new List<int>();
            list.Add(_nums[_nums.Length - 1] * _nums[_nums.Length - 2] * _nums[_nums.Length - 3]);

            if (_nums[0] < 0 && _nums[1] < 0)
            {
                list.Add(_nums[_nums.Length - 1] * _nums[0] * _nums[1]);
            }

            return list.Max(p => p);

        }


        public int GetMaxProduct2()
        {
            if (_nums == null) return 0;
            if (_nums.Length < 3) return 0;

            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            for (int i = 0; i < _nums.Length; i++)
            {
                var n = _nums[i];
                if (n <= min1)
                {
                    min2 = min1;
                    min1 = n;
                } else if (n <= min2)
                {
                    min2 = n;
                }

                if (n >= max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = n;
                } else if (n >= max2)
                {
                    max3 = max2;
                    max2 = n;
                }else if (n >= max3)
                {
                    max3 = n;
                }
            }

            return Math.Max(min1 * min2 * max1, max1 * max2 * max3);
        }

    }

}