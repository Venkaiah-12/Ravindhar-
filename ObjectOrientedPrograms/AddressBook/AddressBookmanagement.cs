using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace ObjectOrientedPrograms.AddressBook
{
    class AddressBookmanagement
    {
        string filepath = @"C:\Users\Bridge Labs\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook\AddressBookFile.json";
        public void UserDetails()
        {
            try
            {
                var jsonfile = File.ReadAllText(filepath);
                ////converting string into object by using parsing
                var jsonObject = JObject.Parse(jsonfile);
                if (jsonObject != null)
                {
                    ////converting jsonobject into jsonarray
                    JArray jsonarray = (JArray)jsonObject["AddressBook"];
                    if (jsonarray != null)
                    {
                        foreach (var arrayitem in jsonarray)
                        {

                            Console.WriteLine("Firstname :" + arrayitem["FirstName"].ToString());
                            Console.WriteLine("LastName :" + arrayitem["LastName"].ToString());
                            Console.WriteLine("Village :" + arrayitem["Village"].ToString());
                            Console.WriteLine("Mandal :" + arrayitem["Mandal"].ToString());
                            Console.WriteLine("District :" + arrayitem["District"].ToString());
                            Console.WriteLine("city :" + arrayitem["City"].ToString());
                            Console.WriteLine("state :" + arrayitem["State"].ToString());
                            Console.WriteLine("pincode :" + arrayitem["PinCode"].ToString());

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// calling function to add item to existing file using file path
        /// </summary>
        public void Additem()
        {
            try
            {
                Console.WriteLine("Enter the position");
                string itemname = Utility.StringInput();
                Console.WriteLine("Enter the firstname");
                string FirstName = Utility.StringInput();
                Console.WriteLine("Enter the Last name");
                string LastName = Utility.StringInput();
                Console.WriteLine("Enter the Village");
                string Village = Utility.StringInput();
                Console.WriteLine("Enter the Mandal");
                string Mandal = Utility.StringInput();
                Console.WriteLine("Enter the District");
                string District = Utility.StringInput();
                Console.WriteLine("Enter the City");
                string City = Utility.StringInput();
                Console.WriteLine("Enter the State");
                string State = Utility.StringInput();
                Console.WriteLine("Enter the PinCode");
                var PinCode = int.Parse(Console.ReadLine());
                var jsonfile = File.ReadAllText(filepath);
                var jsonObject = JObject.Parse(jsonfile);
                JArray personarray = (JArray)jsonObject["AddressBook"];
                JObject adddingitem = new JObject
                {
                    {"FirstName",FirstName},
                    {"LastName",LastName },
                    {"Village",Village },
                    {"Mandal",Mandal },
                    {"District",District },
                    {"City",City },
                    {"State",State },
                    {"PinCode",PinCode }

                };
                personarray.Add(adddingitem);
                ////
                ///reteriving data from user and setting them in array format 
              /*  var newItem = "{ 'firstName': '" + FirstName + "','lastName':'" + LastName + "','Village':'" + Village + "','State':'" + State + "','City':'" + City + "','Mandal':" + Mandal + ",'PinCode':" + PinCode + "}";
                var jsonfile = File.ReadAllText(filepath);
                var jsonObject = JObject.Parse(jsonfile);
                var itemarray = jsonObject.GetValue(itemname) as JArray;
                var newItemObject = JObject.Parse(newItem);*/
                ////performing add operation 
              
                string newJsonResult = JsonConvert.SerializeObject(personarray, Formatting.Indented);
                File.WriteAllText(this.filepath, newJsonResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


}
