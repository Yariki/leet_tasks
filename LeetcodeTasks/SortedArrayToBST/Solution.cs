using LeetcodeTasks.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks.SortedArrayToBST
{
    class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            var sol = new SortedArrayToBst(nums);
            return sol.CreateBSTFromSortedArray();
        }
    }
}
