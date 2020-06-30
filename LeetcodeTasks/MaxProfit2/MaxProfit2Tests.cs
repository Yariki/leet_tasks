using NUnit.Framework;

namespace LeetcodeTasks.MaxProfit2
{
    public class MaxProfit2Tests
    {
        [Test]
        public void TestFirstCase()
        {
            int[] arr = null;
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit1();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSecondCase()
        {
            int[] arr = new int[] {7, 1, 5, 3, 6, 4};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit1();

            Assert.AreEqual(7, result);
        }


        [Test]
        public void TestThirdCase()
        {
            int[] arr = new int[] {1, 2, 3, 4, 5};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit1();

            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestFourtCase()
        {
            int[] arr = new int[] {7, 6, 4, 3, 1};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit1();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestFifthCase()
        {
            int[] arr = new int[] {6, 1, 3, 2, 4, 7};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit1();

            Assert.AreEqual(7, result);
        }

        [Test]
        public void TestFirstCase_2()
        {
            int[] arr = null;
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSecondCase_2()
        {
            int[] arr = new int[] {7, 1, 5, 3, 6, 4};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(7, result);
        }


        [Test]
        public void TestThirdCase_2()
        {
            int[] arr = new int[] {1, 2, 3, 4, 5};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestFourtCase_2()
        {
            int[] arr = new int[] {7, 6, 4, 3, 1};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestFifthCase_2()
        {
            int[] arr = new int[] {6, 1, 3, 2, 4, 7};
            var prof = new MaxProfit2(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(7, result);
        }

    }
}