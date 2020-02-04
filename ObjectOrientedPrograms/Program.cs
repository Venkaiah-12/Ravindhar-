using ObjectOrientedPrograms.InventoryManagementData;
using System;
using ObjectOrientedPrograms.AddressBook;

namespace ObjectOrientedPrograms
{
    class Program
    {/// <summary>
    /// calling another class methods by creating object to class
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 : Address Book");
            Console.WriteLine("Press 2 : Inventory Data");
            Console.WriteLine("Press 3 : Inventory Management");
            ////this variable getting user integerinput
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ////calling dunction by creating object
                    AddressBookData address = new AddressBookData();
                    address.addressBook();
                    break;
                case 2:
                    ////calling function by creating object
                    InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
                    inventoryDataManagement.Inventorydatamanagement();
                    break;
                case 3:
                 ////calling function by creating for another class
                    InventoryManagement.Inventorymanagement();
                    break;
                   
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}
