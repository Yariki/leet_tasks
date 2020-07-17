using System.Linq;
using LeetcodeTasks.Base;
using NUnit.Framework;

namespace LeetcodeTasks.FindDisappearedNumbers
{
    public class FindDisappearedNumbersTests : BaseTest
    {
        [Test]
        public void NullOfEmptyArray_Success()
        {
            int[] arr = null;
            var sol = new FindDisappearedNumbers(arr);
            var result = sol.GetFindDisappearedNumbers();

            Assert.IsNotNull(result);
            Assert.AreEqual(0,result.Count);
        }


        [Test]
        public void FirstArray_Success()
        {
            int[] arr = {4, 3, 2, 7, 8, 2, 3, 1};
            var sol = new FindDisappearedNumbers(arr);
            var result = sol.GetFindDisappearedNumbers();

            Assert.IsNotNull(result);
            Assert.IsTrue(CheckArrayEquality(new int[]{5,6},result.ToArray() ));
        }

    }
}