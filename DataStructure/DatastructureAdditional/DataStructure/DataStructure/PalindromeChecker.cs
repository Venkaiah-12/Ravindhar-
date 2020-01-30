using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeChecker
    {
        public void Palindrome()
        {
            Dequeue dequeue = new Dequeue();
            Console.WriteLine("enter the string to add to  dequeue");
            string item = Utility.stringinput();
            dequeue.Addstring(item);


        }
    }
}
