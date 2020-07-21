using System.Collections.Generic;

namespace LeetcodeTasks.KDiffpairsArray
{
    public class KDiffPairsArray
    {
        private int[] _nums;
        private int _k;

        public KDiffPairsArray(int[] nums, int k)
        {
            _nums = nums;
            _k = k;
        }

        public int GetKDiffPairsCount()
        {
            if (_nums == null || _nums.Length == 0) return 0;
            
            if (_k < 0) return 0;
            
            var main = new HashSet<int>();
            var repeat =  new HashSet<int>();

            foreach (var num in _nums)
            {
                if (main.Contains(num))
                {
                    repeat.Add(num);
                }
                else main.Add(num);
            }

            if (_k == 0) return repeat.Count;

            var result = 0;
            foreach (var num in main)
            {
                if (main.Contains(num + _k))
                {
                    result++;
                }
            }
            return result;
        }
        
    }
}