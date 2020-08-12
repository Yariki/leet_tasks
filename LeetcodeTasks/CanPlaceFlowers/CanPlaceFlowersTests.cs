using System.Reflection;
using NUnit.Framework;

namespace LeetcodeTasks.CanPlaceFlowers
{
    public class CanPlaceFlowersTests
    {
        [Test]
        public void NullOrEmptyArray_Success()
        {
            int[] arr = null;
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 1);
            
            Assert.False(result);
        }
        
        [Test]
        public void FirstArray_Success()
        {
            int[] arr = new []{1,0,0,0,1};
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 1);
            
            Assert.True(result);
        }
        
        [Test]
        public void SecondArray_Success()
        {
            int[] arr = new []{1,0,0,0,1};
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 2);
            
            Assert.False(result);
        }

        [Test]
        public void ThirdArray_Success()
        {
            int[] arr = new []{0,0,1,0,1};
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 1);
            
            Assert.True(result);
        }

        [Test]
        public void FourthArray_Success()
        {
            int[] arr = new[] { 0};
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 1);

            Assert.True(result);
        }

        [Test]
        public void FifthArray_Success()
        {
            int[] arr = new[] { 0,0,1,0,0 };
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 1);

            Assert.True(result);
        }

        [Test]
        public void SixthArray_Success()
        {
            int[] arr = new[] { 1, 0, 0, 0 };
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 1);

            Assert.True(result);
        }

        [Test]
        public void SeventhArray_Success()
        {
            int[] arr = new[] { 0, 0, 0 };
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 2);

            Assert.True(result);
        }

        [Test]
        public void EightArray_Success()
        {
            int[] arr = new[] { 0, 0, 0, 0 };
            var sol = new Solution();
            var result = sol.CanPlaceFlowers(arr, 2);

            Assert.True(result);
        }



    }
}