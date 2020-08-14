using System.Diagnostics;

namespace LeetcodeTasks.FIndMaxAverage
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k) 
        {
            var sol = new FindMaxAverage(nums,k);
            return sol.GetMaxAverage();
        }
    }
}