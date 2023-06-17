using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueuenormally
{
    class Queue
    {

        private Node front;
        private Node rear;
        private int count;

        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty");

            int item = front.Data;
            front = front.Next;

            if (front == null)
                rear = null;

            count--;
            return item;
        }

        public int Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty");

            return front.Data;
        }

        public void Clear()
        {
            front = null;
            rear = null;
            count = 0;
        }
    }
}
