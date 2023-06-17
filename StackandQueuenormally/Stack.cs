using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackandQueuenormally
{
    class Stack
    {
        private Node top;
        private int count;

        public Stack()
        {
            top = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(int item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public int Pop()
        {
            if (count == 0)
                throw new InvalidOperationException("Stack is empty");

            int item = top.Data;
            top = top.Next;
            count--;
            return item;
        }

        public int Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Stack is empty");

            return top.Data;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }
    }
}
