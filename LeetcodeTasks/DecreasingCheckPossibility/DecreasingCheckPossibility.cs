using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetcodeTasks.DecreasingCheckPossibility
{
    public class DecreasingCheckPossibility
    {
        private int[] _nums;

        public DecreasingCheckPossibility(int[] nums)
        {
            _nums = nums;
        }

        public bool CheckPossibility()
        {
            if (_nums == null || _nums.Length == 0) return false;

            int count = 0;
            int lastIndex = 0;

            for (int i = 1; i < _nums.Length; i++)
            {
                if (_nums[i] < _nums[i - 1])
                {
                    count++;
                    lastIndex = i;
                }
            }

            if (count > 1) 
                return false;

            if (count == 0) 
                return true;

            if (lastIndex == 1 || lastIndex == _nums.Length - 1) 
                return true;

            if (_nums[lastIndex + 1] < _nums[lastIndex - 1] && _nums[lastIndex] < _nums[lastIndex - 2])
                return false;


            return true;
        }

    }
}