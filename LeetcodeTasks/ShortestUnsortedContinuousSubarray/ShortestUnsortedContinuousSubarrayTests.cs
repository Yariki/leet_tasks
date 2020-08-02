using NUnit.Framework;

namespace LeetcodeTasks.ShortestUnsortedContinuousSubarray
{
    public class ShortestUnsortedContinuousSubarrayTests
    {
        [Test]
        public void NullOrEmptyArray_Success()
        {
            int[] arr = null;
            var sol = new Solution();
            var result = sol.FindUnsortedSubarray(arr);
            
            Assert.AreEqual(0,result);
        }
        
        [Test]
        public void FirstArray_Success()
        {
            int[] arr = new int[]{2, 6, 4, 8, 10, 9, 15};
            var sol = new Solution();
            var result = sol.FindUnsortedSubarray(arr);
            
            Assert.AreEqual(5,result);
        }
        
        
        [Test]
        public void SecondArray_Success()
        {
            int[] arr = new int[]{5,4,3,2,1};
            var sol = new Solution();
            var result = sol.FindUnsortedSubarray(arr);
            
            Assert.AreEqual(5,result);
        }
        
        [Test]
        public void ThirdArray_Success()
        {
            int[] arr = new int[]{1,2,3,3,3};
            var sol = new Solution();
            var result = sol.FindUnsortedSubarray(arr);
            
            Assert.AreEqual(0,result);
        }
        
        [Test]
        public void FourthArray_Success()
        {
            int[] arr = new int[]{1,3,2,2,2};
            var sol = new Solution();
            var result = sol.FindUnsortedSubarray(arr);
            
            Assert.AreEqual(4,result);
        }
        
    }
}