namespace LeetcodeTasks.RemoveDublicatesArray
{
    public class Solution 
    {
        public int RemoveDuplicates(int[] nums) 
        {
            var removeDub = new RemoveDublicatesIsArray(nums);
            return removeDub.SolutionOne();
        }
    }
}