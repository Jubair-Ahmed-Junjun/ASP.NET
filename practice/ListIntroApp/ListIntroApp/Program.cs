using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listData = new List<string>();
            listData.Add("Asp");
            listData.Add("Dot");
            listData.Add("Net");
            listData.Add("C#");
            Console.WriteLine("The size of List :" + listData.Count);
            List<string> newListData = new List<string>();
            newListData.Add("Junjun");
            newListData.Add("012548xxxxxx");
            newListData.Add("chawkbazar");
            listData.AddRange(newListData);
            Console.WriteLine("The size of List after adding new List && replace a value by other : "+listData.Count);
            listData[4] = "Jubair";
            foreach (string ListItem in listData)
            {
                Console.WriteLine(ListItem);
            }
            string[] arrayData = listData.ToArray();
            listData.Remove("012548xxxxxx");
            Console.WriteLine("After remove a element List will be :");
            foreach (string newItem in listData)
            {
                Console.WriteLine(newItem);
            }
            Console.WriteLine("The size of List after convert to array and remove a elemenet : " + listData.Count);
            listData.Sort();
            Console.WriteLine("The List after sorted :");
            foreach (string sortList in listData)
            {
                Console.WriteLine(sortList);
            }
            Console.ReadLine();

        }
    }
}
