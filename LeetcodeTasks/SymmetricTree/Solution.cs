using LeetcodeTasks.Base;

namespace LeetcodeTasks.SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            var res = new SymmetricTree(root);
            return res.IsSymmetricTwo();
        }
    }
}