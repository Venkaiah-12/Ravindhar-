using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class flipcoin
    {
        public static void flippercentage()
        {
            Console.WriteLine("the flip coin percentage");
            int head = 0;
            int flips = int.Parse(Console.ReadLine());
            Random r = new Random();
            int radnum = r.Next();
            for(int i=0;i<=flips;i++)
            {
                if(radnum > 0.5)
                {
                    head++;

                }
            }
            int percent = head * 10 / 100;
            Console.WriteLine("the percent of head=" + percent);
        }
    }
}
