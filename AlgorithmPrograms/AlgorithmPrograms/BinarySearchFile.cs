using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgorithmPrograms
{
    class BinarySearchFile
    {
      public  static void  Binarysearch()  

        {


            try
            {
                StreamReader Sr;
                using (Sr = new StreamReader(@"C:\Users\LENOVO\source\repos\AlgorithmPrograms\AlgorithmPrograms\BinarySearhFile.txt")) 
                {
                    string line = Sr.ReadLine();          
                    string[] arr = line.Split(" ");
                  
                    Console.WriteLine(line);
                    
                    Console.WriteLine("enter the word to key search");
                    string key = Utility.usersinput();
                    int count = 0;
                    int result = Utility.binarysearch(arr, key);
                   if(result == -1)
                    {
                        Console.WriteLine("element not found");

                    }
                   else
                    {
                        Console.WriteLine("element found"+result+" "+count);
                    }
                    
                }
            }
           

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           


        }

    }
}
