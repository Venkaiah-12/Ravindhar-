using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class ReplaceString
    {
        public static void ReplaceStringMethod()
        {
            Console.WriteLine("Hello <<username>> ,how are you");
            string str = Console.ReadLine();
            int l = str.Length;
            if(l>=3)
            {
                Console.WriteLine("Hello{0},how are you",str);

            }
        }
    }
}
