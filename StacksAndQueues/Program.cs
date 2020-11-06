using System;

namespace StacksAndQueues
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///UC1-Creating stack and pushing elements.
            Console.WriteLine("Welcome to Data Structures Stack and Queue.");
            StackLinkedList stack = new StackLinkedList();
            Console.WriteLine("****Stack****");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            ///UC2 Ability to peak and pop from stack.
            stack.Size();
            stack.Peak();
            stack.Pop();
            Console.WriteLine("Stack :");
            stack.Display();
            stack.Size();
            ///UC3 Creating Queue Using linked list.
            QueueLinkedList queue = new QueueLinkedList();
            Console.WriteLine("****Queue****");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Size();
            ///UC4 Dequeue elements.
            queue.Dequeue();
            queue.Display();
            queue.Size();
        }
    }
}
