using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagram
    {
      
        public  void Primeanagram()
        {
           PrimeAnagramtoStack primeAnagramtoStack = new PrimeAnagramtoStack();

            int[,] array = new int[10, 100];
            int K = 1;
            bool prime;
            int n = 0;
            bool F;
            
            for (int loop = 0; loop < 10; loop++)
            {
                for (int loop1 = 0; loop1 < 100; loop1++)
                {
                    array[loop, loop1] = K;
                    K++;
                }

            }
            for (int loop1 = 0; loop1 < 10; loop1++)
            {
                for (int loop = 0; loop < 100; loop++)
                {
                    n = array[loop1, loop];
                    ////calling function to check prime or not 
                    prime = Primecheck(n);
                    if (prime == true && array[loop1, loop] > 11 && array[loop1,loop] < 1000)
                    {
                        
                        F = PrimeAnagramcheck(array[loop1, loop]);
                        if (F == true)
                        {
                            primeAnagramtoStack.Anagramstack(array[loop1, loop]);
                            primeAnagramtoStack.Display();

                            Console.WriteLine(array[loop1, loop]+"");
                        }

                    }

                }
                Console.WriteLine();
            }
        }

            public bool Primecheck(int n)
            {
                int count = 0;
                for (int index = 1; index < 1000; index++)
                {
                    if (n % index == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        public bool PrimeAnagramcheck(int n)
        {
            string str = " ";
            int b;
            for (int loop = 0; loop < 168; loop++)
            {
                b = n;

                while (b > 0)
                {
                    int remainder = n % 10;

                    if (remainder == loop)
                    {
                        str = str + remainder;
                    }
                    b = b / 10;

                }
            }
            int P = int.Parse(str);
            bool f = Primecheck(P);
            if(f==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        }

    }

