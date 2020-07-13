namespace LeetcodeTasks.MoveZeros
{
    public class MoveZeros
    {
        private int[] _nums;

        public MoveZeros(int[] nums)
        {
            _nums = nums;
        }


        public void MovesZeros()
        {
            if (_nums == null || _nums.Length == 1) return;

            int anch = 0;

            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] != 0)
                {
                    var temp = _nums[anch];
                    _nums[anch] = _nums[i];
                    _nums[i] = temp;
                    anch++;
                }
            }
        }
        
    }
}