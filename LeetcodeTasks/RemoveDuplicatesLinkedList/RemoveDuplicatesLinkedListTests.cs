using System.Diagnostics;
using NUnit.Framework;

namespace LeetcodeTasks.RemoveDuplicatesLinkedList
{
    public class RemoveDuplicatesLinkedListTests
    {


        [Test]
        public void FirstCase()
        {
            var sol= new RemoveDuplicatesLinkedList(new ListNode(1, new ListNode(1, new ListNode(2))));
            var result = sol.RemoveDuplicates();

            Assert.True(IsListEquals(new ListNode(1, new ListNode(2)), result));
        }

        [Test]
        public void SecondCase()
        {
            var sol = new RemoveDuplicatesLinkedList(new ListNode(1, new ListNode(2, new ListNode(3))));
            var result = sol.RemoveDuplicates();

            Assert.True(IsListEquals(
                new ListNode(1, new ListNode(2, new ListNode(3))), result));
        }


        private bool IsListEquals(ListNode expected, ListNode actual)
        {
            if (expected == null && actual == null)
            {
                return true;
            }

            ListNode currentExpected = expected;
            ListNode currentActual = actual;

            while (true)
            {
                if (currentExpected != null && currentActual != null && currentExpected.val != currentActual.val)
                {
                    return false;
                }

                if (currentExpected == null && currentActual == null)
                {
                    return true;
                }

                currentExpected = currentExpected.next;
                currentActual = currentActual.next;
            }
        }

    }
}