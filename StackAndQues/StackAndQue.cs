using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQues
{
    internal class Stack
    {
        public Node top;
        public void Push(int data)
        {
            Node newNode = new Node();

            newNode.data = data;
            newNode.next = null;
            newNode.next = top;
            top = newNode;
        }

        public void DisplayStack()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
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
