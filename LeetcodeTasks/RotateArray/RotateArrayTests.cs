using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.RotateArray
{
    public class RotateArrayTests : BaseTest
    {
        [Test]
        public void RotateFirstArray_Success()
        {
            var arr = new int[] {1,2,3,4,5,6,7};
            var steps = 3;
            var rotate = new RotateArray(arr,steps);
            rotate.PerformRotationInPlace();


            Assert.True(CheckArrayEquality(new int[]{5,6,7,1,2,3,4},arr));
        }

        [Test]
        public void RotateSecondArray_Success()
        {
            var arr = new int[] {-1, -100, 3, 99};
            var steps = 2;
            var rotate = new RotateArray(arr, steps);
            rotate.PerformRotationInPlace();


            Assert.True(CheckArrayEquality(new int[] {3,99,-1,-100}, arr));
        }

        [Test]
        public void RotateFirstArray_SecondApproach_Success()
        {
            var arr = new int[] {1, 2, 3, 4, 5, 6, 7};
            var steps = 3;
            var rotate = new RotateArray(arr, steps);
            rotate.PerformRotationWithAdditionalSpace();


            Assert.True(CheckArrayEquality(new int[] {5, 6, 7, 1, 2, 3, 4}, arr));
        }
    }
}