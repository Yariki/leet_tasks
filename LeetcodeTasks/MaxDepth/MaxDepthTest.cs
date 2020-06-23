using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.MaxDepth
{
    public class MaxDepthTest
    {
        [Test]
        public void TestFirstCase()
        {
            var root = new TreeNode(3,new TreeNode(9),new TreeNode(20,new TreeNode(15),new TreeNode(7)));
            var maxDepth = new MaxDepth(root);
            var result = maxDepth.GetMaxDepth();

            Assert.AreEqual(3, result);
        }
    }
}