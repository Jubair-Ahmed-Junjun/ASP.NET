using System;
using System.Collections.Generic;
using System.Collections;


namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListData = new List<string>();
            ListData.Add("Juabir Ahmed Junjun");
            ListData.Add("BGCTUB.");
            ListData.Add("01854xxxxx");
            Console.WriteLine("The size of previous List : " +ListData.Count);
            List<string> newList = new List<string>();
            newList.Add("Chawlbazar");
            newList.Add("Chittagong");
            newList.Add("Bangladesh");
            ListData.AddRange(newList);
            Console.WriteLine("The size of List afetr add New List : "+ListData.Count);
            ListData[0] = "10";
            foreach(string data in ListData)
            {
                Console.WriteLine(data);              
            }
            Console.ReadKey();

        }
        
    }
}
