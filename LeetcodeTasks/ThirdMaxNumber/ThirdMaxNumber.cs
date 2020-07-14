namespace LeetcodeTasks.ThirdMaxNumber
{
    public class ThirdMaxNumber
    {
        private int[] _nums;

        public ThirdMaxNumber(int[] nums)
        {
            _nums = nums;
        }

        public int GetThirdMax()
        {
            if (_nums == null || _nums.Length == 0) return 0;

            double max = _nums[0];
            double sMax = double.NegativeInfinity;
            double tMax = double.NegativeInfinity;

            for (int i = 0; i < _nums.Length; i++)
            {
                var current = _nums[i];
                if (current > max)
                {
                    tMax = sMax;
                    sMax = max;
                    max = current;
                }
                else if (current > sMax && current < max)
                {
                    tMax = sMax;
                    sMax = current;
                }
                else if (current > tMax && current < sMax)
                {
                    tMax = current;
                }
            }

            return tMax == double.NegativeInfinity? (int)max : (int)tMax;
        }

    }
}