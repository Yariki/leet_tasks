namespace LeetcodeTasks.MergeTwoSortedLinkedLists
{
    public class MergeTwoSortedLinkedList
    {
        private readonly ListNode _first;
        private readonly ListNode _second;

        public MergeTwoSortedLinkedList(ListNode first, ListNode second)
        {
            _first = first;
            _second = second;
        }

        public ListNode SolutionOne()
        {
            var left = _first;
            var right = _second;
            ListNode start = null;
            ListNode current = null;

            while (left != null && right != null)
            {
                if (left.val <= right.val)
                {
                    if (start == null)
                    {
                        current = start = left;
                    }
                    else
                    {
                        current = current.next = left;
                    }
                    left = left.next;
                }
                else
                {
                    if (start == null)
                    {
                        current = start = right;
                    }
                    else
                    {
                        current = current.next = right;
                    }
                    right = right.next;    
                }
            }

            if (left != null)
                while (left != null)
                {
                    if (start == null)
                    {
                        current = start = left;
                    }
                    else
                    {
                        current = current.next = left;
                    }
                    left = left.next;
                }

            if (right != null)
                while (right != null)
                {
                    if (start == null)
                    {
                        current = start = right;
                    }
                    else
                    {
                        current = current.next = right;
                    }
                    right = right.next;
                }

            return start;
        }
        
    }
}