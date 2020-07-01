using NUnit.Framework;

namespace LeetcodeTasks.ValidPalindrome
{
	public class ValidPalindromeTests
	{
		[Test]
		public void EmptyString_Success()
		{
			var validPalindrome = new ValidPalindrome("");
			var result = validPalindrome.IsPalindrome();

			Assert.True(result);
		}

		[Test]
		public void FirstCase_Success_True()
		{
			var str = "A man, a plan, a canal: Panama";
			var validPalindrome = new ValidPalindrome(str);
			var result = validPalindrome.IsPalindrome();

			Assert.True(result);
		}

		[Test]
		public void SecondCase_Success_False()
		{
			var str = "race a car";
			var validPalindrome = new ValidPalindrome(str);
			var result = validPalindrome.IsPalindrome();

			Assert.False(result);
		}

		[Test]
		public void EmptyString_SecondApproach_Success()
		{
			var validPalindrome = new ValidPalindrome("");
			var result = validPalindrome.IsPalindrome2();

			Assert.True(result);
		}

		[Test]
		public void FirstCase_SecondApproach_Success_True()
		{
			var str = "A man, a plan, a canal: Panama";
			var validPalindrome = new ValidPalindrome(str);
			var result = validPalindrome.IsPalindrome2();

			Assert.True(result);
		}

		[Test]
		public void SecondCase_SecondApproach_Success_False()
		{
			var str = "race a car";
			var validPalindrome = new ValidPalindrome(str);
			var result = validPalindrome.IsPalindrome2();

			Assert.False(result);
		}

		[Test]
		public void ThirdCase_SecondApproach_Success_False()
		{
			var str = "0P";
			var validPalindrome = new ValidPalindrome(str);
			var result = validPalindrome.IsPalindrome2();

			Assert.False(result);
		}


	}
}