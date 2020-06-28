using System.Collections.Generic;

namespace LeetcodeTasks.PrintPaskal
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            return (new PrintPaskalTriangle(numRows)).GetPaskalTriangle();
        }
    }
}