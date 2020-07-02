using System.Reflection.Metadata.Ecma335;
using NUnit.Framework;

namespace LeetcodeTasks.SingleNumber
{
    public class SingleNumberTests
    {
        [Test]
        public void NullOrEmptyArray_Success_True()
        {
            int[] nums = null;
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ArrayFirst_Success_True()
        {
            int[] nums = new int[]{2, 2, 1};
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ArraySecond_Success_True()
        {
            int[] nums = new int[] {4, 1, 2, 1, 2};
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber();

            Assert.AreEqual(4, result);
        }

        //==========================================================

        [Test]
        public void NullOrEmptyArray_SecondApproach_Success_True()
        {
            int[] nums = null;
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber2();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ArrayFirst_SecondApproach_Success_True()
        {
            int[] nums = new int[] {2, 2, 1};
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber2();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ArraySecond_SecondApproach_Success_True()
        {
            int[] nums = new int[] {4, 1, 2, 1, 2};
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber2();

            Assert.AreEqual(4, result);
        }

        //==========================================================

        [Test]
        public void NullOrEmptyArray_ThirdApproach_Success_True()
        {
            int[] nums = null;
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber3();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ArrayFirst_ThirdApproach_Success_True()
        {
            int[] nums = new int[] {2, 2, 1};
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber3();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ArraySecond_ThirdApproach_Success_True()
        {
            int[] nums = new int[] {4, 1, 2, 1, 2};
            var number = new SingleNumber(nums);
            var result = number.GetSingleNumber3();

            Assert.AreEqual(4, result);
        }

    }
}