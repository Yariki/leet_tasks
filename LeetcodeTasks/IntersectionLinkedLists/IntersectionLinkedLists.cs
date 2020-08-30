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

            var currentA = _headA;

            while (currentA != null)
            {
                var currentB = _headB;
                while (currentB != null)
                {
                    if (currentA.val == currentB.val && CheckPossibleIntersaction(currentA, currentB))
                    {
                        return currentA;
                    }
                    currentB = currentB.next;
                }
                currentA = currentA.next;
            }
            return null;
        }

        public ListNode GetIntersectionNode2()
        {
            if (_headA == null || _headB == null) return null;

            var p1 = _headA;
            var p2 = _headB;

            while (p1 != p2)
            {
                p1 = p1.next;
                p2 = p2.next;

                if (p1 == p2)
                {
                    return p1;
                }

                if (p1 == null)
                {
                    p1 = _headB;
                }

                if (p2 == null)
                {
                    p2 = _headA;
                }
            }
            return p1;
        }



        private bool CheckPossibleIntersaction(ListNode a, ListNode b)
        {
            while (a != null && b != null)
            {
                if (a.val != b.val)
                {
                    return false;
                }
                a = a.next;
                b = b.next;
            }
            return a == null && b == null;
        }

    }
}