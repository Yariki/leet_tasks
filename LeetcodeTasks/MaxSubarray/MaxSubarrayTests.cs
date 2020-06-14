using NUnit.Framework;

namespace LeetcodeTasks.MaxSubarray
{
    public class MaxSubarrayTests
    {
        [Test]
        public void TestArray()
        {
            var arr = new int[] { -2,1,-3,4,-1,2,1,-5,4};
            var sol = new Solution();
            var result = sol.MaxSubArray(arr);
            
            
            Assert.AreEqual(6, result);
        }
    }
}