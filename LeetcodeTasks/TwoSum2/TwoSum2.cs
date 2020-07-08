using System;
using NuGet.Frameworks;

namespace LeetcodeTasks.TwoSum2
{
    public class TwoSum2
    {
        private readonly int[] _numbers;
        private readonly int _target;

        public TwoSum2(int[] numbers, int target)
        {
            _numbers = numbers;
            _target = target;
        }

        public int[] GetTwoSum()
        {
            if (_numbers == null || _numbers.Length == 0)
            {
                return default(int[]);
            }

            int l  = 0, r = _numbers.Length - 1;

            while (l < r)
            {
                var sum = _numbers[l] + _numbers[r];
                if (sum > _target)
                {
                    r--;
                }
                else if (sum < _target)
                {
                    l++;
                }
                else
                {
                    return new int[]{l+1, r+ 1};
                }
            }

            return new int[]{};
        }

    }
}