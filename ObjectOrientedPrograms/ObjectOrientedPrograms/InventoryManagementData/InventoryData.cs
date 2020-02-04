using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace ObjectOrientedPrograms.InventoryManagementData
{
    class InventoryData
    {

        /*    public int Rices { get; set; }
            public int Pulses { get; set; }
            public int Wheats { get; set; }*/
            /// <summary>
            /// calling function to get the user data
            /// </summary>
        string jsonFile = @"C:\Users\Bridge Labs\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        public void GetUserDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                ////parsing string into objecting
                var JsonObject = JObject.Parse(json);
                if(JsonObject != null)
                {
                    JArray riceArray = (JArray)JsonObject["Rice"];


                    if (riceArray != null)
                    {
                        foreach( var item in riceArray)
                        {
                            Console.WriteLine("Rice Name:" + item["name"].ToString());
                            Console.WriteLine("Rice price:" + item["price"].ToString());
                            Console.WriteLine("Rice Weight :" + item["weight"].ToString());

                        }
                    }
                }
                if(JsonObject != null)
                {
                    JArray wheatsArray = (JArray)JsonObject["Wheats"];
                    if (wheatsArray != null)
                    {
                        foreach(var item in wheatsArray)
                        {
                            Console.WriteLine("Wheats Name :" + item["name"].ToString());
                            Console.WriteLine("Wheats Price :" + item["price"].ToString());
                            Console.WriteLine("Wheats weight :" + item["weight"].ToString());

                        }
                    }
                }
                if(JsonObject != null)
                {
                    JArray pulsesArray = (JArray)JsonObject["Pulses"];
                    foreach(var item in pulsesArray)
                    {
                        Console.WriteLine("Pulses Name :" + item["name"].ToString());
                        Console.WriteLine("Pulses price :" + item["price"].ToString());
                        Console.WriteLine("Pulses weight :" + item["weight"].ToString());

                    }
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }/// <summary>
        /// calling function to add item in json file
        /// </summary>
        public void AddItem()
        {
          //  var json = File.ReadAllText(jsonFile);
            Console.WriteLine("Enter the itemname ");
            var itemname = Console.ReadLine();
            Console.WriteLine("enter the Type of item name");
            var itemtypename = Console.ReadLine();
            Console.WriteLine("enter the price of item");
            var price = Console.ReadLine();
            Console.WriteLine("enter the weight");
            var weight = Console.ReadLine();
            ////setting the user data in array format present in json file
            var newItem = "{ 'name': '" + itemtypename + "','price':" + price + ",'weight':" + weight + "}";
            var json = File.ReadAllText(this.jsonFile);
            var jsonObject = JObject.Parse(json);
            var itemArray = jsonObject.GetValue(itemname) as JArray;
            var newitemObject = JObject.Parse(newItem);
            Console.WriteLine("newitemobject" +newitemObject);
            itemArray.Add(newitemObject);
            Console.WriteLine("item array :" + itemArray);
            jsonObject[itemname] = itemArray;
            ////converting string file data into object data
            string newJsonResult = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText(this.jsonFile, newJsonResult);


        }/// <summary>
        /// calling funcrion to update the data in the json file 
        /// </summary>
        public void UpdateFile()
        {
            string json = File.ReadAllText(this.jsonFile);
            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();
                JArray riceArrary = (JArray)jsonObject[itemNameToUpdate];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();
                Console.Write("Enter new Item name : ");
                var newItemName = Convert.ToString(Console.ReadLine());
                /////comparing value which data to compare 
                foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(itemName)))
                {
                    ////using ternary operator to true or false 
                    item["name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : string.Empty;
                }

                jsonObject["name"] = riceArrary;
                /////serializing the data to object
                string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
                Console.WriteLine(newItemName + " is Updated on " + itemName);
            }
            ////calling expection which type is data is used
            catch (Exception exception)
            {
                Console.WriteLine("Update Error : " + exception.Message.ToString());
            }
        }
        /// <summary>
        /// calling function to delete item 
        /// </summary>
        public void DeleteItem()
        {
            string  json = File.ReadAllText(this.jsonFile);

            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter the item Name ");
                var itemname = Console.ReadLine();
                JArray itemArray = (JArray)jsonObject[itemname];
                Console.WriteLine("Enter the item tyoe to be deleted");
                var itemtypetodelete = Console.ReadLine();
                ////here  it compare the data and if find delete the item 
                var itemtoDeleted = itemArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(itemtypetodelete));
                ////removing item from json file
                itemArray.Remove(itemtypetodelete);
                string Resultoutput = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(jsonFile, Resultoutput);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
