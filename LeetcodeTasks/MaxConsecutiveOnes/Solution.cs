using System.Diagnostics;

namespace LeetcodeTasks.MaxConsecutiveOnes
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var sol = new MaxConsecutiveOnes(nums);
            return sol.GetMaxConsecutiveOnes();
        }
    }
}