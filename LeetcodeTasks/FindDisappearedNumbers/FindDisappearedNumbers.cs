using System;
using System.Collections.Generic;

namespace LeetcodeTasks.FindDisappearedNumbers
{
    public class FindDisappearedNumbers
    {
        private int[] _nums;

        public FindDisappearedNumbers(int[] nums)
        {
            _nums = nums;
        }

        public IList<int> GetFindDisappearedNumbers()
        {

            if(_nums == null || _nums.Length == 0) return new List<int>();

            for (int i = 0; i < _nums.Length; i++)
            {
                var index = Math.Abs(_nums[i]) - 1;
                _nums[index] = Math.Abs(_nums[index]) * -1;
            }

            var list = new List<int>();

            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] > 0)
                {
                    list.Add(i + 1);
                }
            }
            return list;
        }

        public IList<int> GetFindDisappearedNumbers2()
        {
            if (_nums == null || _nums.Length == 0) return new List<int>();

            var missing = _nums.Length;
            var missingNums = new List<int>();

            for (int i = 0; i < _nums.Length; i++)
            {
                var findNum = i + 1;
                bool find = false;
                for (int j = 0; j < _nums.Length; j++)
                {
                    if (findNum == _nums[j])
                    {
                        find = true;
                        break;
                    }
                }

                if (!find)
                {
                    missingNums.Add(findNum);
                }
            }

            return missingNums;
        }

    }
}