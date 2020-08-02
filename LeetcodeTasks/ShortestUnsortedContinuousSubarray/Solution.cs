namespace LeetcodeTasks.ShortestUnsortedContinuousSubarray
{
    public class Solution
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            var sol = new ShortestUnsortedContinuousSubarray(nums);
            return sol.GetLength();
        }
    }
}