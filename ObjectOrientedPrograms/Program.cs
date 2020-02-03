using ObjectOrientedPrograms.InventoryManagementData;
using System;
using ObjectOrientedPrograms.AddressBook;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 : Address Book");
            Console.WriteLine("Press 2 : Inventory Data");
            Console.WriteLine("Press 3 : Inventory Management");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    AddressBookData address = new AddressBookData();
                    address.addressBook();
                    break;
                case 2:
                    InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
                    inventoryDataManagement.Inventorydatamanagement();
                    break;
                case 3:
                 
                    InventoryManagement.Inventorymanagement();
                    break;
                   
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}
