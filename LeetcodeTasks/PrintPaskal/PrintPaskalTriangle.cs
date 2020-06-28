using System.Collections.Generic;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace LeetcodeTasks.PrintPaskal
{
    public class PrintPaskalTriangle
    {
        private readonly int _nums;

        public PrintPaskalTriangle(int nums)
        {
            _nums = nums;
        }



        public IList<IList<int>> GetPaskalTriangle()
        {
            if (_nums == 0)
            {
                return new List<IList<int>>();
            }

            var lists = new List<IList<int>>();

            for (int line = 0; line < _nums; line++)
            {
                var list = new List<int>();
                for (int i = 0; i <= line; i++)
                {
                    list.Add(BinominalCoeff(line, i));
                }
                lists.Add(list);
            }

            return lists;
        }

        int BinominalCoeff(int n, int k)
        {
            int res = 1;
            if (k > n - k)
                k = n - k;
            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }

            return res;
        }




    }
}