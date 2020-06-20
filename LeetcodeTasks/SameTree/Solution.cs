namespace LeetcodeTasks.SameTree
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            var sameTree = new SameTree(p, q);
            return sameTree.IsSameTree();
        }
    }
}