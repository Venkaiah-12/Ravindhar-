using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeRange
    {
        public static void primenumbers()
        {
            Console.WriteLine("first number to start range");
            int fnum = Utility.IntegerInput();
            Console.WriteLine("second number to start range");
               int lnum = Utility.IntegerInput();
            int count = 0;
            for(int i=fnum;i<lnum;i++)
            {
              for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        count = 0;
                        break;
                    }
                    else
                    {
                        count = 1;

                    }
                }
              if(count==1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
