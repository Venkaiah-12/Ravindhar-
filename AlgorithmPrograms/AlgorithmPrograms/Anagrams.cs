using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagrams
    {
        public  void anagrams()
        {
            bool status = true;
            Console.WriteLine("enter the first string");
            string str1 = Utility.usersinput();
            Console.WriteLine("enter the second string");
                string str2 = Utility.usersinput();
          int  firstlength = str1.Length;
            int secondlength = str2.Length;
            if(firstlength == secondlength)
            {
                char[] s1 = str1.ToCharArray();
                char[] s2 = str2.ToCharArray();
                Array.Sort(s1);
                Array.Sort(s2);
               for(int i=0;i<s1.Length;i++)
                {
                    for(int j=0;j<s1.Length;j++)
                    {
                        if(s1[i]==s2[j])
                        {
                            status=  true; 
                        }
                        else
                        {
                            status = false;

                        }
                    }
                }

                

            }else
            {
                status = false;

            }
            if(status== true)
            {
                Console.WriteLine("string are anagram");
            }
            else
            {
                Console.WriteLine("string are not anagram");
            }


        }
    }
}
