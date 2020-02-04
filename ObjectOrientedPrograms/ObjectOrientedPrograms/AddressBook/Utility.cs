using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    class Utility
    {/// <summary>
    /// calling function returning integer input
    /// </summary>
    /// <returns></returns>
        public static int IntegerInput()
        {
        return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// calling function returning string input
        /// </summary>
        /// <returns></returns>
        public static string StringInput()
        {
            return Console.ReadLine();
        }
     }   
}
