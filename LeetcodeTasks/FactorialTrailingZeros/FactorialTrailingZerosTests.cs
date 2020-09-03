using NUnit.Framework;

namespace LeetcodeTasks.FactorialTrailingZeros
{
    public class FactorialTrailingZerosTests
    {

        [Test]
        public void Factorial_0() 
        {
            var sol = new Solution();
            var result = sol.TrailingZeroes(0);

            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Factorial_3() 
        {
            var sol = new Solution();
            var result = sol.TrailingZeroes(3);

            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Factorial_5() 
        {
            var sol = new Solution();
            var result = sol.TrailingZeroes(5);

            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Factorial_13() 
        {
            var sol = new Solution();
            var result = sol.TrailingZeroes(13);

            Assert.AreEqual(2, result);
        }
        
        
        [Test]
        public void Factorial_30() 
        {
            var sol = new Solution();
            var result = sol.TrailingZeroes(30);

            Assert.AreEqual(7, result);
        }
        
        [Test]
        public void Factorial_4415() 
        {
            var sol = new Solution();
            var result = sol.TrailingZeroes(4415);

            Assert.AreEqual(1102, result);
        }

    }
}