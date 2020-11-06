﻿using System;

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
        }
    }
}
