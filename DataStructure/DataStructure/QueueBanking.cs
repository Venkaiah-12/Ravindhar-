using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class QueueBanking
    {
        public void Bankinglist()
        {
            Queue<string> queuelist = new Queue<string>();
            Console.WriteLine("welocme to Bank ");
            Console.WriteLine("---------------------");
            Console.Write("enter the how many members in bank : ");
            int members = Utility.IntegerInput();
            for (int index = 1; index <= members; index++)
            {
                Console.WriteLine("enter the name of the customer :");
                string Customername = Utility.stringinput();
                queuelist.addingqueue(Customername);
            }
            queuelist.dequeue();



        }
    }
}
