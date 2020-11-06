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
        /// Pops(Delete) the elements from the stack.
        /// </summary>
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data + " popped from Stack");
                top = top.next;
            }
        }
        /// <summary>
        /// Peaks the top element from the stack.
        /// </summary>
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data + " is at peak element top of Stack");
            }
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
        /// <summary>
        /// Gives the size of stack.
        /// </summary>
        public void Size()
        {
            int count = 0;
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size :" + count);
        }
        /// <summary>
        /// Determines whether the Stack is empty.
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peak();
                Pop();
                Console.WriteLine("Stack is Empty");
            }
        }
    }
}
