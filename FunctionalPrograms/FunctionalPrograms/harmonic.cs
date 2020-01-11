using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class harmonic
    {
        public static void  harmonicseries()
        {
            Console.WriteLine("enter the nth number");
            int number = int.Parse(Console.ReadLine());

            float sum  = 1;
            for(int i=2;i<number;i++)
            {
                sum = sum + (float)1 / i;
          
          Console.WriteLine("the harmonic numberis :" + sum);
            }

        }
    }
}
