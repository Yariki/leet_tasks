namespace LeetcodeTasks.ExcelSheetColumnTitle
{
    public class TitleToNumberConverter
    {
        private const int LettersCount = 26;
        private string _title;

        public TitleToNumberConverter(string title)
        {
            _title = title;
        }


        public int TitleToNumber() 
        {
            int result = 0;
	
            for (int i = 0; i < _title.Length ; i++)
            {
                result = ((_title[i] - 'A') + 1) + result * 26;
            }
	
            return result;
        }
    }
}