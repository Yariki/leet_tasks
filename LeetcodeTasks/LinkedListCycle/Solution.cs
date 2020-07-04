using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.LinkedListCycle
{
	public struct Solution
	{
		public bool HasCycle(ListNode head)
		{
			var cycle = new LinkedListCycle(head);
			return cycle.IsCycled();
		}
	}
}