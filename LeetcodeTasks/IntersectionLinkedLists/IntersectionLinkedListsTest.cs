using LeetcodeTasks.Base;
using NUnit.Framework;

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



    }
}