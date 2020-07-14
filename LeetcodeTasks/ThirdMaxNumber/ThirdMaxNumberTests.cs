using NUnit.Framework;

namespace LeetcodeTasks.ThirdMaxNumber
{
    public class ThirdMaxNumberTests
    {
        [Test]
        public void NullOrEmptyArray_Success()
        {
            int[] arr = null;
            var sol = new ThirdMaxNumber(arr);
            var result = sol.GetThirdMax();

            Assert.AreEqual(0,result);
        }

        [Test]
        public void FirstArray_Success()
        {
            int[] arr = {3, 2, 1};
            var sol = new ThirdMaxNumber(arr);
            var result = sol.GetThirdMax();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void SecondArray_Success()
        {
            int[] arr = {1, 2};
            var sol = new ThirdMaxNumber(arr);
            var result = sol.GetThirdMax();

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ThirdArray_Success()
        {
            int[] arr = {2,2,3,1};
            var sol = new ThirdMaxNumber(arr);
            var result = sol.GetThirdMax();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void FourthArray_Success()
        {
            int[] arr = {1, 2, -2147483648};
            var sol = new ThirdMaxNumber(arr);
            var result = sol.GetThirdMax();

            Assert.AreEqual(-2147483648, result);
        }

        [Test]
        public void FifthArray_Success()
        {
            int[] arr = {1,1,2};
            var sol = new ThirdMaxNumber(arr);
            var result = sol.GetThirdMax();

            Assert.AreEqual(2, result);
        }


    }
}