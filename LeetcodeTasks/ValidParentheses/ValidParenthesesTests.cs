using NUnit.Framework;

namespace LeetcodeTasks.ValidParentheses
{
    public class ValidParenthesesTests
    {
        
        [Test]
        public void FirstCase_Success()
        {
            var testCase = "[]";
            var sol = new Solution();
            
            Assert.True(sol.IsValid(testCase));
        }
        
        [Test]
        public void SecondCase_Success()
        {
            var testCase = "()[]{}";
            var sol = new Solution();
            
            Assert.True(sol.IsValid(testCase));
        }
        
        [Test]
        public void ThirdCase_Success()
        {
            var testCase = "[}";
            var sol = new Solution();
            
            Assert.False(sol.IsValid(testCase));
        }
        
        //([)]
        [Test]
        public void FourthCase_Success()
        {
            var testCase = "([)]";
            var sol = new Solution();
            
            Assert.False(sol.IsValid(testCase));
        }
        
        [Test]
        public void FifthCase_Success()
        {
            var testCase = "{[]}";
            var sol = new Solution();
            
            Assert.True(sol.IsValid(testCase));
        }
        
        [Test]
        public void OneParentheses_Success()
        {
            var testCase = "{";
            var sol = new Solution();
            
            Assert.False(sol.IsValid(testCase));
        }
        
        [Test]
        public void FirstIsClosed_Success()
        {
            var testCase = "}(){}";
            var sol = new Solution();
            
            Assert.False(sol.IsValid(testCase));
        }
        
        [Test]
        public void TestCaseIsEmpty_Success()
        {
            var testCase = "";
            var sol = new Solution();
            
            Assert.True(sol.IsValid(testCase));
        }
        
        [Test]
        public void TwoSameParentheses_Success()
        {
            var testCase = "((";
            var sol = new Solution();
            
            Assert.False(sol.IsValid(testCase));
        }
        
        
        
        
    }
}