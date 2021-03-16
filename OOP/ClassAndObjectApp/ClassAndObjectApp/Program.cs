using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.firstName = "Jubair";
            aPerson.middleName = "Ahmed";
            aPerson.lastName = "Junjun";
            string fullName = aPerson.GetFullName();
            Console.WriteLine(fullName);
            Person bPerson = new Person();
            bPerson.firstName = "Ashraful";
            bPerson.middleName = "Anam";
            bPerson.lastName = "Nabil";
            string bPersonFullName = bPerson.GetFullName();
            Console.WriteLine(bPersonFullName);
            Console.ReadLine();
            
        }
    }
}
