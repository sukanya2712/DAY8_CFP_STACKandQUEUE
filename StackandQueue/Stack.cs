using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    class Stack
    {

        private ArrayList elements;

        public Stack()
        {
            elements = new ArrayList();
        }

        public int Count
        {
            get { return elements.Count; }
        }

        public void Push(object item)
        {
            elements.Add(item);
        }

        public object Pop()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            int lastIndex = elements.Count - 1;
            object item = elements[lastIndex];
            elements.RemoveAt(lastIndex);
            return item;
        }

        public object Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return elements[elements.Count - 1];
        }

        public void Clear()
        {
            elements.Clear();
        }
    }
}
