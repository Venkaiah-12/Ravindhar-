using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedPrograms.AddressBook;

namespace ObjectOrientedPrograms.AddressBook
{
    class AddressBookData
    {/// <summary>
    /// calling function performing crud operations on json file
    /// </summary>
        public void addressBook()
        {
            AddressBookmanagement addressBookmanagement = new AddressBookmanagement();
            Console.WriteLine("1.Userdetails");
            Console.WriteLine("2.Additem");
            Console.WriteLine("3.Updateitem");
            Console.WriteLine("4.Deleteitem");
            Console.WriteLine("=================");
            Console.WriteLine("Enter your choice");
            ///Calling function to get user input
            int choice = Utility.IntegerInput();
            switch(choice)
            {
                case 1:
                    ///calling function to get userdetails
                    addressBookmanagement.UserDetails();
                    break;
                case 2:
                    ////calling function to add item
                    addressBookmanagement.Additem();
                    break;
                default:
                    ////In this case it will ask to enter the valid option
                    Console.WriteLine("enter the valid option");
                    break;

                   
            }
        }
    }
}
