using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LeetcodeTasks.MissingNumber
{
	public class MissingNumberTests
	{
		[Test]
		public void NullOremptyArray_Success()
		{
			int[] arr = null;
			var sol = new MissingNumber(arr);
			var result = sol.GetMissingNumner();

			Assert.AreEqual(-1, result);
		}

		[Test]
		public void FirstArray_Success()
		{
			int[] arr = { 3,0,1};
			var sol = new MissingNumber(arr);
			var result = sol.GetMissingNumner();

			Assert.AreEqual(2, result);
		}


		[Test]
		public void SecondArray_Success()
		{
			int[] arr = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
			var sol = new MissingNumber(arr);
			var result = sol.GetMissingNumner();

			Assert.AreEqual(8, result);
		}

		//============================================================

		[Test]
		public void SecondArray_SecondApproach_Success()
		{
			int[] arr = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
			var sol = new MissingNumber(arr);
			var result = sol.GetMissingNumberBits();

			Assert.AreEqual(8, result);
		}
	}
}