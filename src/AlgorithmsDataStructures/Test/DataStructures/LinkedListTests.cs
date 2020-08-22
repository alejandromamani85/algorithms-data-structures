using AlgorithmsDataStructures.DataStructures;
using System;
using Xunit;

namespace Test.DataStructures
{
    public class LinkedListTests
    {
        [Fact]
        public void AddFront()
        {
            var linkedList = new LinkedList();
            linkedList.AddFront(1);
            Assert.Equal(1, linkedList.GetFirst());
        }

        [Fact]
        public void GetSize()
        {
            var linkedList = new LinkedList();

            Assert.Equal(0, linkedList.GetSize());
            linkedList.AddFront(1);
            Assert.Equal(1, linkedList.GetSize());
            linkedList.AddFront(2);
            Assert.Equal(2, linkedList.GetSize());
        }

        [Fact]
        public void Delete()
        {
            var linkedList = new LinkedList();
            linkedList.AddFront(10);
            Assert.Equal(10, linkedList.GetLast());
            linkedList.AddBack(9);
            Assert.Equal(9, linkedList.GetLast());
            linkedList.AddBack(8);
            Assert.Equal(8, linkedList.GetLast());
        }

        [Fact]
        public void AddBack()
        {
            var linkedList = new LinkedList();

            linkedList.AddFront(25);
            linkedList.AddFront(30);
            linkedList.AddBack(50);
            Assert.Equal(50, linkedList.GetLast());
        }

        [Fact]
        public void Clear()
        {
            var linkedList = new LinkedList();

            linkedList.AddFront(25);
            linkedList.AddFront(30);
            linkedList.AddBack(50);
            Assert.Equal(3, linkedList.GetSize());
            linkedList.Clear();
            Assert.Equal(0, linkedList.GetSize());
        }
    }
}
