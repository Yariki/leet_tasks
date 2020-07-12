namespace LeetcodeTasks.ContainsDuplicates2
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var sol = new ContainsDuplicates2(nums,k);
            return sol.IsThereDuplicates();
        }
    }
}