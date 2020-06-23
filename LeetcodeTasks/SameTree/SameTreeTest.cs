using System.Runtime.InteropServices.ComTypes;
using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.SameTree
{
    public class SameTreeTest
    {
        [Test]
        public void TestFirstCase()
        {
            var first = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var second = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var sol = new SameTree(first, second);
            var result = sol.IsSameTree();

            Assert.True(result);
        }

        [Test]
        public void TestSecondCase()
        {
            var first = new TreeNode(1, new TreeNode(2));
            var second = new TreeNode(1, left:null, right:new TreeNode(2));
            var sol = new SameTree(first, second);
            var result = sol.IsSameTree();

            Assert.False(result);
        }

        [Test]
        public void TestThirdCase()
        {
            var first = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            var second = new TreeNode(1, left: new TreeNode(1), right: new TreeNode(2));
            var sol = new SameTree(first, second);
            var result = sol.IsSameTree();

            Assert.False(result);
        }

    }
}