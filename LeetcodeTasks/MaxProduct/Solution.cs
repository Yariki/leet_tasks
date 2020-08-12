using System.Linq.Expressions;

namespace LeetcodeTasks.MaxProduct
{
    public class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            var sol = new MaxProduct(nums);
            return sol.GetMaxProduct();
        }
    }
}