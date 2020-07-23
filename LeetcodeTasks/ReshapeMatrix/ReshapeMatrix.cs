namespace LeetcodeTasks.ReshapeMatrix
{
    public class ReshapeMatrix
    {
        private readonly int[][] _nums;
        private readonly int _r;
        private readonly int _c;

        public ReshapeMatrix(int[][] nums, int r, int c)
        {
            _nums = nums;
            _r = r;
            _c = c;
        }


        public int[][] GetRashapedMatrix()
        {
            if (_nums == null) return _nums;

            var r1 = _nums.GetLength(0);
            var c1 = _nums[0].Length;

            if ((r1 * c1) != (_r * _c)) return _nums;

            var arr2 = new int[_r][];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = new int[_c];
            }

            var lenght = r1 * c1;

            for (int i = 0; i < lenght; i++)
            {
                arr2[i / _c][i % _c] = _nums[i / c1][i % c1];
            }

            return arr2;
        }

    }
}