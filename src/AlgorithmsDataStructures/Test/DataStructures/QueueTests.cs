using AlgorithmsDataStructures.DataStructures;
using System;
using Xunit;

namespace Test.DataStructures
{
    public class QueueTests
    {
        [Fact]
        public void Add()
        {
            var stack = new Stack();
            stack.Add(1);
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void Remove()
        {
            var stack = new Stack();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            Assert.Equal(1, stack.Remove());
            Assert.Equal(2, stack.Peek());
        }

        [Fact]
        public void IsEmpty()
        {
            var stack = new Stack();
            Assert.True(stack.IsEmtpy());
            stack.Add(1);
            stack.Add(2);
            Assert.False(stack.IsEmtpy());
            Assert.Equal(1, stack.Remove());
            Assert.Equal(2, stack.Remove());
            Assert.True(stack.IsEmtpy());
        }

        [Fact]
        public void Peek()
        {
            var stack = new Stack();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            Assert.Equal(1, stack.Peek());
            Assert.Equal(1, stack.Remove());
            Assert.Equal(2, stack.Peek());
            Assert.Equal(2, stack.Remove());
            Assert.Equal(3, stack.Peek());
            Assert.Equal(3, stack.Remove());
            Assert.True(stack.IsEmtpy());
        }
    }
}
