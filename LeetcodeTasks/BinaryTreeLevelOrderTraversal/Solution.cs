using System.Collections.Generic;
using LeetcodeTasks.Base;

namespace LeetcodeTasks.BinaryTreeLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root) 
        {
            var result = new LevelOrderTraversal(root);
            return result.LevelOrderBottom();
        }
    }
}