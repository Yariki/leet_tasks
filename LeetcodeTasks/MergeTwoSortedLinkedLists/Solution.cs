namespace LeetcodeTasks.MergeTwoSortedLinkedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
        {
            var mergeTwoSorterLinkedList = new MergeTwoSortedLinkedList(l1, l2);
            return mergeTwoSorterLinkedList.SolutionOne();
        }
    }
}