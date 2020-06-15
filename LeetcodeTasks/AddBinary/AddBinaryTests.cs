using NUnit.Framework;

namespace LeetcodeTasks.AddBinary
{
    public class AddBinaryTests
    {
        [Test]
        public void TestFirstCase()
        {
            var sol = new Solution();
            var result = sol.AddBinary("11", "1");
            
            Assert.AreEqual("100",result);
        }
        
        [Test]
        public void TestSecondCase()
        {
            var sol = new Solution();
            var result = sol.AddBinary("1010", "1011");
            
            Assert.AreEqual("10101",result);
        }
    }
}