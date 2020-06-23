using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks.SortedArrayToBST
{
    class SortedArrayToBStTests
    {

        [Test]
        public void TestFirstCase()
        {
            int[] array = null;
            var sol = new SortedArrayToBst(array);
            var result = sol.CreateBSTFromSortedArray();

            Assert.Null(result);
        }

        [Test]
        public void TestSecondCase()
        {
            int[] array = new int[] { };
            var sol = new SortedArrayToBst(array);
            var result = sol.CreateBSTFromSortedArray();

            Assert.Null(result);
        }


        [Test]
        public void TestThirdCase()
        {
            int[] array = new int[] { -10, -3, 0, 5, 9 };
            var sol = new SortedArrayToBst(array);
            var result = sol.CreateBSTFromSortedArray();

            Assert.IsNotNull(result);
        }





    }
}
