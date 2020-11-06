using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class QueueLinkedList
    {
        Node head;
        /// <summary>
        /// UC-3
        /// Adds the element queue.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine(node.data + " inserted into Queue");
        }
        /// <summary>
        /// UC-4
        /// Deletes the element from queue.
        /// </summary>
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(head.data + " removed from Queue");
                head = head.next;
            }
        }
        /// <summary>
        /// Displays the element from queue.
        /// </summary>
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
        /// <summary>
        /// Gives size of queue.
        /// </summary>
        public void Size()
        {
            int count = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size :" + count);
        }
    }
}
