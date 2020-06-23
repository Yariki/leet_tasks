using LeetcodeTasks.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks.SortedArrayToBST
{
    class SortedArrayToBst
    {
        private readonly int[] _sortedArray;

        public SortedArrayToBst(int[] array)
        {
            _sortedArray = array;
        }

        public TreeNode CreateBSTFromSortedArray()
        {
            if (_sortedArray == null || _sortedArray.Length == 0)
            {
                return null;
            }

            var root = CreateTree(_sortedArray, 0, _sortedArray.Length - 1);
            return root;
        }

        private TreeNode CreateTree(int[] array, int start, int end)
        {
            if (start > end) return null;

            if(start == end)
            {
                return new TreeNode(array[start]);
            }
            var mid = (start + end + 1) / 2;

            var node = new TreeNode(array[mid]);
            node.left = CreateTree(array, start, mid - 1);
            node.right = CreateTree(array, mid + 1, end);

            return node;
        }


    }
}
