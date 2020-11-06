using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class StackLinkedList
    {
        Node top;
        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine(node.data + " pushed to Stack");
        }
        /// <summary>
        /// Displays the elements in stack.
        /// </summary>
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node n = top;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
    }
}
