namespace LeetcodeTasks.ExcelSheetColumnTitle
{
    public class Solution
    {
        public string ConvertToTitle(int n) 
        {
            var sol = new NumberToITitleConverter(n);
            return sol.ConvertToTitle();
        }
    }
}