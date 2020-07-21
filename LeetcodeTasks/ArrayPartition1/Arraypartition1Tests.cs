using NUnit.Framework;

namespace LeetcodeTasks.ArrayPartition1
{
    public class ArrayPartition1Tests
    {
        [Test]
        public void NullOrEmptyArray_Success()
        {
            int[] arr = null;
            var sol = new ArrayPartition1(arr);
            var result = sol.GetSumOfMin();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void FirstArray_Success()
        {
            int[] arr = {1, 4, 3, 2};
            var sol = new ArrayPartition1(arr);
            var result = sol.GetSumOfMin();

            Assert.AreEqual(4, result);
        }
    }
}