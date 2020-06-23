using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using LeetcodeTasks.Base;

namespace LeetcodeTasks.SymmetricTree
{
    public class SymmetricTree
    {
        private readonly TreeNode _root;

        public SymmetricTree(TreeNode root)
        {
            _root = root;
        }


        public bool IsSymmetricOne()
        {
            if (_root == null) return true;

            if (IsLeaf(_root)) return true;

            if (_root.left == null || _root.right == null) return false;

            var leftStack = new Stack<int?>();
            var rightStack = new Stack<int?>();
            TraverseLeft(_root.left,leftStack);
            TraverseRight(_root.right,rightStack);

            return CheckSubtrees(leftStack, rightStack);
        }

        public bool IsSymmetricTwo()
        {
            if (_root == null) return true;

            if (IsLeaf(_root)) return true;

            if (_root.left == null || _root.right == null) return false;

            return Symmetric(_root.left, _root.right);
        }


        private bool Symmetric(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == null && right == null ? true : false;
            }

            if (left.val != right.val)
            {
                return false;
            }
            else
                return Symmetric(left.left,right.right) && Symmetric(left.right, right.left);
        }


        private void TraverseLeft(TreeNode node, Stack<int?> leftSubtree)
        {
            leftSubtree.Push(node.val);

            if (IsLeaf(node))
            {
                return;
            }

            if (node.left != null)
            {
                TraverseLeft(node.left,leftSubtree);
            } else leftSubtree.Push(null);

            if (node.right != null)
            {
                TraverseLeft(node.right,leftSubtree);
            } else leftSubtree.Push(null);
        }

        private void TraverseRight(TreeNode node, Stack<int?> rightSubtree)
        {
            rightSubtree.Push(node.val);

            if (IsLeaf(node))
            {
                return;
            }

            if (node.right != null)
            {
                TraverseRight(node.right,rightSubtree);
            } else rightSubtree.Push(null);

            if (node.left != null)
            {
                TraverseRight(node.left,rightSubtree);
            } else rightSubtree.Push(null);
        }

        private bool CheckSubtrees(Stack<int?> left, Stack<int?> right)
        {
            if (left.Count == 0 && right.Count == 0) return true;
            if (left.Count == 0 || right.Count == 0) return false;

            while (left.Count > 0 && right.Count > 0)
            {
                var leftItem = left.Pop();
                var rightItem = right.Pop();
                if (!leftItem.HasValue || !rightItem.HasValue) return false;
                if (leftItem != rightItem)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }

    }
}