using NUnit.Framework;

namespace LeetcodeTasks.SearchInsertPosition
{
    public class SearchInsertPositionTests
    {
        [Test]
        public void Test_FirstArray()
        {
            var arr = new int[] {1, 3, 5, 6};
            var target = 5;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void Test_SecondArray()
        {
            var arr = new int[] {1, 3, 5, 6};
            var target = 2;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Test_ThirdArray()
        {
            var arr = new int[] {1, 3, 5, 6};
            var target = 7;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void Test_FourthArray()
        {
            var arr = new int[] {1, 3, 5, 6};
            var target = 0;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Test_FifthArray()
        {
            var arr = new int[] {1};
            var target = 1;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Test_SixthArray()
        {
            var arr = new int[] {1};
            var target = 0;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Test_SeventhArray()
        {
            var arr = new int[] {1};
            var target = 2;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Test_EightArray()
        {
            var arr = new int[] {3,4,5,6,7,8};
            var target = 6;
            
            var searchInsert = new SearchInsertPosition(arr,target);
            var result = searchInsert.SolutionOne();
            
            Assert.AreEqual(3, result);
        }
        
        
    }
}