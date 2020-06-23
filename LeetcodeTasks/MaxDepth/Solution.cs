using LeetcodeTasks.Base;

namespace LeetcodeTasks.MaxDepth
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            var maxDepth = new MaxDepth(root);
            return maxDepth.GetMaxDepth();
        }
    }
}