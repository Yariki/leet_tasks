using System;
using LeetcodeTasks.Base;

namespace LeetcodeTasks.MaxDepth
{
    public class MaxDepth
    {
        private readonly TreeNode _root;


        public MaxDepth(TreeNode root)
        {
            _root = root;
        }


        public int GetMaxDepth()
        {
            if (_root == null) return 0;
            if (_root.left == null && _root.right == null) return 1;

            var result = Depth(_root);

            return result;
        }


        private int Depth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var depth  = Math.Max(Depth(node.left), Depth(node.right));

            return depth + 1;
        }

    }
}