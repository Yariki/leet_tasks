using LeetcodeTasks.Base;

namespace LeetcodeTasks.IntersectionLinkedLists
{
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var sol = new IntersectionLinkedLists(headA, headB);
            return sol.GetIntersectionNode();
        }
    }
}