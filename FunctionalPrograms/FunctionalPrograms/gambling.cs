using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class gambling
    {
        public static  void gambler()
        {
            int n = Utility.userinputs();
            int trails = Utility.userinputs();
            int[] a = new int[trails];
            
            int stake = Utility.userinputs();
            int goal = Utility.userinputs();
          
            int wins = 0;      
           Utility.checkwin( wins,trails);
            Console.WriteLine("the win percent are " + wins / trails * 100);
            Console.WriteLine("the trails are" + trails);
            Console.WriteLine("the bets are" + wins);

        }
    }
}
