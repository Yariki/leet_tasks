using System.Numerics;

namespace LeetcodeTasks.FactorialTrailingZeros
{
    public class FactorialTrailingZeros
    {

        private int _n;

        public FactorialTrailingZeros(int n)
        {
            _n = n;
        }


        public int TrailingZeroes()
        {
            int count = 0;

            while (_n > 0)
            {
                count += (_n / 5);
                _n = _n / 5;
            }

            return count;
        }
    }
}