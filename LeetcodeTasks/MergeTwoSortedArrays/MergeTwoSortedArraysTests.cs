using NUnit.Framework;

namespace LeetcodeTasks.MergeTwoSortedArrays
{
    public class MergeTwoSortedArraysTests : BaseTest
    {
        [Test]
        public void TestFirstCase()
        {
            var nums1 = new int[] {1, 2, 3, 0, 0, 0};
            var nums2 = new int[]{2, 5, 6};
            var merge = new MergeTwoSortedArrays(nums1,nums2,3,3);
            var result = merge.MergeTwoArraysWithTwoPointers();


            Assert.True(CheckArrayEquality(new int[]{1,2,2,3,5,6}, result));
        }

        [Test]
        public void TestSecondCase()
        {
            var nums1 = new int[] {4, 0, 0, 0, 0, 0};
            var nums2 = new int[] {1, 2, 3, 5, 6};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 1, 5);
            var result = merge.MergeTwoArraysWithTwoPointers();


            Assert.True(CheckArrayEquality(new int[] {1, 2, 3, 4, 5, 6}, result));
        }

        [Test]
        public void TestThirdCase()
        {
            var nums1 = new int[] {1, 2, 4, 5, 6, 0};
            var nums2 = new int[] {3};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 5, 1);
            var result = merge.MergeTwoArraysWithTwoPointers();


            Assert.True(CheckArrayEquality(new int[] {1, 2, 3, 4, 5, 6}, result));
        }

        [Test]
        public void TestFourthCase()
        {
            var nums1 = new int[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 };
            var nums2 = new int[] {-1, 1, 1, 1, 2, 3};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 3, 6);
            var result = merge.MergeTwoArraysWithTwoPointers();


            Assert.True(CheckArrayEquality(new int[] {-1, 0, 0, 1, 1, 1, 2, 3, 3}, result));
        }


        [Test]
        public void TestFirstCase_2()
        {
            var nums1 = new int[] {1, 2, 3, 0, 0, 0};
            var nums2 = new int[] {2, 5, 6};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 3, 3);
            var result = merge.MergeTwoArraysWithAdditionalMemory();


            Assert.True(CheckArrayEquality(new int[] {1, 2, 2, 3, 5, 6}, result));
        }

        [Test]
        public void TestSecondCase_2()
        {
            var nums1 = new int[] {4, 0, 0, 0, 0, 0};
            var nums2 = new int[] {1, 2, 3, 5, 6};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 1, 5);
            var result = merge.MergeTwoArraysWithAdditionalMemory();


            Assert.True(CheckArrayEquality(new int[] {1, 2, 3, 4, 5, 6}, result));
        }

        [Test]
        public void TestThirdCase_2()
        {
            var nums1 = new int[] {1, 2, 4, 5, 6, 0};
            var nums2 = new int[] {3};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 5, 1);
            var result = merge.MergeTwoArraysWithAdditionalMemory();


            Assert.True(CheckArrayEquality(new int[] {1, 2, 3, 4, 5, 6}, result));
        }

        [Test]
        public void TestFourthCase_2()
        {
            var nums1 = new int[] {0, 0, 3, 0, 0, 0, 0, 0, 0};
            var nums2 = new int[] {-1, 1, 1, 1, 2, 3};
            var merge = new MergeTwoSortedArrays(nums1, nums2, 3, 6);
            var result = merge.MergeTwoArraysWithAdditionalMemory();


            Assert.True(CheckArrayEquality(new int[] {-1, 0, 0, 1, 1, 1, 2, 3, 3}, result));
        }


    }
}