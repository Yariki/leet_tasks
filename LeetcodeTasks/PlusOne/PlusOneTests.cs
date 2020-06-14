using System;
using NUnit.Framework;

namespace LeetcodeTasks.PlusOne
{
    public class PlusOneTests
    {
        [Test]
        public void FirstCase_Success()
        {
            var arr = new int[]{4,9,9,9};
            var so = new Solution();
            var result = so.PlusOne(arr);

            Assert.True(CheckArrayEquality(new []{5,0,0,0}, result));
        }
        
        [Test]
        public void SecondCase_Success()
        {
            var arr = new int[]{1,2,3};
            var so = new Solution();
            var result = so.PlusOne(arr);

            Assert.True(CheckArrayEquality(new []{1,2,4}, result));
        }
        
        [Test]
        public void ThirdCase_Success()
        {
            var arr = new int[]{4,3,2,1};
            var so = new Solution();
            var result = so.PlusOne(arr);

            Assert.True(CheckArrayEquality(new []{4,3,2,2}, result));
        }
        
        [Test]
        public void FourthCase_Success()
        {
            var arr = new int[]{9};
            var so = new Solution();
            var result = so.PlusOne(arr);

            Assert.True(CheckArrayEquality(new []{1,0}, result));
        }
        
        [Test]
        public void FifthCase_Success()
        {
            var arr = new int[]{9,8,7,6,5,4,3,2,1,0};
            var so = new Solution();
            var result = so.PlusOne(arr);

            Assert.True(CheckArrayEquality(new []{9,8,7,6,5,4,3,2,1,1}, result));
        }
        
        [Test]
        public void FirstCase_SolTwo_Success()
        {
            var arr = new int[]{4,9,9,9};
            var so = new PlusOne(arr);
            var result = so.SolutionTwo();

            Assert.True(CheckArrayEquality(new []{5,0,0,0}, result));
        }
        
        [Test]
        public void SecondCase_SolTwo_Success()
        {
            var arr = new int[]{1,2,3};
            var so = new PlusOne(arr);
            var result = so.SolutionTwo();

            Assert.True(CheckArrayEquality(new []{1,2,4}, result));
        }
        
        [Test]
        public void ThirdCase_SolTwo_Success()
        {
            var arr = new int[]{4,3,2,1};
            var so = new PlusOne(arr);
            var result = so.SolutionTwo();

            Assert.True(CheckArrayEquality(new []{4,3,2,2}, result));
        }
        
        [Test]
        public void FourthCase_SolTwo_Success()
        {
            var arr = new int[]{9};
            var so = new PlusOne(arr);
            var result = so.SolutionTwo();

            Assert.True(CheckArrayEquality(new []{1,0}, result));
        }
        
        [Test]
        public void FifthCase_SolTweo_Success()
        {
            var arr = new int[]{9,8,7,6,5,4,3,2,1,0};
            var so = new PlusOne(arr);
            var result = so.SolutionTwo();

            Assert.True(CheckArrayEquality(new []{9,8,7,6,5,4,3,2,1,1}, result));
        }
        



        private bool CheckArrayEquality(int[] expected, int[] result)
        {
            if (expected.Length != result.Length)
                return false;


            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != result[i])
                    return false;
            }

            return true;
        }
        
    }
}