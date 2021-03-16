using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> salaryInfo = new Dictionary<string, double>();
            salaryInfo.Add("jubair", 18023010);
            salaryInfo.Add("nabil", 180230109);
            salaryInfo.Add("sohail", 180230103);
            salaryInfo.Add("forkan", 180230105);
            salaryInfo.Add("walid", 180230106);
            foreach (KeyValuePair<string,double> dictionaryItems in salaryInfo)
            {
                Console.WriteLine(dictionaryItems.Key +" : "+dictionaryItems.Value);
            }

            salaryInfo.Remove("walid");
            Console.WriteLine("After Remove a Element : ");
            foreach (KeyValuePair<string, double> dictionaryItems in salaryInfo)
            {
                Console.WriteLine(dictionaryItems.Key + " : " + dictionaryItems.Value);
            }
            var hashCode = salaryInfo.GetHashCode();
            Console.WriteLine("The hashcode : "+hashCode+"\n");

            var type = salaryInfo.GetType();
            Console.WriteLine("Dictionary Type : "+type);
            Console.ReadLine();
        }
    }
}
