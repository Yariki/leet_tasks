using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.IsTreeBalanced
{
	public class IsBSTreeBalancedTests
	{
		[Test]
		public void TestFirstCase()
		{
			var tree = new TreeNode(3,new TreeNode(9), new TreeNode(20,new TreeNode(15),new TreeNode(7)));
			var sol = new IsBSTreeBalanced(tree);
			var result = sol.IsBalanced();
			
			Assert.True(result);
		}


		[Test]
		public void TestSecondCase()
		{
			var tree = new TreeNode(1,
				new TreeNode(2, new TreeNode(3, new TreeNode(4), new TreeNode(4)), new TreeNode(3)), new TreeNode(2));
			var sol = new IsBSTreeBalanced(tree);
			var result = sol.IsBalanced();

			Assert.False(result);
		}

		[Test]
		public void TestThirdCase()
		{
			var tree = new TreeNode(1,
				new TreeNode(2, new TreeNode(3, new TreeNode(4), new TreeNode(4)), new TreeNode(3)), new TreeNode(2));
			var sol = new IsBSTreeBalanced(tree);
			var result = sol.IsBalanced();

			Assert.False(result);
		}
	}
}