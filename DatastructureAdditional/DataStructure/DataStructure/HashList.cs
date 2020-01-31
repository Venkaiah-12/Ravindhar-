using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class HashList
    {
        Node1 []array = new Node1[10];
        int remainder;
        public void hasing(int value)
        {
            Node1 newnode = new Node1(value);
            remainder = value % 11;
            Console.WriteLine("the remainder is "+ remainder);
              
                if(array[remainder] == null)
                {
                    array[remainder] = newnode ;
            }
            else
            {
                Node1 n = array[remainder];
                while(n.next != null)
                {
                    n = n.next;
                }
                n.next = newnode;
            }
            Display();

            
        }
        public void Display()
        {
            Node1 n = array[remainder];
            if(n== null)
            {
                Console.WriteLine("list is empty");

            }
            else
            {
                while(n != null )
                {
                    Console.WriteLine(n.Data + " ");
                    n = n.next;
                }
             
            }
        }
    }
}
