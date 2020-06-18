namespace LeetcodeTasks.RemoveDuplicatesLinkedList
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var removeDuplicates= new RemoveDuplicatesLinkedList(head);
            return removeDuplicates.RemoveDuplicates();
        }
    }
}