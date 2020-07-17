using System.Collections.Generic;

namespace LeetcodeTasks.FindDisappearedNumbers
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var sol = new FindDisappearedNumbers(nums);
            return sol.GetFindDisappearedNumbers();
        }
    }
}