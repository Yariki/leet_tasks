namespace LeetcodeTasks.RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val) 
        {
            var removeElement = new RemoveElement(nums,val);
            return removeElement.SolutionOne();
        }
    }
}