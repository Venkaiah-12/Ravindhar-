using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeChecker
    {
        public void Palindrome()
        {
            Dequeue<char> dequeue = new Dequeue<char>();
            Console.WriteLine("enter the string to add to  dequeue");
            string item = Utility.stringinput();
            char[] array = item.ToCharArray();
            for (int index = 0; index < array.Length; index++)
            {
                dequeue.AddRear(array[index]);
              ////  dequeue.AddFront(array[index]);
            }
            Console.WriteLine( dequeue.IsPalindrome());
            



        }
    }
}
