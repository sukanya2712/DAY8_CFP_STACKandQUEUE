﻿namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack Count: " + stack.Count);

            Console.WriteLine("Peek: " + stack.Peek());

            object poppedItem = stack.Pop();
            Console.WriteLine("Popped Item: " + poppedItem);
            Console.WriteLine("Stack Count: " + stack.Count);

            stack.Clear();
            Console.WriteLine("Stack Count after Clear: " + stack.Count);


            Queue queue = new Queue();

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            Console.WriteLine("Queue Count: " + queue.Count);

            Console.WriteLine("Peek: " + queue.Peek());

            object dequeuedItem = queue.Dequeue();
            Console.WriteLine("Dequeued Item: " + dequeuedItem);
            Console.WriteLine("Queue Count: " + queue.Count);

            queue.Clear();
            Console.WriteLine("Queue Count after Clear: " + queue.Count);
        }
    }
}