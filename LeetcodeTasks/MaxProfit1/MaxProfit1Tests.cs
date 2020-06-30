using System;
using NUnit.Framework;

namespace LeetcodeTasks.MaxProfit1
{
    public class MaxProfit1Tests
    {

        [Test]
        public void TestFirstCase()
        {
            int[] arr = null;
            var prof = new MaxProfit1(arr);
            var result = prof.GetMaxProfit();

            Assert.AreEqual(0,result);
        }

        [Test]
        public void TestSecondCase()
        {
            int[] arr = new int[]{7, 1, 5, 3, 6, 4};
            var prof = new MaxProfit1(arr);
            var result = prof.GetMaxProfit();

            Assert.AreEqual(5, result);
        }


        [Test]
        public void TestThirdCase()
        {
            int[] arr = new int[] {7, 6, 4, 3, 1};
            var prof = new MaxProfit1(arr);
            var result = prof.GetMaxProfit();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestFirstCase_2()
        {
            int[] arr = null;
            var prof = new MaxProfit1(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSecondCase_2()
        {
            int[] arr = new int[] {7, 1, 5, 3, 6, 4};
            var prof = new MaxProfit1(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(5, result);
        }


        [Test]
        public void TestThirdCase_3()
        {
            int[] arr = new int[] {7, 6, 4, 3, 1};
            var prof = new MaxProfit1(arr);
            var result = prof.GetMaxProfit2();

            Assert.AreEqual(0, result);
        }


    }
}