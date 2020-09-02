using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetcodeTasks.ExcelSheetColumnTitle
{
    public class NumberToITitleConverter
    {

        private const int LettersCount = 26;
        private int _column;
        
        public NumberToITitleConverter(int column)
        {
            _column = column;
        }

        public string ConvertToTitle()
        {
            if (_column < 1) return string.Empty;

            StringBuilder ans = new StringBuilder();
            while (_column > 0)
            {
                _column--;
                ans.Insert(0, (char) (_column % LettersCount + 'A'));
                _column /= LettersCount;
            }

            return ans.ToString();
        }

        
    }
}