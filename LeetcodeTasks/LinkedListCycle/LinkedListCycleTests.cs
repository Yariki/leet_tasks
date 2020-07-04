using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.LinkedListCycle
{
	public class LinkedListCycleTests
	{
		[Test]
		public void OneNode_Success_False()
		{
			var head = new ListNode(1);
			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled();

			Assert.False(result);
		}

		[Test]
		public void LinkedListWithCycle_Success_True()
		{
			var head = new ListNode(1);
			var second = new ListNode(2,head);
			head.next = second;
			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled();

			Assert.True(result);
		}

		[Test]
		public void LinkedLIstWithCycle_Success_True()
		{
			var head = new ListNode(3);
			var second = new ListNode(2);
			head.next = second;
			var third = new ListNode(0,new ListNode(-4,second));
			second.next = third;
			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled();

			Assert.True(result);
		}

		[Test]
		public void LInkedListWithOutCycle_Success_False()
		{
			var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled();

			Assert.False(result);
		}

		//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

		[Test]
		public void OneNode_SecondApproach__Success_False()
		{
			var head = new ListNode(1);
			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled2();

			Assert.False(result);
		}

		[Test]
		public void LinkedListWithCycle_SecondApproach_Success_True()
		{
			var head = new ListNode(1);
			var second = new ListNode(2, head);
			head.next = second;
			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled2();

			Assert.True(result);
		}

		[Test]
		public void LinkedLIstWithCycle_SecondApproach_Success_True()
		{
			var head = new ListNode(3);
			var second = new ListNode(2);
			head.next = second;
			var third = new ListNode(0, new ListNode(-4, second));
			second.next = third;
			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled2();

			Assert.True(result);
		}

		[Test]
		public void LInkedListWithOutCycle_SecondApproach_Success_False()
		{
			var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

			var linked = new LinkedListCycle(head);
			var result = linked.IsCycled2();

			Assert.False(result);
		}
	}
}