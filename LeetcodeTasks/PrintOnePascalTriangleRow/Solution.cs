using System.Collections.Generic;

namespace LeetcodeTasks.PrintOnePascalTriangleRow
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            return (new PrintOnePaskalTriangleRow(rowIndex)).GetOneRow();
        }
    }
}