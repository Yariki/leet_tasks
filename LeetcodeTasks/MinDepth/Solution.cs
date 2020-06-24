using LeetcodeTasks.Base;

namespace LeetcodeTasks.MinDepth
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            var sol = new MinDepth(root);
            return sol.GetMinDepth();
        }
    }
}