using System.Collections.Generic;

namespace LeetcodeTasks.ContainsDuplicates2
{
    public class ContainsDuplicates2
    {
        public int[] _nums;
        public int _k;

        public ContainsDuplicates2(int[] nums, int k)
        {
            _nums = nums;
            _k = k;
        }


        public bool IsThereDuplicates()
        {
            if (_nums == null || _nums.Length == 0) return false;

            if (_nums.Length == 1) return false;

            if (_nums.Length == 2) return _nums[1] == _nums[0] && 1 <= _k;

            var temp = new Dictionary<int,int>();


            for (int i = 0; i < _nums.Length; i++)
            {
                if (temp.ContainsKey(_nums[i]))
                {
                    var tempK = i - temp[_nums[i]];
                    if (tempK <= _k) return true;
                    temp.Remove(_nums[i]);
                    temp.Add(_nums[i],i);
                }
                else
                {
                    temp.Add(_nums[i],i);
                }
            }

            return false;


        }
    }
}