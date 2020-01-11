using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class poweroftwo
    {
        public static void powertwo()
        {
            Console.WriteLine("enter the number for poweroftwo");
            int i = 0;
            int num = int.Parse(Console.ReadLine());
            int powerOfTwo = 1;
            while(i<=num)
            {
                Console.WriteLine(i + "  " + powerOfTwo);
                powerOfTwo = 2 * powerOfTwo;
                i++;

            }
        }
    }
}
