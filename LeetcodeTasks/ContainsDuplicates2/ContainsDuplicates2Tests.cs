using NUnit.Framework;

namespace LeetcodeTasks.ContainsDuplicates2
{
    public class ContainsDuplicates2Tests
    {
        [Test]
        public void NullOrEmptyArray_Success()
        {
            int[] arr = null;
            int k = 0;
            var sol = new ContainsDuplicates2(arr,k);
            var result = sol.IsThereDuplicates();

            Assert.False(result);
        }

        [Test]
        public void FirstArray_Success()
        {
            int[] arr = { 1, 2, 3, 1 };
            int k = 3;
            var sol = new ContainsDuplicates2(arr, k);
            var result = sol.IsThereDuplicates();

            Assert.True(result);
        }

        [Test]
        public void SecondArray_Success()
        {
            int[] arr = { 1,0,1,1 };
            int k = 1;
            var sol = new ContainsDuplicates2(arr, k);
            var result = sol.IsThereDuplicates();

            Assert.True(result);
        }

        [Test]
        public void ThirdArray_Success()
        {
            int[] arr = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            var sol = new ContainsDuplicates2(arr, k);
            var result = sol.IsThereDuplicates();

            Assert.False(result);
        }

    }
}