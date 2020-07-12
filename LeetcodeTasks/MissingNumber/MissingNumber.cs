using System.Linq;

namespace LeetcodeTasks.MissingNumber
{
	public class MissingNumber
	{
		public readonly int[] _nums;


		public MissingNumber(int[] nums)
		{
			_nums = nums;
		}

		public int GetMissingNumner()
		{
			if (_nums == null || _nums.Length == 0) return -1;

			var expected = (_nums.Length * (_nums.Length + 1)) / 2;
			var actual = _nums.Sum();

			var num = expected - actual;

			return num;
		}

		public int GetMissingNumberBits()
		{
			if (_nums == null || _nums.Length == 0) return -1;

			var missing = _nums.Length;

			for (int i = 0; i < _nums.Length; i++)
			{
				missing ^= i ^ _nums[i];
			}

			return missing;
		}
	}
}