using System.Runtime.InteropServices;
using NUnit.Framework;

namespace LeetcodeTasks.ImageSmoother
{
    public class ImageSmootherTest
    {

        [Test]
        public void TestWorking()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 1, 1 };
            arr[1] = new int[] { 1, 0, 1 };
            arr[2] = new int[] { 1, 1, 1 };

            var sol = new Solution();
            var result = sol.ImageSmoother(arr);

            Assert.IsNotNull(result);
        }
    }
}