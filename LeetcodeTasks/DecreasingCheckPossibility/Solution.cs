using System.Threading;

namespace LeetcodeTasks.DecreasingCheckPossibility
{
    public class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            var sol = new DecreasingCheckPossibility(nums);
            return sol.CheckPossibility();
        }
    }
}