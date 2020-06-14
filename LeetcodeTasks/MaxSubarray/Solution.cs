namespace LeetcodeTasks.MaxSubarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums) 
        {
            var sol = new MaxSubarray(nums);
            return sol.SolutionOne();
        }
    }
}