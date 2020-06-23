using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.SymmetricTree
{
    public class SymmetricTreeTests
    {
        [Test]
        public void TestFirstCase()
        {
            var tree = new TreeNode(1,new TreeNode(2,new TreeNode(3),new TreeNode(4)), new TreeNode(2,new TreeNode(4),new TreeNode(3)));
            var sol = new SymmetricTree(tree);
            var result = sol.IsSymmetricOne();

            Assert.True(result);
        }


        [Test]
        public void TestSecondCase()
        {
            var tree = new TreeNode(1, new TreeNode(2, left:  null, right:new TreeNode(3)),
                new TreeNode(2, left: null, right: new TreeNode(3)));
            var sol = new SymmetricTree(tree);
            var result = sol.IsSymmetricOne();

            Assert.False(result);
        }

        [Test]
        public void TestThirdCase()
        {
            var tree = new TreeNode(1);
            var sol = new SymmetricTree(tree);
            var result = sol.IsSymmetricOne();

            Assert.True(result);
        }

        [Test]
        public void TestFirstCase_2()
        {
            var tree = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(4), new TreeNode(3)));
            var sol = new SymmetricTree(tree);
            var result = sol.IsSymmetricTwo();

            Assert.True(result);
        }


        [Test]
        public void TestSecondCase_2()
        {
            var tree = new TreeNode(1, new TreeNode(2, left: null, right: new TreeNode(3)),
                new TreeNode(2, left: null, right: new TreeNode(3)));
            var sol = new SymmetricTree(tree);
            var result = sol.IsSymmetricTwo();

            Assert.False(result);
        }

        [Test]
        public void TestThirdCase_2()
        {
            var tree = new TreeNode(1);
            var sol = new SymmetricTree(tree);
            var result = sol.IsSymmetricTwo();

            Assert.True(result);
        }



    }
}