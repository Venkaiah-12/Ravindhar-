using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class StackLists<T>
    {
        Node<T> top = null;
        int size = 0;
        int push = 0;
        int pop = 0;

        public void pushCharacter(T Character)
        {
            Node<T> newnode = new Node<T>(Character);
            if (top == null)
            {
                top = newnode;
                newnode.next = null;
            }
            else
            {
                newnode.next = top;
                top = newnode;
            }
            size++;

        }
        public void popCharacter()
        {
            Node<T> current = top;
            if (top == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                while (top != null)
                {
                    Console.WriteLine(top.Data);
                    if (top.Data.Equals(')'))
                    {
                        push++;

                    }
                    else
                    {
                        pop++;
                    }
                    current = top;
                    top = top.next;
                    current = null;
                }
            }

        }
        public bool BalancedPharentheses()
        {
            bool status = false;
            if (pop == push)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public Object PeekStack()
        {
            if (top == null)

                Console.WriteLine("stack is empty");

            return null;


        }
        public bool IsEmpty()
        {
            bool status = true;
            if (top == null)
            {
                status = true;

            }
            else
            {
                status = false;
            }
            return status;
        }
        public int Size()
        {
            return size;
        }
    


    }
}


