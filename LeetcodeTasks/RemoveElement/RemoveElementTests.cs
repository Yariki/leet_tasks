using NUnit.Framework;

namespace LeetcodeTasks.RemoveElement
{
    public class RemoveElementTests
    {
        [Test]
        public void FirstArrayTest()
        {
            var nums = new int[] {3, 2, 2, 3};
            var sol = new Solution();
            var result = sol.RemoveElement(nums, 3);
            
            Assert.AreEqual(2, result);
        }
        
        
        [Test]
        public void SecondArrayTest()
        {
            var nums = new int[] {0,1,2,2,3,0,4,2};
            var sol = new Solution();
            var result = sol.RemoveElement(nums, 2);
            
            Assert.AreEqual(5, result);
        }
        
        [Test]
        public void ThirdArrayTest()
        {
            var nums = new int[] {1};
            var sol = new Solution();
            var result = sol.RemoveElement(nums, 1);
            
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void FourthArrayTest()
        {
            var nums = new int[] {2};
            var sol = new Solution();
            var result = sol.RemoveElement(nums, 3);
            
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void FifthArrayTest()
        {
            var nums = new int[] {3, 3};
            var sol = new Solution();
            var result = sol.RemoveElement(nums, 5);
            
            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void FirstArrayTest_SolTwo()
        {
            var nums = new int[] {3, 2, 2, 3};
            var sol = new RemoveElement(nums,3);
            var result = sol.SolutionTwo();
            
            Assert.AreEqual(2, result);
        }
        
        
        [Test]
        public void SecondArrayTest_SolTwo()
        {
            var nums = new int[] {0,1,2,2,3,0,4,2};
            var sol = new RemoveElement(nums,2);
            var result = sol.SolutionTwo();
            
            Assert.AreEqual(5, result);
        }
        
        
    }
}