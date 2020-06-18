namespace LeetcodeTasks.RemoveDuplicatesLinkedList
{
    public class RemoveDuplicatesLinkedList
    {
        private readonly ListNode _head;

        public RemoveDuplicatesLinkedList(ListNode head)
        {
            _head = head;
        }


        public ListNode RemoveDuplicates()
        {
            ListNode current = _head;

            while(current != null)
            {
                if (current.next != null && current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return _head;
        }

    }
}