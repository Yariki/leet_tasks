using System.Diagnostics;

namespace LeetcodeTasks.ExcelSheetColumnTitle
{
    public class Solution2
    {
        public int TitleToNumber(string s) 
        {
            var sol = new TitleToNumberConverter(s);
            return sol.TitleToNumber();
        }
    }
}