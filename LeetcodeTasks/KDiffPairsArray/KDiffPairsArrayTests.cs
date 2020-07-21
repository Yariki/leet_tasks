using System.Diagnostics;
using NUnit.Framework;

namespace LeetcodeTasks.KDiffpairsArray
{
    public class KDiffPairsArrayTests
    {
        [Test]
        public void NullOrEmptyArray_Success()
        {
            int[] arr = null;
            var sol = new KDiffPairsArray(arr,1);
            var result = sol.GetKDiffPairsCount();
            
            Assert.AreEqual(0, result);
        }
        
        
        [Test]
        public void FirstArray_Success()
        {
            int[] arr = {3, 1, 4, 1, 5};
            var sol = new KDiffPairsArray(arr,2);
            var result = sol.GetKDiffPairsCount();
            
            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void SecondArray_Success()
        {
            int[] arr = {1, 2, 3, 4, 5};
            var sol = new KDiffPairsArray(arr,1);
            var result = sol.GetKDiffPairsCount();
            
            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void ThirdArray_Success()
        {
            int[] arr = {1, 3, 1, 5, 4};
            var sol = new KDiffPairsArray(arr,0);
            var result = sol.GetKDiffPairsCount();
            
            Assert.AreEqual(1, result);
        }
    }
}