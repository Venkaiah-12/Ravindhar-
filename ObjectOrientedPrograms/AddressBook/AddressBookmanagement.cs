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
        public object State { get; private set ; }

        public object FirstName { get; private set; }
        public object LastName { get; private set; }
        public object Village { get; private set; }
        public object Mandal { get; private set; }
        public object District { get; private set; }
        public object City { get; private set; }

        public void UserDetails()
        {
            try
            {
                var jsonfile = File.ReadAllText(filepath);
                var jsonObject = JObject.Parse(jsonfile);
                if (jsonObject != null)
                {
                    JArray jsonarray = (JArray)jsonObject["AddressBook"];
                    if (jsonarray != null)
                    {
                        foreach (var arrayitem in jsonarray)
                        {
                            Console.WriteLine("Firstname" + arrayitem[FirstName].ToString());
                            Console.WriteLine("LastName" + arrayitem[LastName].ToString());
                            Console.WriteLine("Village" + arrayitem[Village].ToString());
                            Console.WriteLine("Mandal" + arrayitem[Mandal].ToString());
                            Console.WriteLine("District" + arrayitem[District].ToString());
                            Console.WriteLine("city" + arrayitem[City].ToString());
                            Console.WriteLine("city" + arrayitem[State].ToString());

                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }

        /*  public void Additem()
        {
            var jsonfile = File.ReadAllText(filepath);
            Console.WriteLine("Enter the firstname")
        }*/
    }
}
