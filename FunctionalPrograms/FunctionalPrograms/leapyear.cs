﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class leapyear
    {
        public static void foundyear()
            {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while(num > 0)
            {
                 int r=num % 10;
                num = num / 10;
                count++;
                
            }
            if (count == 4)
            {
                if (num % 4 == 0 || num % 400 == 0 && num % 100 != 0)
                {
                    Console.WriteLine("num is leap year" + num);


                }
                else

                    Console.WriteLine("num is not leap year");
            }
            else

                Console.WriteLine("the number is not valid must be four digit");
                
            }
            

        }
    }

