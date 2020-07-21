namespace LeetcodeTasks.KDiffpairsArray
{
    public class Solution
    {
        public int FindPairs(int[] nums, int k) 
        {
            var sol = new KDiffPairsArray(nums,k);
            return sol.GetKDiffPairsCount();
        }
    }
}