using LeetcodeTasks.Base;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LeetcodeTasks.IntersectionLinkedLists
{
    public class IntersectionLinkedListsTest
    {
        [Test]
        public void ListNull_Success()
        {
            ListNode headA = null;
            ListNode headB = null;

            var sol = new Solution();
            var result = sol.GetIntersectionNode(headA, headB);

            Assert.IsNull(result);
        }



        [Test]
        public void FirstListsWithIntersection_Success()
        {
            var listInter = new ListNode(2, new ListNode(4));
            var listA = new ListNode(1,new ListNode(9, new ListNode(1, listInter)));
            var listB = new ListNode(3,listInter);
            var sol = new Solution();
            var result = sol.GetIntersectionNode(listA, listB);

            Assert.IsNotNull(result);
        }

        [Test]
        public void SecondListsWithoutIntersection_Success()
        {
            var listA = new ListNode(2, new ListNode(6, new ListNode(4)));
            var listB = new ListNode(1, new ListNode(5));
            var sol = new Solution();
            var result = sol.GetIntersectionNode(listA, listB);

            Assert.IsNull(result);
        }

    }
}