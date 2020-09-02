using NUnit.Framework;

namespace LeetcodeTasks.ExcelSheetColumnTitle
{
    public class NumberToITitleConverterTests
    {
        [Test]
        public void ColumnOne_Test()
        {
            var column = 0;
            var sol = new Solution();
            var result = sol.ConvertToTitle(column);
            
            Assert.IsTrue(string.IsNullOrEmpty(result));
        }

        [Test]
        public void Column28_Test()
        {
            var column = 28;
            var sol = new Solution();
            var result = sol.ConvertToTitle(column);
            
            Assert.AreEqual("AB",result);
        }
        
        [Test]
        public void Column52Test()
        {
            var column = 52;
            var sol = new Solution();
            var result = sol.ConvertToTitle(column);
            
            Assert.AreEqual("AZ",result);
        }
        
        [Test]
        public void Column701_Test()
        {
            var column = 701;
            var sol = new Solution();
            var result = sol.ConvertToTitle(column);
            
            Assert.AreEqual("ZY",result);
        }
        
        
    }
}