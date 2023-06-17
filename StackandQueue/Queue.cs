using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    class Queue
    {

        private ArrayList elements;

        public Queue()
        {
            elements = new ArrayList();
        }

        public int Count
        {
            get { return elements.Count; }
        }

        public void Enqueue(object item)
        {
            elements.Add(item);
        }

        public object Dequeue()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            object item = elements[0];
            elements.RemoveAt(0);
            return item;
        }

        public object Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return elements[0];
        }

        public void Clear()
        {
            elements.Clear();
        }
    }
}
