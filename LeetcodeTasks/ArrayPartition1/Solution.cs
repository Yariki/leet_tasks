namespace LeetcodeTasks.ArrayPartition1
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            var sol = new ArrayPartition1(nums);
            return sol.GetSumOfMin();
        }
    }
}