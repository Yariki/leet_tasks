using NUnit.Framework;

namespace LeetcodeTasks.ClimbStairs
{
    public class ClimbStairsTests
    {
        [Test]
        public void Case_2()
        {
            var cs = new ClimbStairs(2);
            var result = cs.SolutionOne();
            
            Assert.AreEqual(2,result);
        }
        
        [Test]
        public void Case_3()
        {
            var cs = new ClimbStairs(3);
            var result = cs.SolutionOne();
            
            Assert.AreEqual(3,result);
        }
    }
}