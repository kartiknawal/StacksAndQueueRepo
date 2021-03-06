﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProgram
{
    class Queue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty, Dequeuing is not possible");
                return;
            }
            Console.WriteLine("{0} is Dequeued ", this.head.data);
            this.head = this.head.next;
        }
        internal void IsEmpty()
        {
            while (this.head != null)
            {
                Dequeue();
            }
        }
    }
}
