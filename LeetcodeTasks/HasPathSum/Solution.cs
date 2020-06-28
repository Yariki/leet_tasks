using LeetcodeTasks.Base;

namespace LeetcodeTasks.HasPathSum
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            var sol = new HasPathSum(root,sum);
            return sol.HasTreeThePathSum();
        }
    }
} 