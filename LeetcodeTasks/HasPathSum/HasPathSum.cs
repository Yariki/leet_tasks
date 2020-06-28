using LeetcodeTasks.Base;

namespace LeetcodeTasks.HasPathSum
{
    public class HasPathSum
    {
        private readonly TreeNode _root;
        private readonly int _sum;

        public HasPathSum(TreeNode root, int sum)
        {
            _root = root;
            _sum = sum;
        }

        public bool HasTreeThePathSum()
        {
            var result = HasPath(_root, 0);
            return result;
        }

        private bool HasPath(TreeNode node, int sum)
        {
            if (node == null) return false;

            if (IsLeaf(node))
            {
                return (sum + node.val) == _sum;
            }

            return HasPath(node.left, sum + node.val) || HasPath(node.right, sum + node.val);
        }


        bool IsLeaf(TreeNode node) => node.left == null && node.right == null;

        bool IsPartLeaf(TreeNode node) => node.left == null || node.right == null;


    }
}