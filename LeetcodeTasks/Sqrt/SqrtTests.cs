using NUnit.Framework;

namespace LeetcodeTasks.Sqrt
{
    public class SqrtTests
    {
        [Test]
        public void FirstCase()
        {
            var sol = new  Solution();
            var result = sol.MySqrt(4);
            
            Assert.AreEqual(2,result);
        }
        
        
        [Test]
        public void SecondCase()
        {
            var sol = new  Solution();
            var result = sol.MySqrt(8);
            
            Assert.AreEqual(2,result);
        }
        
        [Test]
        public void ThirdCase()
        {
            var sol = new  Solution();
            var result = sol.MySqrt(2147395599);
            
            Assert.AreEqual(46339,result);
        }
        
        [Test]
        public void FourthCase()
        {
            var sol = new  Solution();
            var result = sol.MySqrt(5);
            
            Assert.AreEqual(2,result);
        }
    }
}