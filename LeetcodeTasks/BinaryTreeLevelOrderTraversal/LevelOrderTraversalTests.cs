using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.BinaryTreeLevelOrderTraversal
{
    public class LevelOrderTraversalTests
    {

        [Test]
        public void TestFirstCase()
        {
            var tree = new TreeNode(3,new TreeNode(9),new TreeNode(20,new TreeNode(15),new TreeNode(7)));
            var sol = new LevelOrderTraversal(tree);
            var result = sol.LevelOrderBottom();
            
            Assert.NotNull(result);
        }
        
    }
}