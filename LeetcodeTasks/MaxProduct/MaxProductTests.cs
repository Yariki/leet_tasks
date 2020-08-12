using NUnit.Framework;

namespace LeetcodeTasks.MaxProduct
{
    public class MaxProductTests
    {

        [Test]
        public void FirstArray_Success()
        {
            var arr = new int[] {1, 2, 3};
            var sol = new Solution();
            var result = sol.MaximumProduct(arr);

            Assert.AreEqual(6,result);
        }

        [Test]
        public void SecondArray_Success()
        {
            var arr = new int[] { 1, 2, 3, 4 };
            var sol = new Solution();
            var result = sol.MaximumProduct(arr);

            Assert.AreEqual(24, result);
        }
        [Test]
        public void ThirdArray_Success()
        {
            var arr = new int[] { -4, -3, -2, -1, 60 };
            var sol = new Solution();
            var result = sol.MaximumProduct(arr);

            Assert.AreEqual(720, result);
        }

        [Test]
        public void ThirdArray_Success_SecondApproach()
        {
            var arr = new int[] { -4, -3, -2, -1, 60 };
            var sol = new MaxProduct(arr);
            var result = sol.GetMaxProduct2();

            Assert.AreEqual(720, result);
        }

    }
}