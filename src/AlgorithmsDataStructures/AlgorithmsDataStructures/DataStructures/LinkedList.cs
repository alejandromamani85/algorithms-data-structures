using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.DataStructures
{
    public class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node head;

        public int GetFirst()
        {
            if (head == null)
                throw new Exception("Empty List");
            return head.data;
        }

        public int GetLast()
        {
            if (head == null)
                throw new Exception("Empty List");
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            return current.data;
        }

        public void AddFront(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void AddBack(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }

        public int GetSize()
        {
            if (head == null)
                return 0;

            int count = 1;
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

        public void Clear()
        {
            head = null;
        }

        public void DeleteValue(int data)
        {
            if (head == null)
                return;

            //Delete First
            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            //Delete Middle
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void Print()
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                Console.WriteLine($"index: {index}\tvalue: {current.data}");
                current = current.next;
            }
        }
    }
}
