using AlgorithmsDataStructures.DataStructures;
using System;
using Xunit;

namespace Test.DataStructures
{
    public class DynamicArrayTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
        [InlineData("verdura")]
        public void AddValue(string value)
        {
            var array = new DynamicArray(2);
            array.Add(value);

            Assert.Equal(1, array.GetSize());
            Assert.Equal(value, array.Get(0));
            Assert.Null(array.Get(1));
        }


        [Fact]
        public void Add()
        {
            var array = new DynamicArray(2);
            array.Add("a");

            Assert.Equal(1, array.GetSize());
            Assert.Equal("a", array.Get(0));
            Assert.Null(array.Get(1));
        }

        [Fact]
        public void Insert()
        {
            var array = new DynamicArray(2);
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Insert(1, "d");

            Assert.Equal(4, array.GetSize());
            Assert.Equal("a", array.Get(0));
            Assert.Equal("d", array.Get(1));
            Assert.Equal("b", array.Get(2));
            Assert.Equal("c", array.Get(3));
        }

        [Fact]
        public void DeleteMiddle()
        {
            var array = new DynamicArray(2);
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Delete(1);

            Assert.Equal(2, array.GetSize());
            Assert.Equal("a", array.Get(0));
            Assert.Equal("c", array.Get(1));
        }

        [Fact]
        public void DeleteFirst()
        {
            var array = new DynamicArray(2);
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Delete(0);

            Assert.Equal(2, array.GetSize());
            Assert.Equal("b", array.Get(0));
            Assert.Equal("c", array.Get(1));
        }

        [Fact]
        public void DeleteLast()
        {
            var array = new DynamicArray(2);
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Delete(2);

            Assert.Equal(2, array.GetSize());
            Assert.Equal("a", array.Get(0));
            Assert.Equal("b", array.Get(1));
        }

        [Fact]
        public void Set()
        {
            var array = new DynamicArray(2);
            array.Add("a");
            array.Set(0, "b");

            Assert.Equal(1, array.GetSize());
            Assert.Equal("b", array.Get(0));
        }

        [Fact]
        public void Contains()
        {
            var array = new DynamicArray(2);
            array.Add("aaabaaaa");

            Assert.True(array.Contains("ba"));
        }

        [Fact]
        public void IsEmpty()
        {
            var array = new DynamicArray(2);

            Assert.True(array.IsEmpty());
            array.Add("a");
            Assert.False(array.IsEmpty());
        }

    }
}
