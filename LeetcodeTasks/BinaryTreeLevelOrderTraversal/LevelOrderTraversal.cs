using System.Collections.Generic;
using System.Linq;
using LeetcodeTasks.Base;

namespace LeetcodeTasks.BinaryTreeLevelOrderTraversal
{
    public class LevelOrderTraversal
    {

        private readonly TreeNode _root;

        public LevelOrderTraversal(TreeNode root)
        {
            _root = root;
        }

        public IList<IList<int>> LevelOrderBottom()
        {
            var dict = new SortedDictionary<int, List<int>>();
            
            TraverseTree(_root,0,dict);
            
            IList<IList<int>> list = new List<IList<int>>();

            foreach (var pair in dict.Reverse())
            {
                list.Add(pair.Value);
            }

            return list;
        }

        private void TraverseTree(TreeNode node, int level, IDictionary<int, List<int>> dict)
        {
            if (node == null) return;
            if (!dict.ContainsKey(level))
            {
                dict.Add(level,new List<int>());
            }
            dict[level].Add(node.val);
            
            TraverseTree(node.left,level + 1, dict);
            TraverseTree(node.right, level + 1, dict);
            
        }
        
        
    }
}