using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagramtoStack
    {
        public  Node1 top = null;
        int size = 0;
        public void Anagramstack(int number)
        {
            Node1 newNode = new Node1(number);
            if(top== null)
            {
                top = newNode;
                
             
            }
            else
            {
                top.next= newNode;
            ////  newNode.next=top;
                top = newNode;

            }
            size++;
          
        }
        public void Display()
        {
            if(top==null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                while(top.next != null)
                {
                    
                    Console.WriteLine(top.Data + " ");
                    top = top.next;
                }

               


            }

        }
    }
}
