using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQues
{
    internal class Queue
    {
        public Node top;
        public void Push(int data)
        {
            Node newNode = new Node();

            newNode.data = data;
            newNode.next = null;
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                Node temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void DisplayQueue()
        {
            if (top == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
