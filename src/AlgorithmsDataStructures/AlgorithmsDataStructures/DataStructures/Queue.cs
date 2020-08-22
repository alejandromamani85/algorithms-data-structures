using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.DataStructures
{
    public class Queue
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

        public void Push(int value)
        {
            var newTopNode = new Node(value);
            if (head == null)
            {
                head = newTopNode;
                return;
            }
            newTopNode.next = head;
            head = newTopNode;
            return;
        }

        public bool IsEmtpy()
        {
            return head == null;
        }

        public int Pop()
        {
            if (head == null)
                return -1;
            var topNode = head;
            head = head.next;
            return topNode.value;
        }

        public int Peek()
        {
            return head.value;
        }
    }
}
