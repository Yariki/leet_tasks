namespace LeetcodeTasks.ConrainsDuplicates
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums) 
        {
            var sol = new ContainDuplicates(nums);
            return sol.GetContainDuplicatesWithHash();
        }
    }
}