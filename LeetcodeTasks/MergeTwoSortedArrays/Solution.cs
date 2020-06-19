namespace LeetcodeTasks.MergeTwoSortedArrays
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var merge = new MergeTwoSortedArrays(nums1, nums2,m,n);
            merge.MergeTwoArraysWithTwoPointers();
        }
    }
}