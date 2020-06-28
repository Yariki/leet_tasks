using System.Collections.Generic;

namespace LeetcodeTasks.PrintOnePascalTriangleRow
{
    public class PrintOnePaskalTriangleRow
    {
        private readonly int _row;

        public PrintOnePaskalTriangleRow(int row)
        {
            _row = row;
        }


        public IList<int> GetOneRow()
        {

            if(_row == 0) return new List<int>(){1};

            var list = new List<int>();

            for (uint i = 0; i <= _row; i++)
            {
                list.Add(BinominalCoeff((uint)_row, i));
            }

            return list;
        }
        int BinominalCoeff(uint n, uint k)
        {
            double res = 1;
            if (k > n - k)
                k = n - k;
            for (uint i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }

            return (int)res;
        }
    }
}