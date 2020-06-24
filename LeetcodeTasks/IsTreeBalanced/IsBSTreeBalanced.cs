using System;
using System.Runtime.CompilerServices;
using LeetcodeTasks.Base;
using NUnit.Framework.Interfaces;

namespace LeetcodeTasks.IsTreeBalanced
{
	public class IsBSTreeBalanced
	{
		private readonly TreeNode _root;

		public IsBSTreeBalanced(TreeNode root)
		{
			_root = root;
		}

		public bool IsBalanced()
		{
			if (_root == null) return true;
			if (_root != null && IsLeaf(_root)) return true;

			return IsBalanced(_root);
		}


		private bool IsBalanced(TreeNode node)
		{
			if (node == null) return true;


			var lh = Depth(node.left);
			var rh = Depth(node.right);

			return Math.Abs(lh - rh) <= 1 && IsBalanced(node.left) && IsBalanced(node.right);
		}



		private int Depth(TreeNode node)
		{
			if (node == null)
			{
				return 0;
			}

			var depth = Math.Max(Depth(node.left), Depth(node.right));
			return depth + 1;
		}

		private bool IsLeaf(TreeNode node)
		{
			return node.left == null && node.right == null;
		}

	}
}