using System.Collections.Generic;
using NUnit.Framework;

namespace LeetcodeTasks.PrintPaskal
{
    public class PrintPaskalTriangleTests
    {

        [Test]
        public void TestFirstCase()
        {
            var sol = new PrintPaskalTriangle(0);
            var result = sol.GetPaskalTriangle();

            Assert.NotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void TestSecondTest()
        {
            var expected = new List<IList<int>>()
            {
                new List<int>(){1}
            };

            var sol = new PrintPaskalTriangle(1);
            var result = sol.GetPaskalTriangle();

            Assert.True(CheckLists(expected, result));
        }


        private bool CheckLists(IList<IList<int>> expected, IList<IList<int>> actual)
        {
            if (actual == null) return false;
            if (expected.Count != actual.Count) return false;

            for (int i = 0; i < expected.Count; i++)
            {
                var e = expected[i];
                var a = actual[i];

                if (e.Count != a.Count) return false;

                for (int j = 0; j < e.Count; j++)
                {
                    if (e[j] != a[j])
                        return false;
                }
            }
            return true;
        }
    }
}