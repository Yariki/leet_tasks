using System.Collections.Generic;
using System.Reflection.Metadata;
using NUnit.Framework;

namespace LeetcodeTasks.PrintOnePascalTriangleRow
{
    public class PrintOnePaskalTriangleRowTests
    {

        [Test]
        public void TestFirstCase()
        {
            var sol = new PrintOnePaskalTriangleRow(0);
            var result = sol.GetOneRow();

            Assert.NotNull(result);
            Assert.True(CheckLists( new List<int>(){1}, result));
        }

        [Test]
        public void TestSecondTest()
        {
            var sol = new PrintOnePaskalTriangleRow(3);
            var result = sol.GetOneRow();

            Assert.True(CheckLists(new List<int>(){1, 3, 3, 1}, result ));
        }

        [Test]
        public void TestThirdTest()
        {
            var sol = new PrintOnePaskalTriangleRow(30);
            var result = sol.GetOneRow();

            Assert.True(CheckLists(new List<int>() {
                1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225,
                119759850,
                145422675, 155117520, 145422675, 119759850, 86493225, 54627300, 30045015, 14307150, 5852925, 2035800,
                593775,
                142506, 27405, 4060, 435, 30, 1
            }, result));
        }


        private bool CheckLists(IList<int> expected, IList<int> actual)
        {
            if (actual == null) return false;
            if (expected.Count != actual.Count) return false;


            if (expected.Count != actual.Count) return false;

            for (int j = 0; j < expected.Count; j++)
            {
                if (expected[j] != actual[j])
                    return false;
            }

            return true;
        }

    }
}