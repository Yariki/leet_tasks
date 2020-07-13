using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.MoveZeros
{
    public class MoveZerosTests : BaseTest
    {
        [Test]
        public void NullOrEmpty_Success()
        {
            int[] arr = null;
            var sol = new MoveZeros(arr);
            sol.MovesZeros();
            
            Assert.IsNull(arr);
        }
        
        [Test]
        public void FirstArray_Success()
        {
            int[] arr = {0,1,0,3,12};
            var sol = new MoveZeros(arr);
            sol.MovesZeros();
            
            Assert.IsTrue(CheckArrayEquality(new int[]{1,3,12,0,0},arr ));
        }
        
        
    }
}