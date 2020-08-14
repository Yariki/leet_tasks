using NUnit.Framework;

namespace LeetcodeTasks.FIndMaxAverage
{
    public class FindMaxAverageTests
    {
        [Test]
        public void FirstArray_Success()
        {
            var arr = new int[] {1,12,-5,-6,50,3};
            var k = 4;
            
            var sol = new Solution();
            var result = sol.FindMaxAverage(arr, k);
            
            Assert.AreEqual(12.75, result);

        }
        
        [Test]
        public void SecondArray_Success()
        {
            var arr = new int[] {-1};
            var k = 1;
            
            var sol = new Solution();
            var result = sol.FindMaxAverage(arr, k);
            
            Assert.AreEqual(-1, result);

        }
        
        
    }
}