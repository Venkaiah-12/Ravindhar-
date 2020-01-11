using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class couponnumber
    {
        public static void coupon()
        {


            int count = 0;
            int m = Utility.userInputs();
            int n = Utility.userInputs();
            double[,] arr = new double[m, n];
           Utility. shuffle(arr, m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr[i, j]);




                }



            }
        }
    }
}


