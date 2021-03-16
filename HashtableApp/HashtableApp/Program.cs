using System;
using System.Collections;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable SalaryInfo = new Hashtable();
            SalaryInfo.Add("Jubair","180230106");
            SalaryInfo.Add("sohail", "180230103");
            SalaryInfo.Add("nabil", "180230109");
            SalaryInfo.Add("rafat", "180230086");
            SalaryInfo.Add("mamun", "180230066");

            double salary = Convert.ToDouble( SalaryInfo["nabil"]);//geting value from hashtable using key.
            Console.WriteLine(salary);
            SalaryInfo["sohail"] = "180230100"; //putting value in hashtable by using key.
            foreach(DictionaryEntry aDictionaryEntr in SalaryInfo)
            {
                Console.WriteLine(aDictionaryEntr.Key + " : " + aDictionaryEntr.Value);
            }
            foreach(string akey in SalaryInfo.Keys)
            {
                Console.WriteLine(akey);
            }
            Console.ReadKey();
        }
    }
}
