using System.Collections.Generic;

namespace LeetcodeTasks.SameTree
{
    public class SameTree
    {
        private readonly TreeNode _root1;
        private readonly TreeNode _root2;

        public SameTree(TreeNode root1, TreeNode root2)
        {
            _root1 = root1;
            _root2 = root2;
        }


        public bool IsSameTree()
        {
            if (_root1 == null && _root2 == null) return true;
            if (_root1 == null || _root2 == null) return false;

            var firstTree = new List<int?>();
            TraverseTree(_root1, firstTree);
            var secondTree = new List<int?>();
            TraverseTree(_root2, secondTree);


            return CheckArrayStructure(firstTree.ToArray(), secondTree.ToArray());
        }

        private void TraverseTree(TreeNode node, List<int?> list)
        {
            list.Add(node.val);

            if (node.left != null)
            {
                TraverseTree(node.left, list);
            }
            else
            {
                list.Add(null);
            }

            if (node.right != null)
            {
                TraverseTree(node.right, list);
            }
            else
            {
                list.Add(null);
            }
        }

        private bool CheckArrayStructure(int?[] first, int?[] second)
        {
            if (first.Length == 0 && second.Length == 0) return true;
            if (first.Length != second.Length) return false;

            var length = first.Length;


            for (int i = 0; i < length; i++)
            {
                if (first[i] != second[i])
                    return false;
            }

            return true;
        }
        

    }
}