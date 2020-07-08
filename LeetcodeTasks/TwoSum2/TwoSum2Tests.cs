using Microsoft.VisualBasic;
using NUnit.Framework;

namespace LeetcodeTasks.TwoSum2
{
    public class TwoSum2Tests
    {

        [Test]
        public void NumbersNullOrEmpty_Success()
        {
            var numbers = new int[] { };
            var target = 2;
            var twoSum = new TwoSum2(numbers,target);
            var result = twoSum.GetTwoSum();

            Assert.Null(result);

        }

        [Test]
        public void TargetIsZero_Success()
        {
            var numbers = new int[] {0 };
            var target = 0;
            var twoSum = new TwoSum2(numbers, target);
            var result = twoSum.GetTwoSum();

            Assert.Null(result);

        }


        [Test]
        public void ValidNumbersAndTarget_Success()
        {
            var numbers = new int[] {2,7,11,15};
            var target = 9;
            var twoSum = new TwoSum2(numbers, target);
            var result = twoSum.GetTwoSum();

            Assert.True(result.Length == 2);
            Assert.AreEqual(1,result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [Test]
        public void ValidNumbersAndTarget_2_Success()
        {
            var numbers = new int[] {2, 3, 4};
            var target = 6;
            var twoSum = new TwoSum2(numbers, target);
            var result = twoSum.GetTwoSum();

            Assert.True(result.Length == 2);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
        }

        [Test]
        public void ValidNumbersAndTarget_3_Success()
        {
            var numbers = new int[] {0,0, 3, 4};
            var target = 0;
            var twoSum = new TwoSum2(numbers, target);
            var result = twoSum.GetTwoSum();

            Assert.True(result.Length == 2);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

    }
}