using NUnit.Framework;

namespace LeetcodeTasks.MinStack
{
    public class MinStaskTests
    {
        [Test]
        public void FirstCase_Success()
        {
            var stack = new MinStack();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);

            var min = stack.GetMin();

            Assert.AreEqual(-3, min);
            
            stack.Pop();
            var top = stack.Top();

            Assert.AreEqual(0,top);

            min = stack.GetMin();

            Assert.AreEqual(-2, min);

        }
    }
}