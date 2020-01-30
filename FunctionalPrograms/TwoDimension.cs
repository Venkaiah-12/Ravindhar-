using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TwoDimension
    {
        public static void twodim()
        {


            int m = Utility.userInputs();
            int n = Utility.userInputs();
            int[,] arr = new int[m, n];
            double[,] douby = new double[m, n];
          
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("enter the arr[" + i + "," + j + ",]:");
                        arr[i, j] =Utility.userInputs();
                        Console.WriteLine("enter the doub[" + i + "," + j + ",]:");
                        douby[i, j] =Utility.userInputs();
                    }
                }
            
            for (int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("the array elements" + arr[i, j]);
                    Console.WriteLine("the double elements" + douby[i, j]);
                }
            }
        }

    }
}
