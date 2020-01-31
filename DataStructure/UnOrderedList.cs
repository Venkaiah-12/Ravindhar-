using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Datastructure
{
  
    class UnOrderedList
    {
        string[] arr;
        public   void unorderedlist()
        {
           
            LinkedList linkedList = new LinkedList();
            try
            {
                
                
                StreamReader sr;
                sr = new StreamReader(@"C:\files\Reading.txt");
                string str;
                if((str=sr.ReadLine()) != null)
                {
                    arr = str.Split(" ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                  


                }
                Console.WriteLine("nodes of singlylinkedlist");
                foreach (string strvalues in arr)
                {
                    linkedList.addNode(strvalues);
                }
               /*Console.WriteLine("the items to be deleted");
              string item = Utility.userstringinput();
               linkedList.removeNode(item);
               Console.WriteLine("enter the item to search  :");
                string values = Utility.userstringinput();
                Console.WriteLine(linkedList.Search(item));
                Console.WriteLine(linkedList.isEmpty());
                Console.WriteLine(linkedList.Size());
                Console.WriteLine("enter the item to add to the list");
                string word = Utility.userstringinput();
                linkedList.Append(word);*/
                Console.WriteLine("enter the name to find index");
                string name = Utility.userstringinput();
                 Console.WriteLine(linkedList.Index(name));
                Console.WriteLine("enter the position of node to be inserted");
                int pos = Utility.IntegerInput();
                Console.WriteLine("enter the name of node to inserted :");
                string value1 = Utility.userstringinput();
                linkedList.Insert(pos, value1);
                linkedList.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
