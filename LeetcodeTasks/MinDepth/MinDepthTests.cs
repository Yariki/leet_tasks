using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.MinDepth
{
    public class MinDepthTests
    {
        [Test]
        public void TestFirstCase()
        {
            TreeNode tree = null;
            var sol = new MinDepth(tree);
            var result = sol.GetMinDepth();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSecondCase()
        {
            TreeNode tree = new TreeNode(3);
            var sol = new MinDepth(tree);
            var result = sol.GetMinDepth();

            Assert.AreEqual(1, result);
        }


        [Test]
        public void TestThirdCase()
        {
            var tree = new TreeNode(3, new TreeNode(9), new TreeNode(20,new TreeNode(15), new TreeNode(7)));
            var sol = new MinDepth(tree);
            var result = sol.GetMinDepth();

            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestFourthCase()
        {
            var tree = new TreeNode(1, new TreeNode(2));
            var sol = new MinDepth(tree);
            var result = sol.GetMinDepth();

            Assert.AreEqual(2, result);
        }

    }
}