using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetcodeTasks.ValidPalindrome
{
	public class ValidPalindrome
	{
		private readonly string _str;

		public ValidPalindrome(string str)
		{
			_str = str;
		}

		public bool IsPalindrome()
		{
			if (string.IsNullOrWhiteSpace(_str)) return true;
			var str = _str.ToLowerInvariant();
			str = Regex.Replace(str, "(\\s|\\W|_)", "");

			int begin = 0, end = str.Length - 1;

			while(begin <= end)
			{
				if(str[begin] != str[end])
				{
					return false;
				}
				begin++;
				end--;
			}
			return true;
		}

		public bool IsPalindrome2()
		{
			if (string.IsNullOrWhiteSpace(_str)) return true;
			var str = _str.ToLowerInvariant();

			int begin = 0, end = str.Length - 1;

			while (begin <= end)
			{
				var bCh = str[begin];
				var eCh = str[end];

				if (!char.IsLetter(bCh) && !char.IsDigit(bCh))
				{
					begin++;
					continue;
				}

				if (!char.IsLetter(eCh) && !char.IsDigit(eCh))
				{
					end--;
					continue;
				}

				if (str[begin] != str[end])
				{
					return false;
				}
				begin++;
				end--;
			}
			return true;
		}


		



	}
}