using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{
    class LinkedList
    {
        public Node head;
       
      

        public void addNode(string strvalues)
        {
            Node CurrentNode = head;

            Node newnode = new Node(strvalues);

            if (head == null)
            {
                head = newnode;
               

            }
            else
            {
                while (CurrentNode.next != null)
                {
                    CurrentNode = CurrentNode.next;
                }
                CurrentNode.next = newnode;
               


            }
            display();





        }
        public  void display()
        {
            Node current = head;
            if(head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            
            while(current.next != null)
            {
               
                current = current.next;

            }
            Console.WriteLine(current.data);
           
        }
        public void removeNode(string item)
        {
            Node temp = head;
            Node prev = null;
            if(temp== null)
            {
                Console.WriteLine("empty");
            }
            else if(temp.data==item)
            {
                head = temp.next;  
            }
            else
            {
                while (temp!= null)
                {
                    if (temp.data == item)
                    {
                        prev = temp.next;
                        temp = null;
                        Console.WriteLine("found and deleted");
                        return;
                    }
                    prev = temp.next;
                    temp = null;

                }

            }
            display();

        }
        public bool  Search(string item)
        {
            bool status= false;
            if (head == null)
            {
                Console.WriteLine("item not found");
                status = false;
                return status;
            }

                Node temp = head;
            if (temp.data == item)
            {
                status = true;
                return status;
            }
            else
            {
                while(temp != null)
                {
                    if(temp.data.Equals(item))
                    {
                        Console.WriteLine("item found");
                        status = true;
                    }
                    temp = temp.next;
                }
                return status;
            }
        }
        public  bool isEmpty()
        {
            
            bool value =false;
            if (head == null)
            {
                value = true;
                return value;

            }
            else
                return false;
        }
        public int Size()
        {
            int count = 0;
            if (head == null)
            {
                count = 0;
                return count;
            }
           while(head != null)
            {
                count++;
                head = head.next;
            }
            return count;


        }
        public void Append( string word)
        {
            Node appendNode = new Node(word);
            if(head == null)
            {
                head = appendNode;
            }
            else
            {
                Node currentnode = head;
                while( currentnode.next != null)
                {
                    currentnode = currentnode.next;
                }
                currentnode.next = head;
            }

            display();
        }
        public int Index(string name)
        {

            Node currentnode = head;
            int count = 0;
            while(currentnode.data != name && currentnode.next  != null)
            {
                currentnode = currentnode.next;
                count++;
            }
            if(currentnode.data != name && currentnode.next==null)
            {
                return -1;

            }
            return count;
            //Console.WriteLine(position);

        }
        public void Insert(int pos, string name)
        {
            Node temp =head;

            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else if (temp.next != null)
            {
                Node currentnode = head;
                Node tempnode = new Node(name);
                while (pos > 1)
                {
                    currentnode = currentnode.next;
                    pos--;
                }
                tempnode.next = currentnode;
                currentnode.next = tempnode;
             }
            display();
        

           
        }
        public void Pop()
        {
          if(head ==null)
          {
                Console.WriteLine("list is empty"); 
           }
            else
            {

            }
        }


    }
}

