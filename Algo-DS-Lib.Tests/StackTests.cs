using System;
using DataStruct.Statck;
using NUnit.Framework;

namespace Algo_DS_Lib.Tests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new LinkedStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }
        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }
        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new LinkedStack<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                stack.Pop();
            });
        }
        [Test]
        public void Peek_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
    }
}
