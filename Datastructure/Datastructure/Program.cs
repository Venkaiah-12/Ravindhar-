using System;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the option :");
            Console.WriteLine("1.UnOrderedList");
            Console.WriteLine("================");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                   
                    UnOrderedList orderedList = new UnOrderedList();
                    orderedList.unorderedlist();
                    break;
                default:
                    break;


            }
        }
    }
}
