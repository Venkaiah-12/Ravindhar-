using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Gambling
    {
        public static  void gambler()
        {
            int n = Utility.userInputs();
            int trails = Utility.userInputs();
            int[] a = new int[trails];
            
            int stake = Utility.userInputs();
            int goal = Utility.userInputs();
          
            int wins = 0;      
           Utility.checkwin( wins,trails);
            Console.WriteLine("the win percent are " + wins / trails * 100);
            Console.WriteLine("the trails are" + trails);
            Console.WriteLine("the bets are" + wins);

        }
    }
}
