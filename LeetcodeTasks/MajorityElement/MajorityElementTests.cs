using System.Threading;
using NUnit.Framework;

namespace LeetcodeTasks.MajorityElement
{
    public class MajorityElementTests
    {

        [Test]
        public void EmptyArray_Success()
        {
            int[] arr = null;
            var m  = new MajorityElement(arr);
            var result = m.GetMajorityElement();

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void ValidArray_1_Success()
        {
            int[] arr = new int[]{3,2,3};
            var m = new MajorityElement(arr);
            var result = m.GetMajorityElement();

            Assert.AreEqual(3, result);
        }

        [Test]
        public void ValidArray_2_Success()
        {
            int[] arr = new int[] {2,2,1,1,1,2,2};
            var m = new MajorityElement(arr);
            var result = m.GetMajorityElement();

            Assert.AreEqual(2, result);
        }


    }
}