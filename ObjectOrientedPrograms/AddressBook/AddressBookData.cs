using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedPrograms.AddressBook;

namespace ObjectOrientedPrograms.AddressBook
{
    class AddressBookData
    {
        public void addressBook()
        {
            AddressBookmanagement addressBookmanagement = new AddressBookmanagement();
            Console.WriteLine("1.Userdetails");
            Console.WriteLine("2.Additem");
            Console.WriteLine("3.Updateitem");
            Console.WriteLine("4.Deleteitem");
            Console.WriteLine("=================");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    addressBookmanagement.UserDetails();
                    break;
                default:
                    Console.WriteLine("enter the valid option");
                    break;

                   
            }
        }
    }
}
