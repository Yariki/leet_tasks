using LeetcodeTasks.ConrainsDuplicates;
using NUnit.Framework;

namespace LeetcodeTasks.ContainsDuplicates
{
    public class ContainDuplicatesTests
    {
        [Test]
        public void NullArray_Success()
        {
            int[] arr = null;
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithHash();
            
            Assert.False(result);
        }
        
        [Test]
        public void TwoItemsArray_Success_False()
        {
            int[] arr = {1,2};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithHash();
            
            Assert.False(result);
        }
        
        [Test]
        public void TwoItemsArray_Success_True()
        {
            int[] arr = {1,1};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithHash();
            
            Assert.True(result);
        }
        
        [Test]
        public void FourthItemsArray_Success_True()
        {
            int[] arr = {1,2,3,1};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithHash();
            
            Assert.True(result);
        }
        
        [Test]
        public void UniqueItemsArray_Success_False()
        {
            int[] arr = {1,2,3,4};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithHash();
            
            Assert.False(result);
        }
        
        [Test]
        public void ManyItemsArray_Success_True()
        {
            int[] arr = {1,1,1,3,3,4,3,2,4,2};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithHash();
            
            Assert.True(result);
        }
        
        //==================================================================
        
        [Test]
        public void UniqueItemsArray_SecondApproach_Success_False()
        {
            int[] arr = {1,2,3,4};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithSorting();
            
            Assert.False(result);
        }
        
        [Test]
        public void ManyItemsArray_SecondApproach_Success_True()
        {
            int[] arr = {1,1,1,3,3,4,3,2,4,2};
            var sol = new ContainDuplicates(arr);
            var result = sol.GetContainDuplicatesWithSorting();
            
            Assert.True(result);
        }
        
        
        
    }
}