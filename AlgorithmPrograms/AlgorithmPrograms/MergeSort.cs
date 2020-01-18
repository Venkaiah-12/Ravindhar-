using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSort
    {
        int[] temparr;
        int[] array;
        int length;
        public void mergesort()
        {
           
            int[] a = { 45, 10, 23, 65, 1, 2, 7, 0, 4, 5 };
            arrSort(a);
            foreach(int i in a)
            { 
                Console.WriteLine(i + " ");
            }
        }
        public  void arrSort(int[] a)
        {
            this.array = a;
            this.length = a.Length;
            this.temparr = new int[length];
            int lowerindex =0,highindex=length-1;
            dividearray( lowerindex, highindex);


        }
        public void dividearray(int l,int h)
        {
            if(l < h)
            {
                int midindex = l + (h - l) / 2;

                dividearray(l, midindex);
                dividearray(midindex + 1, h);
                mergearray(l, midindex, h);
            }
        }
        public void mergearray(int lowerindex,int midindex,int highindex)
        {
            for(int M= lowerindex;M<= highindex;M++)
            {
                temparr[M] = array[M];
            }
           int  i = 0;
            int j = 0;
            int k = 0;
            while (i <= midindex && j <= highindex)
            {
                if (temparr[i] <= temparr[j])
                {
                    array[k] = temparr[i];
                    i++;

                }
                else
                {
                    array[k] = temparr[j];
                    j++;

                }
                k++;
            }
                while(i<=midindex)
                {
                    array[k] = temparr[i];
                    i++;
                    k++;

                }
                    
                


            

        }









    }   
}

