using LeetcodeTasks.Base;

namespace LeetcodeTasks.IntersectionLinkedLists
{
    public class IntersectionLinkedLists
    {
        private ListNode _headA;
        private ListNode _headB;

        public IntersectionLinkedLists(ListNode headA, ListNode headB)
        {
            _headA = headA;
            _headB = headB;
        }

        public ListNode GetIntersectionNode()
        {
            if (_headA == null || _headB == null) return null;

        }

    }
}