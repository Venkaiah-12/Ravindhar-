using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructure
{
    class HashingFunction
    {
        public void Hashing()
        {
            HashList List = new HashList();
            try
            {
                StreamReader streamreader;
                streamreader = new StreamReader(@"C:\Users\Bridge Labs\Documents\My Web Sites/Readingfile.txt");
                string str;
                if((str=streamreader.ReadLine()) != null)
                {
                    string[] stringarray = str.Split(" ");
                    int[] array = new int[10];
                  for(int i=0; i<10;i++)
                   {
                        array[i] = int.Parse(stringarray[i]);
                   }
                  for(int loop=0; loop<array.Length;loop++)
                    {

                        int value = array[loop];
                        List.hasing(value);

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
