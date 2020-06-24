using LeetcodeTasks.Base;

namespace LeetcodeTasks.IsTreeBalanced
{
	public class Solution
	{
		public bool IsBalanced(TreeNode root)
		{
			var sol = new IsBSTreeBalanced(root);
			return sol.IsBalanced();
		}
	}
}