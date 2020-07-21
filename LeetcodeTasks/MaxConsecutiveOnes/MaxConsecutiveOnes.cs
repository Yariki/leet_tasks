namespace LeetcodeTasks.MaxConsecutiveOnes
{
    public class MaxConsecutiveOnes
    {
        private int[] _nums;

        public MaxConsecutiveOnes(int[] nums)
        {
            _nums = nums;
        }


        public int GetMaxConsecutiveOnes()
        {
            if (_nums == null || _nums.Length == 0) return 0;

            int max = 0;
            int current = 0;

            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] > 0)
                {
                    current += _nums[i];
                }
                else if (_nums[i] == 0)
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    current = 0;
                }
            }

            if (current > max) max = current;

            return max;
        }

    }
}