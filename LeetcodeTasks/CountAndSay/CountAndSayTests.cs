using System.Text;
using NUnit.Framework;

namespace LeetcodeTasks.CountAndSay
{
    public class CountAndSayTests
    {
        [Test]
        public void Test_One()
        {
            var sol = new Solution();
            var result = sol.CountAndSay(1);
            
            Assert.AreEqual("1",result);
        }
        
        [Test]
        public void Test_Fourth()
        {
            var sol = new Solution();
            var result = sol.CountAndSay(4);
            
            Assert.AreEqual("1211",result);
        }
        
        [Test]
        public void Test_Five()
        {
            var sol = new Solution();
            var result = sol.CountAndSay(5);
            
            Assert.AreEqual("111221",result);
        }
    }
}