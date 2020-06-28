using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.HasPathSum
{
    public class HasPathSumTests
    {
        [Test]
        public void TestFirstTest()
        {
            var tree = new TreeNode(5,
            new TreeNode(4,
                new TreeNode(11,
                    new TreeNode(7),
                    new TreeNode(2))),
            new TreeNode(8,
                new TreeNode(13),
                new TreeNode(4,
                    left:null,
                    right:new TreeNode(1)))
            );

            var sol = new HasPathSum(tree,22);
            var result = sol.HasTreeThePathSum();

            Assert.True(result);
        }

        [Test]
        public void TestSecondCase()
        {
            TreeNode tree = null;

            var sol = new HasPathSum(tree, 0);
            var result = sol.HasTreeThePathSum();

            Assert.False(result);

        }


        [Test]
        public void TestThirdCase()
        {
            TreeNode tree = new TreeNode(10);

            var sol = new HasPathSum(tree, 10);
            var result = sol.HasTreeThePathSum();

            Assert.True(result);

        }

    }
}