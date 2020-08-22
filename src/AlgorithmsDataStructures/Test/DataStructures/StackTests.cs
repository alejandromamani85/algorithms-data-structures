using AlgorithmsDataStructures.DataStructures;
using System;
using Xunit;

namespace Test.DataStructures
{
    public class StackTests
    {
        [Fact]
        public void Push()
        {
            var stack = new Stack();
            stack.Add(1);
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void Pop()
        {
            var stack = new Stack();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            Assert.Equal(3, stack.Remove());
            Assert.Equal(2, stack.Peek());
        }

        [Fact]
        public void IsEmpty()
        {
            var stack = new Stack();
            Assert.True(stack.IsEmtpy());
            stack.Add(1);
            Assert.False(stack.IsEmtpy());
        }

        [Fact]
        public void Peek()
        {
            var stack = new Stack();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            Assert.Equal(3, stack.Peek());
            Assert.Equal(3, stack.Remove());
            Assert.Equal(2, stack.Peek());
            Assert.Equal(2, stack.Remove());
            Assert.Equal(1, stack.Peek());
            Assert.Equal(1, stack.Remove());
            Assert.True(stack.IsEmtpy());
        }

        //[Fact]
        //public void GetSize()
        //{
        //    var linkedList = new LinkedList();

        //    Assert.Equal(0, linkedList.GetSize());
        //    linkedList.AddFront(1);
        //    Assert.Equal(1, linkedList.GetSize());
        //    linkedList.AddFront(2);
        //    Assert.Equal(2, linkedList.GetSize());
        //}

        //[Fact]
        //public void Delete()
        //{
        //    var linkedList = new LinkedList();
        //    linkedList.AddFront(10);
        //    Assert.Equal(10, linkedList.GetLast());
        //    linkedList.AddBack(9);
        //    Assert.Equal(9, linkedList.GetLast());
        //    linkedList.AddBack(8);
        //    Assert.Equal(8, linkedList.GetLast());
        //}

        //[Fact]
        //public void AddBack()
        //{
        //    var linkedList = new LinkedList();

        //    linkedList.AddFront(25);
        //    linkedList.AddFront(30);
        //    linkedList.AddBack(50);
        //    Assert.Equal(50, linkedList.GetLast());
        //}

        //[Fact]
        //public void Clear()
        //{
        //    var linkedList = new LinkedList();

        //    linkedList.AddFront(25);
        //    linkedList.AddFront(30);
        //    linkedList.AddBack(50);
        //    Assert.Equal(3, linkedList.GetSize());
        //    linkedList.Clear();
        //    Assert.Equal(0, linkedList.GetSize());
        //}
    }
}
