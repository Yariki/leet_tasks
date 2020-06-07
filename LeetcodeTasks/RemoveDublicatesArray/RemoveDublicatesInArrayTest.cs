using NUnit.Framework;

namespace LeetcodeTasks.RemoveDublicatesArray
{
    public class RemoveDublicatesInArrayTest
    {
        [Test]
        public void ArrayWithTwoRepeatedNumbers()
        {
            var arr = new int[] {1, 1, 2, 2};
            var sol = new Solution();
            
            Assert.AreEqual(2,sol.RemoveDuplicates(arr));
        }
        
        [Test]
        public void ArrayWithTwoRepeatedAndOneNumbers()
        {
            var arr = new int[] {1, 1, 2, 2,10};
            var sol = new Solution();
            
            Assert.AreEqual(3,sol.RemoveDuplicates(arr));
        }
        
        [Test]
        public void ArrayWithAllSameNumbers()
        {
            var arr = new int[] {1, 1, 1, 1,1};
            var sol = new Solution();
            
            Assert.AreEqual(1,sol.RemoveDuplicates(arr));
        }
        
        [Test]
        public void ArrayWithNegativeAndPositiveNumbers()
        {
            var arr = new int[] {-1,0,0, 1, 1, 3,6,7,7};
            var sol = new Solution();
            
            Assert.AreEqual(6,sol.RemoveDuplicates(arr));
        }
        
        [Test]
        public void EmtyArray()
        {
            var arr = new int[]{};
            var sol = new Solution();
            
            Assert.AreEqual(0,sol.RemoveDuplicates(arr));
        }
        
        
    }
}