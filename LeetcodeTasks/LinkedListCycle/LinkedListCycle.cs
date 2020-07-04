using System.Collections.Generic;
using LeetcodeTasks.Base;

namespace LeetcodeTasks.LinkedListCycle
{
	public class LinkedListCycle
	{
		private readonly ListNode _head = null;

		public LinkedListCycle(ListNode head)
		{
			_head = head;
		}

		public bool IsCycled()
		{
			if (_head == null || _head.next == null) return false;

			var set = new HashSet<ListNode>();
			var current = _head;

			while(true)
			{
				if (set.Contains(current.next))
					return true;
				if (current.next == null)
					return false;
				set.Add(current);
				current = current.next;
			}

			return false;

		}

		public bool IsCycled2()
		{
			if (_head == null || _head.next == null) return false;

			var slow = _head;
			var fast = _head.next;

			while(slow != fast)
			{
				if (fast == null || fast.next == null)
					return false;
				slow = slow.next;
				fast = fast.next.next;
			}

			return true;
		}


	}
}