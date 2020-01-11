using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class factors
    {
        public static void factornumber()
        {
            
            Console.WriteLine("enter the number to find factor");
            int number = int.Parse(Console.ReadLine());
            for(int i=1;i<=number;i++)
            {
                if(number%i ==0)
                {
                    Console.WriteLine("the factors are " + i);
                }
            }
            
        }
    }
}
