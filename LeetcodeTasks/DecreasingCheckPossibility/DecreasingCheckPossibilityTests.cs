using NUnit.Framework;

namespace LeetcodeTasks.DecreasingCheckPossibility
{
    public class DecreasingCheckPossibilityTests
    {
        [Test]
        public void ArrayNullOrEmpty()
        {
            int[] arr = null;
            var sol = new Solution();
            var result = sol.CheckPossibility(arr);

            Assert.IsFalse(result);
        }

        [Test]
        public void FirstArray_Test()
        {
            int[] arr = new int[] { 4, 2, 3 };
            var sol = new Solution();
            var result = sol.CheckPossibility(arr);

            Assert.IsTrue(result);
        }

        [Test]
        public void SecondArray_Test()
        {
            int[] arr = new int[] { 4, 2, 1 };
            var sol = new Solution();
            var result = sol.CheckPossibility(arr);

            Assert.IsFalse(result);
        }


        [Test]
        public void ThirdArray_Test()
        {
            int[] arr = new int[] { 3,4,2,3 };
            var sol = new Solution();
            var result = sol.CheckPossibility(arr);

            Assert.IsFalse(result);
        }



    }
}