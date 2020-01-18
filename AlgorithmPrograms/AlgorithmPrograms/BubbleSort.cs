using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public void bubblesort()
        {
            Console.WriteLine("enter the length of array:");
            int n = Utility.IntegerInput();
            int[] a = new int[n];
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("enter the a[" + i + "]:");
                 a[i] = Utility.IntegerInput();
            }
            Utility.arraysorting(a,n);
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("the sorted array is: " + a[i]);
            }
        }

    }
}
