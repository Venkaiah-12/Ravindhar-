using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Dequeue<T>
    {
        public Node<T> head = null;
        public Node<T> Left;
        public Node<T> Right;
        string str = "";
        int size = 0;
        public void AddRear(T Character)
        {
            Node<T> newnode = new Node<T>(Character);
            if (head == null)
            {
                Left = Right = newnode;

            }
            else
            {
                Right.next = newnode;
                newnode.Left = Right;
                Right = newnode;
            }
            Console.WriteLine("after adding rear" + Display());
           
            size++;
        }
        public void AddFront(T Character)
        {
            Node<T> newnode = new Node<T>(Character);
            if(Left==null)
            {
                Left = Right = newnode;
            }
            else
            {
                newnode.next = Left;
                Left.prev = newnode;
                Left = newnode;


            }
          ////  Console.WriteLine("after adding front" + Display());
          
        }
        public string Display()
        {
            Node<T> Current=head;
           if(Left == null)
            {
                Console.WriteLine("dequeue is empty"); 

            }
            else
            {
                while(Left != null)
                {

                    ////   Console.WriteLine(Left.Data);
                    str = str+Left.Data;
                    Left = Left.next;
                }
              
            }
            return str;
        }
        public string RemoveFront()
        {
           
            Node<T> prevnode;
           
            if (Left == null)
            {
                Console.WriteLine("dequeue is empty nothing to remove");
            }
            else
            {
              char Character = (char)Left.Data;
                prevnode = Left;
                Left = Left.next;
                prevnode = null;

                return Character.ToString();


             
            }
            return null;
        }

        public string Removerear()
        {
            Node<T> prevnode;
            if(Right==null)
            {
                Console.WriteLine("dequeue is empty");

            }
            else
            {
                char Character = (char)Right.Data;
                prevnode = Right;
                Right = Right.prev;
                prevnode.prev = null;
                return Character.ToString();
            }
            return null;
        }
        public bool IsPalindrome()
        {
            string name1=string.Empty;
            string name2=string.Empty;
            bool ispalindrome = false;
            if (size % 2 == 0)
            {
                while (size != 0)
                {
                     name1 = RemoveFront();
                    name2 = Removerear();
                    size--;
                }
               if(name1.Equals(name2))
                {
                    ispalindrome = true;
                }
            }
            if(size % 2 == 1)
            {
                Console.WriteLine("dequeue contains insufficient character");
            }else
            {
                Console.WriteLine("dequeue contain character");
            }
            return ispalindrome;
        }
    }
}
