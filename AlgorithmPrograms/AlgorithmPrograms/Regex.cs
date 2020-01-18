using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace AlgorithmPrograms
{
    class Regex
    {
        public  void regularexpression()
        {
            string fulldata = ": Hello <<name>>, We have your full name as << full name >> in our system. your contact number is 91 - xxxxxxxxxx.Please,let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            string firstname = Console.ReadLine();
            string pattern = @"^[ a – z A – Z 0 – 9 . -] {3,16} $";
            Match m = IsMatch(firstname, pattern);


        }
        public static bool IsMatch(string firstname,string pattern)
        {
            

          
        }
     
    }
}
