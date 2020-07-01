namespace LeetcodeTasks.ValidPalindrome
{
	public class Solution
	{
		public bool IsPalindrome(string s)
		{
			var valid = new ValidPalindrome(s);
			return valid.IsPalindrome();
		}
	}
}