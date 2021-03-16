using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Hashtable SalaryInfo = new Hashtable();
            SalaryInfo.Add("Jubair", "180230106");
            SalaryInfo.Add("sohail", "180230103");
            SalaryInfo.Add("nabil", "180230109");
            SalaryInfo.Add("rafat", "180230086");
            SalaryInfo.Add("mamun", "180230066");
            double salary = Convert.ToDouble(SalaryInfo["nabil"]);//geting value from hashtable using key.
            Console.WriteLine(salary);
            SalaryInfo["sohail"] = "180230100"; //putting value in hashtable by using key.
            Console.WriteLine("My Hashtable : ");
            foreach (DictionaryEntry aDictionaryEntr in SalaryInfo)
            {
                Console.WriteLine(aDictionaryEntr.Key + " : " + aDictionaryEntr.Value);
            }

            //another Way
            Console.WriteLine("My Hashtable : ");
            foreach (DictionaryEntry aDictionaryEntr in SalaryInfo)
            {
                Console.WriteLine("{0} : {1}",aDictionaryEntr.Key,aDictionaryEntr.Value);
            }

            Console.WriteLine("Another way to print Hashtable value : ");
            foreach (string values in SalaryInfo.Values)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine("Another way to print Hashtable Keys : ");
            foreach (string keys in SalaryInfo.Keys)
            {
                Console.WriteLine(keys);
            }
            Console.ReadLine();
        }
    }
}
