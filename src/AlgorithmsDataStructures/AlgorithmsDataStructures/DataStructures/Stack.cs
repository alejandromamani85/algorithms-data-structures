using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.DataStructures
{
    public class Stack
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        public Node head;
        public Node tail;

        public void Add(int value)
        {
            var newNode = new Node(value);
            if (tail == null)
            {
                tail = newNode;
                head = tail;
                return;
            }
            tail.next = newNode;
            tail = newNode;
            return;
        }

        public bool IsEmtpy()
        {
            return head == null;
        }

        public int Remove()
        {
            if (head == null)
                return -1;

            var currentNode = head;
            head = head.next;
            return currentNode.value;
        }

        public int Peek()
        {
            return head.value;
        }
    }
}
