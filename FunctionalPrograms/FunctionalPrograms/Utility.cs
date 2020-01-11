using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        public static int userInputs()
        {

            return int.Parse(Console.ReadLine());
        }
        public static void checkwin(int wins, int trails)
        {


            Random r = new Random();
            for (int i = 0; i < trails; i++)
            {

                double value = r.Next();
                if (value > 0.5)
                {
                    wins++;

                }
            }

        }
        public static void shuffle(double[,] arr,int m,int n)
        {
            int c = 0;
            int count = 0;

            Random random = new Random();
            int number = random.Next();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == number)
                        c++;

                }
            }

            if (c == 0)
            {
                int c1 = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i, j] == 0)
                        {
                            arr[i, j] = n;
                            c1++;

                        }
                    }

                    if (c1 != 0)

                        break;
                }
            }


            else
            {
                shuffle(arr, m, n);
                count++;
            }

                if(count<m*n)
                {
                    shuffle(arr,m,n);
                }
              
                }
            
        }

       
        
    }

