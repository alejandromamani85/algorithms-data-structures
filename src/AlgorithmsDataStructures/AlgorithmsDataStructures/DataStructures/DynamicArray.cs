using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.DataStructures
{
    public class DynamicArray
    {
        private object[] data;
        private int initialCapacity;
        private int size;

        public DynamicArray(int initialCapacity)
        {
            this.data = new object[initialCapacity];
            this.initialCapacity = initialCapacity;
            this.size = 0;
        }

        public int GetSize()
        {
            return this.size;
        }

        public string Get(int index)
        {
            return (string)data[index];
        }

        public void Set(int index, string value)
        {
            data[index] = value;
        }

        public void Add(string value)
        {
            Insert(this.size, value);
        }

        public void Insert(int index, string value)
        {
            if (this.size == this.initialCapacity)
                Resize();
            for (int i = this.size; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = value;
            this.size++;
        }

        public void Delete(int index)
        {
            for (int i = index; i < this.size - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[this.size - 1] = null;
            size--;
        }

        public bool Contains(string value)
        {
            for (int i = 0; i < this.size; i++)
            {
                string currentValue = (string)data[i];
                if (currentValue.Contains(value))
                    return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        private void Resize()
        {
            this.initialCapacity = this.initialCapacity * 2;
            object[] dataNew = new object[this.initialCapacity];
            for (int i = 0; i < this.size; i++)
            {
                dataNew[i] = data[i];
            }
            this.data = dataNew;
        }
    }
}
