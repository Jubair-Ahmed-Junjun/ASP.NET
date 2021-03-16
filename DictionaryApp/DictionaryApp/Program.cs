using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> salaryInfo = new Dictionary<string, double>();
            salaryInfo.Add("jubair",1223);
            salaryInfo.Add("nabil", 12564);
            salaryInfo.Add("sohail", 13654);
            salaryInfo.Add("forkan", 321654);
            salaryInfo.Add("mamun", 1234567);
            foreach(KeyValuePair<string,double> data in salaryInfo)
            {
                Console.WriteLine(data.Key+" "+data.Value);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
