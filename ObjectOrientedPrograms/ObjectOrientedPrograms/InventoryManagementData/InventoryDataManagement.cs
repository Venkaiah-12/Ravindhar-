using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedPrograms.InventoryManagementData;
namespace ObjectOrientedPrograms.InventoryManagementData
{
    class InventoryDataManagement
    {/// <summary>
    /// calling function to perform crud operationson switch case
    /// </summary>
        public void Inventorydatamanagement()
        {
            InventoryData inventoryData = new InventoryData();
            Console.WriteLine("Press 1.GetUserDetails:");
            Console.WriteLine("Press 2.AddItem:");
            Console.WriteLine("Press 3.Update Item:");
            Console.WriteLine("Press 3.Delete Item:");
            Console.WriteLine("=======================");
            Console.WriteLine("Enter the choice :");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ////calling function to getuserdetails
                    inventoryData.GetUserDetails();
                    break;
                case 2:
                    ////calling function to add item
                    inventoryData.AddItem();
                    break;
                case 3:
                    ////calling function to update item
                    inventoryData.UpdateFile();
                    break;
                case 4:
                    ////calling function to deleteitem
                    inventoryData.DeleteItem();
                    break;

                default:
                    ////if invalid option enter by user it will ask to enter the option
                    Console.WriteLine("enter the valid option");
                    break;


            }



        }
    }
}
