using NUnit.Framework;

namespace LeetcodeTasks.MergeTwoSortedLinkedLists
{
    [TestFixture]
    public class MergeTwoSortedLinkedListTest
    {
        [Test]
        public void TwoSortedListWithSameCountButDifferentNumbers_ShouldSucceeded()
        {
            var l1 = new ListNode(1,new ListNode(3,new ListNode(5)));
            var l2= new ListNode(2,new ListNode(4,new ListNode(6)));
            
            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            
            Assert.NotNull(result);
        }
        
        [Test]
        public void TwoSortedListWithDiffCountAndDiffNumbers_ShouldSucceeded()
        {
            var l1 = new ListNode(1,new ListNode(1,new ListNode(5, new ListNode(10))));
            var l2= new ListNode(2,new ListNode(4,new ListNode(6, new ListNode(9, new ListNode(20, new ListNode(21))))));
            
            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            
            Assert.NotNull(result);
        }
        
        [Test]
        public void TwoSortedList_FirstNull_SecondWithOneElement_ShouldSucceeded()
        {
            ListNode l1 = null;
            var l2= new ListNode(0);
            
            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            
            Assert.NotNull(result);
        }
        
        
        
    }
}