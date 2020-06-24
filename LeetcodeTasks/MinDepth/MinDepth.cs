using System;
using LeetcodeTasks.Base;

namespace LeetcodeTasks.MinDepth
{
    public class MinDepth
    {
        private readonly TreeNode _root;

        public MinDepth(TreeNode root)
        {
            _root = root;
        }

        public int GetMinDepth()
        {
            if (_root == null) return 0;
            if (_root.left == null && _root.right == null) return 1;

            return Depth(_root);
        }

        private int Depth(TreeNode node)
        {
            if (node == null) return 0;

            int min = -1;

            if (IsLeaf(node))
                min = 0;
            else if(IsPartialLeaf(node))
                min = Math.Max(Depth(node.left), Depth(node.right));
            else 
             min = Math.Min(Depth(node.left), Depth(node.right));

            return min + 1;
        }

        private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;

        private bool IsPartialLeaf(TreeNode node) => node.left == null || node.right == null;



    }
}